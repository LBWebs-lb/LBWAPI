using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiLbWebs.Models;

namespace ApiLbWebs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class clihosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public clihosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/clihos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<clihos>>> Getclihos()
        {
            return await _context.clihos.ToListAsync();
        }

        // GET: api/clihos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<clihos>> Getclihos(int id)
        {
            var clihos = await _context.clihos.FindAsync(id);

            if (clihos == null)
            {
                return NotFound();
            }

            return clihos;
        }

        // PUT: api/clihos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putclihos(int id, clihos clihos)
        {
            if (id != clihos.ihos)
            {
                return BadRequest();
            }

            _context.Entry(clihos).State = EntityState.Modified;

            try
            {
                clihos.hmod = DateTime.Now.ToString("HH:mm");
                clihos.fmod = DateTime.Now.ToString("dd/M/yyyy");
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!clihosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/clihos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<clihos>> Postclihos(clihos clihos)
        {
            clihos.faltrto = DateTime.Now;
            clihos.hmod = DateTime.Now.ToString("HH:mm");
            clihos.fmod = DateTime.Now.ToString("dd/M/yyyy");
            _context.clihos.Add(clihos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getclihos", new { id = clihos.ihos }, clihos);
        }

        // DELETE: api/clihos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<clihos>> Deleteclihos(int id)
        {
            var clihos = await _context.clihos.FindAsync(id);
            if (clihos == null)
            {
                return NotFound();
            }

            _context.clihos.Remove(clihos);
            await _context.SaveChangesAsync();

            return clihos;
        }

        private bool clihosExists(int id)
        {
            return _context.clihos.Any(e => e.ihos == id);
        }
    }
}
