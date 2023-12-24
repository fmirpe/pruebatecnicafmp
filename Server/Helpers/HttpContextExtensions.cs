using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PruebaIngresoFMP.Server.Helpers
{
    public static class HttpContextExtensions
    {
        public static async Task InsetarParametrosRespuesta<T>(this HttpContext context, IQueryable<T> queryble, int cantidadMostrar)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            double conteo = await queryble.CountAsync();
            double totalPaginas = Math.Ceiling(conteo / cantidadMostrar);
            context.Response.Headers.Add("totalPaginas", totalPaginas.ToString());

        }
    }
}
