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
    public class cliftpsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public cliftpsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/cliftps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<cliftp>>> Getcliftp()
        {
            return await _context.cliftp.ToListAsync();
        }

        // GET: api/cliftps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<cliftp>> Getcliftp(int id)
        {
            var cliftp = await _context.cliftp.FindAsync(id);

            if (cliftp == null)
            {
                return NotFound();
            }

            return cliftp;
        }

        // PUT: api/cliftps/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putcliftp(int id, cliftp cliftp)
        {
            if (id != cliftp.iftp)
            {
                return BadRequest();
            }

            _context.Entry(cliftp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!cliftpExists(id))
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

        // POST: api/cliftps
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<cliftp>> Postcliftp(cliftp cliftp)
        {
            _context.cliftp.Add(cliftp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getcliftp", new { id = cliftp.iftp }, cliftp);
        }

        // DELETE: api/cliftps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<cliftp>> Deletecliftp(int id)
        {
            var cliftp = await _context.cliftp.FindAsync(id);
            if (cliftp == null)
            {
                return NotFound();
            }

            _context.cliftp.Remove(cliftp);
            await _context.SaveChangesAsync();

            return cliftp;
        }

        private bool cliftpExists(int id)
        {
            return _context.cliftp.Any(e => e.iftp == id);
        }
    }
}
