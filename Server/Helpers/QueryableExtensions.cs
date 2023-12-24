using PruebaIngresoFMP.Shared.Models;

namespace PruebaIngresoFMP.Server.Helpers
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> Paginar<T>(this IQueryable<T> queryable, Paginacion paginacion)
        {
            return queryable
                .Skip((paginacion.Pagina - 1) * paginacion.CantidadMostrar)
                .Take(paginacion.CantidadMostrar);
        }
    }
}
