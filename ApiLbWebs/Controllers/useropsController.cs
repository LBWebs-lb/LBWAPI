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
    public class useropsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public useropsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/userops
        [HttpGet]
        public async Task<ActionResult<IEnumerable<userop>>> Getuserop()
        {
            return await _context.userop.ToListAsync();
        }

        // GET: api/userops/5
        [HttpGet("{id}")]
        public async Task<ActionResult<userop>> Getuserop(int id)
        {
            var userop = await _context.userop.FindAsync(id);

            if (userop == null)
            {
                return NotFound();
            }

            return userop;
        }

        // PUT: api/userops/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putuserop(int id, userop userop)
        {
            if (id != userop.iuserop)
            {
                return BadRequest();
            }

            _context.Entry(userop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!useropExists(id))
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

        // POST: api/userops
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<userop>> Postuserop(userop userop)
        {
            _context.userop.Add(userop);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getuserop", new { id = userop.iuserop }, userop);
        }

        // DELETE: api/userops/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<userop>> Deleteuserop(int id)
        {
            var userop = await _context.userop.FindAsync(id);
            if (userop == null)
            {
                return NotFound();
            }

            _context.userop.Remove(userop);
            await _context.SaveChangesAsync();

            return userop;
        }

        private bool useropExists(int id)
        {
            return _context.userop.Any(e => e.iuserop == id);
        }
    }
}
