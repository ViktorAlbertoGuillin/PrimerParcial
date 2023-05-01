using Calculadora.Repositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Repositorio.Interfaces
{
    public interface ICalculadoraRepositorio
    {
        void GuardarResultados(Resultados resultados);
        List<Resultados> Listar();
    }
}
