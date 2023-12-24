using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngresoFMP.Shared.Models
{
    public class Pruebas
    {
        public long Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public long LenguajesProgramacionId { get; set; }
        public LenguajesProgramacion LenguajesProgramacion { get; set; } = null!;
        public long NivelPruebaId { get; set; }
        public NivelPrueba NivelPrueba { get; set; } = null!;
        public string Tipoprueba { get; set; } = null!;
        public int Cantidadpreguntas { get; set; }
        public string? Usuario { get; set; }
        public DateTime? Fechaactualizacion { get; set; }


    }
}
