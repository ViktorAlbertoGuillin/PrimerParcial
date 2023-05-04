using System.Security.Cryptography;
// Definición de clases
class Bloque
{
    public int id;
    public string datos;
    public string hash;
    public string hash_anterior;
    public DateTime tiempo;
}

class CadenaBloques
{
    public List<Bloque> bloques = new List<Bloque>();

    // Método para agregar un bloque a la cadena
    public void agregarBloque(string datos)
    {
        Bloque nuevoBloque = new Bloque();
        nuevoBloque.id = bloques.Count + 1;
        nuevoBloque.datos = datos;
        nuevoBloque.hash_anterior = bloques.Count == 0 ? "0" : bloques.Last().hash;
        nuevoBloque.tiempo = DateTime.Now;
        nuevoBloque.hash = calcularHash(nuevoBloque);
        bloques.Add(nuevoBloque);
    }

    // Método para calcular el hash de un bloque
    public string calcularHash(Bloque bloque)
    {
        // Implementar un algoritmo hash seguro, como SHA-256
        return SHA256.Create(bloque.id + bloque.datos + bloque.hash_anterior + bloque.tiempo).ToString();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Definición de variables
        CadenaBloques cadena = new CadenaBloques();
        List<string> alimentos = new List<string>(); ;
        alimentos.Add("leche");
        alimentos.Add("huevos");
        alimentos.Add("pollo");
        alimentos.Add("manzanas");
        alimentos.Add("zanahorias");
        alimentos.Add("zanahorias");
        alimentos.Add("pescado");
        Random rnd = new Random();

        // Generar datos de ejemplo
        for (int i = 0; i < 10; i++)
        {
            string alimento = alimentos[rnd.Next(alimentos.Count)];
            cadena.agregarBloque($"Lote {i + 1} de {alimento} producido por el agricultor A");
        }

        // Imprimir la cadena de bloques
        foreach (Bloque bloque in cadena.bloques)
        {
            Console.WriteLine($"Bloque {bloque.id}\nDatos: {bloque.datos}\nHash: {bloque.hash}\n");
        }
    } 
}

