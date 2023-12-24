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
    public class PruebasController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public PruebasController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Pruebas>>> Get()
        {
            return await _db.Pruebas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pruebas>> Get(long id)
        {
            return await _db.Pruebas.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
