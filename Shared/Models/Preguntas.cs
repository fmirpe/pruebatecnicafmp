using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngresoFMP.Shared.Models
{
    public class Preguntas
    {
        public long Id { get; set; }
        public long PruebasId { get; set; }
        public Pruebas Pruebas { get; set; } = null!;
        public string Pregunta { get; set; } = null!;
        public string Respuesta { get; set; } = null!;
        public string? Usuario { get; set; }
        public DateTime? Fechaactualizacion { get; set; }
        
    }
}
