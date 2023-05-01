using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Repositorio.Entidades
{
    public class Datos
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El ingreso de la Base es obligatoria")]
        [Range(1, 100, ErrorMessage ="La base debe ser un valor entero entre 1 y 100")]
        public int Base { get; set; }
        [Required(ErrorMessage = "El ingreso de la Altura es obligatoria")]
        [Range(1, 100, ErrorMessage = "La altura debe ser un valor entero entre 1 y 100")]
        public int Altura { get; set; }
    }
}
