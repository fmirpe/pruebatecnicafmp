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
    public class AspirantesController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public AspirantesController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<ActionResult> Add(Aspirantes aspiranteDTO)
        {
            ActionResult result = BadRequest();
            if (aspiranteDTO != null)
            {
                _db.Aspirantes.Add(aspiranteDTO);
                await _db.SaveChangesAsync();
                return new CreatedAtRouteResult("GetId", new { id = aspiranteDTO.Id }, aspiranteDTO);
            }
            return result;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Aspirantes aspirantesDTO)
        {
            _db.Entry(aspirantesDTO).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var registro = new Aspirantes { Id = id};
            _db.Remove(registro);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet]
        public async Task<ActionResult<List<Aspirantes>>> Get([FromQuery] Paginacion paginacion)
        {
            var queryble = _db.Aspirantes.AsQueryable();
            await HttpContext.InsetarParametrosRespuesta(queryble, paginacion.CantidadMostrar);
            return await queryble.Paginar(paginacion).ToListAsync();
        }

        [HttpGet(Name = "GetAll")]
        [Route("[action]")]
        public async Task<ActionResult<List<Aspirantes>>> GetAll()
        {
            return await _db.Aspirantes.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetId")]
        public async Task<ActionResult<Aspirantes>> GetId(long id)
        {
            return await _db.Aspirantes.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
