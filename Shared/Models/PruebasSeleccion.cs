using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngresoFMP.Shared.Models
{
    public class PruebasSeleccion
    {
        public long Id { get; set; }
        public long AspiranteId { get; set; }
        public Aspirantes Aspirante { get; set; } = null!;
        public long PruebasId { get; set; }
        public Pruebas Pruebas { get; set; } = null!;
        public DateTime Fechainicio { get; set; }
        public DateTime? Fechafinalizacion { get; set; }
        public long EstadospruebasId { get; set; }
        public EstadosPrueba EstadosPruebas { get; set; } = null!;
        public int Calificacion { get; set; }
        public string? Usuario { get; set; }
        public DateTime? Fechaactualizacion { get; set; }
    }
}
