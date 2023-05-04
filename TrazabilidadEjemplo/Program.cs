using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace TrazabilidadAlimentaria
{
    class Bloque
    {
        public int Id { get; set; }
        public string Datos { get; set; }
        public string Hash { get; set; }
        public string HashAnterior { get; set; }
        public DateTime Tiempo { get; set; }
    }

    class CadenaBloques
    {
        public List<Bloque> Bloques = new List<Bloque>();

        public void AgregarBloque(string datos)
        {
            Bloque nuevoBloque = new Bloque();
            nuevoBloque.Id = Bloques.Count + 1;
            nuevoBloque.Datos = datos;
            nuevoBloque.HashAnterior = Bloques.Count == 0 ? "0" : Bloques.Last().Hash;
            nuevoBloque.Tiempo = DateTime.Now;
            nuevoBloque.Hash = CalcularHash(nuevoBloque);
            Bloques.Add(nuevoBloque);
        }

        private string CalcularHash(Bloque bloque)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes($"{bloque.Id}-{bloque.Datos}-{bloque.HashAnterior}-{bloque.Tiempo}");
            byte[] outputBytes = sha256.ComputeHash(inputBytes);
            return Convert.ToBase64String(outputBytes);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CadenaBloques cadena = new CadenaBloques();
            List<string> alimentos = new List<string> { "leche", "huevos", "pollo", "manzanas", "zanahorias", "pescado" };
            Random rnd = new Random();

            // Generar datos de ejemplo
            for (int i = 0; i < 10; i++)
            {
                string alimento = alimentos[rnd.Next(alimentos.Count)];
                cadena.AgregarBloque($"Lote {i + 1} de {alimento} producido por el agricultor A");
            }

            // Imprimir la cadena de bloques
            foreach (Bloque bloque in cadena.Bloques)
            {
                Console.WriteLine($"Bloque {bloque.Id}\nDatos: {bloque.Datos}\nHash: {bloque.Hash}\n");
            }

            Console.ReadKey();
        }
    }
}

