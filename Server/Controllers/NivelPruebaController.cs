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
    public class NivelPruebaController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public NivelPruebaController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<NivelPrueba>>> Get()
        {
            return await _db.NivelPruebas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NivelPrueba>> Get(long id)
        {
            return await _db.NivelPruebas.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
