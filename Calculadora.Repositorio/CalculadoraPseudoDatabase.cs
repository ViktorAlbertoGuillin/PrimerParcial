using Calculadora.Repositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Repositorio
{
    public class CalculadoraPseudoDatabase
    {
        public static List<Resultados> resultados = new List<Resultados>(0);   // se crea la lista de resultados 
        


        public static List<Resultados> GetResultados()
        {
            return resultados;
        }

    }
}
