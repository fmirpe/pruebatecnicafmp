using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaIngresoFMP.Server.Data;
using PruebaIngresoFMP.Server.Helpers;
using PruebaIngresoFMP.Shared.Models;

namespace PruebaIngresoFMP.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PruebasSeleccionController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public PruebasSeleccionController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<ActionResult> Add(PruebasSeleccion regi)
        {
            ActionResult result = BadRequest();
            if (regi != null)
            {
                _db.PruebasSeleccions.Add(regi);
                await _db.SaveChangesAsync();
                return new CreatedAtRouteResult("GetById", new { id = regi.Id }, regi);
            }
            return result;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, PruebasSeleccion regi)
        {
            _db.Entry(regi).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var registro = new PruebasSeleccion { Id = id };
            _db.Remove(registro);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet("GetAllPag")]
        public async Task<ActionResult<List<PruebasSeleccion>>> Get([FromQuery] Paginacion paginacion)
        {
            var queryble = _db.PruebasSeleccions
                .Include(p => p.Aspirante)
                .Include(p => p.EstadosPruebas)
                .Include(p => p.Pruebas).AsQueryable();
            await HttpContext.InsetarParametrosRespuesta(queryble, paginacion.CantidadMostrar);
            return await queryble.Paginar(paginacion).ToListAsync();
        }

        [HttpGet("{id}", Name = "GetById")]
        public async Task<ActionResult<PruebasSeleccion>> GetById(long id)
        {
            return await _db.PruebasSeleccions
                .Include(p => p.Aspirante)
                .Include(p => p.EstadosPruebas)
                .Include(p => p.Pruebas).FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
