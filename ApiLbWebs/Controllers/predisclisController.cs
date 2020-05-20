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
    public class predisclisController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public predisclisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/predisclis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<prediscli>>> Getprediscli()
        {
            return await _context.prediscli.ToListAsync();
        }

        // GET: api/predisclis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<prediscli>> Getprediscli(int id)
        {
            var prediscli = await _context.prediscli.FindAsync(id);

            if (prediscli == null)
            {
                return NotFound();
            }

            return prediscli;
        }

        // PUT: api/predisclis/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putprediscli(int id, prediscli prediscli)
        {
            if (id != prediscli.ipredis)
            {
                return BadRequest();
            }

            _context.Entry(prediscli).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!prediscliExists(id))
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

        // POST: api/predisclis
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<prediscli>> Postprediscli(prediscli prediscli)
        {
            _context.prediscli.Add(prediscli);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getprediscli", new { id = prediscli.ipredis }, prediscli);
        }

        // DELETE: api/predisclis/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<prediscli>> Deleteprediscli(int id)
        {
            var prediscli = await _context.prediscli.FindAsync(id);
            if (prediscli == null)
            {
                return NotFound();
            }

            _context.prediscli.Remove(prediscli);
            await _context.SaveChangesAsync();

            return prediscli;
        }

        private bool prediscliExists(int id)
        {
            return _context.prediscli.Any(e => e.ipredis == id);
        }
    }
}
