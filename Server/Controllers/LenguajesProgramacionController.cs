﻿using Microsoft.AspNetCore.Authorization;
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
    public class LenguajesProgramacionController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public LenguajesProgramacionController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<LenguajesProgramacion>>> Get()
        {
            return await _db.LenguajesProgramacions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LenguajesProgramacion>> Get(long id)
        {
            return await _db.LenguajesProgramacions.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
