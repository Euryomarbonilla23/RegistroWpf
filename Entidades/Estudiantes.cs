using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Registro.Entidades{

    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Nombre { get; set; } 
        public string Apellido { get; set; } 
        public DateTime Edad { get; set; }
        public string Matricula { get; set; } 
        public string Carrera { get; set; } 
    }
}