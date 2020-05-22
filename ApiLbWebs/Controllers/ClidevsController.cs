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
    public class ClidevsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ClidevsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Clidevs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<clidev>>> Getclidev()
        {
            return await _context.clidev.ToListAsync();
        }

        // GET: api/Clidevs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<clidev>> Getclidev(int id)
        {
            var clidev = await _context.clidev.FindAsync(id);

            if (clidev == null)
            {
                return NotFound();
            }

            return clidev;
        }

        // PUT: api/Clidevs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putclidev(int id, clidev clidev)
        {
            if (id != clidev.idev)
            {
                return BadRequest();
            }

            _context.Entry(clidev).State = EntityState.Modified;

            try
            {
                clidev.hmod = DateTime.Now.ToString("HH:mm");
                clidev.fmod = DateTime.Now.ToString("dd/M/yyyy");
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!clidevExists(id))
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

        // POST: api/Clidevs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<clidev>> Postclidev(clidev clidev)
        {
            clidev.faltrto = DateTime.Now;
            clidev.hmod = DateTime.Now.ToString("HH:mm");
            clidev.fmod = DateTime.Now.ToString("dd/M/yyyy");
            _context.clidev.Add(clidev);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getclidev", new { id = clidev.idev }, clidev);
        }

        // DELETE: api/Clidevs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<clidev>> Deleteclidev(int id)
        {
            var clidev = await _context.clidev.FindAsync(id);
            if (clidev == null)
            {
                return NotFound();
            }

            _context.clidev.Remove(clidev);
            await _context.SaveChangesAsync();

            return clidev;
        }

        private bool clidevExists(int id)
        {
            return _context.clidev.Any(e => e.idev == id);
        }
    }
}
