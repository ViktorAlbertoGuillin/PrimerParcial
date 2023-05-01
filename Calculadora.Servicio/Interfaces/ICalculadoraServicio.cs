using Calculadora.Repositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Servicio.Interfaces
{
    public interface ICalculadoraServicio
    {
        Resultados CalcularResultado(Datos datos);
        void GuardarResultado(Resultados resultado);
        List<Resultados> ListarResultados();
    }
}
