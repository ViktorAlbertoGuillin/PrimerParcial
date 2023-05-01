using Calculadora.Repositorio.Entidades;
using Calculadora.Repositorio.Interfaces;
using Calculadora.Servicio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Servicio
{

    public class CalculadoraServicio : ICalculadoraServicio
    {
        readonly ICalculadoraRepositorio _repositorio;
        public CalculadoraServicio(ICalculadoraRepositorio repositorio)    // importantisimo tener este constructor para enlazar con el repositorio
        {
            _repositorio = repositorio;
        }

        public Resultados CalcularResultado(Datos datos)
        {
            float area = (datos.Base * datos.Altura) / 2;
            Resultados resultados = new Resultados();
            resultados.Altura = datos.Altura;
            resultados.Base = datos.Base;
            resultados.Resultado = area;
            return resultados;
        }

        public void GuardarResultado(Resultados resultado)
        {
            _repositorio.GuardarResultados(resultado);
        }

        public List<Resultados> ListarResultados()
        {
            return _repositorio.Listar();
        }
    }
}
