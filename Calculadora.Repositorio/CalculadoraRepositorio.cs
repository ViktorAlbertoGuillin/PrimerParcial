using Calculadora.Repositorio.Entidades;
using Calculadora.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Repositorio
{
    public class CalculadoraRepositorio : ICalculadoraRepositorio
    {
        private int ObtenerUltimoId()
        {
            if(CalculadoraPseudoDatabase.GetResultados().Count() == 0) 
            { 
                return 0;
            }
            else
            {
                int ultimo = CalculadoraPseudoDatabase.GetResultados().LastOrDefault().Id;
                return ultimo;
            }
        }
        public void GuardarResultados(Resultados resultados)
        {
            int idUltimo = ObtenerUltimoId();
            idUltimo++;
            resultados.Id = (int)idUltimo;
            CalculadoraPseudoDatabase.GetResultados().Add(resultados);
        }

        public List<Resultados> Listar()
        {
            return CalculadoraPseudoDatabase.GetResultados();
        }
        
    }
}
