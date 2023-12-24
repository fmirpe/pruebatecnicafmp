using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngresoFMP.Shared.Models
{
    public class Paginacion
    {
        public int Pagina { get; set; } = 1;
        public int CantidadMostrar { get; set; } = 10;
    }
}
