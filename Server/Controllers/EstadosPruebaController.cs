using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaIngresoFMP.Server.Data;
using PruebaIngresoFMP.Shared.Models;

namespace PruebaIngresoFMP.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EstadosPruebaController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public EstadosPruebaController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<EstadosPrueba>>> Get()
        {
            return await _db.Estadospruebas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EstadosPrueba>> Get(long id)
        {
            return await _db.Estadospruebas.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
