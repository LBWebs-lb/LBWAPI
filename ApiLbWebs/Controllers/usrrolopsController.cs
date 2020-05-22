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
    public class usrrolopsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public usrrolopsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/usrrolops
        [HttpGet]
        public async Task<ActionResult<IEnumerable<usrrolop>>> Getusrrolop()
        {
            return await _context.usrrolop.ToListAsync();
        }

        // GET: api/usrrolops/5
        [HttpGet("{id}")]
        public async Task<ActionResult<usrrolop>> Getusrrolop(int id)
        {
            var usrrolop = await _context.usrrolop.FindAsync(id);

            if (usrrolop == null)
            {
                return NotFound();
            }

            return usrrolop;
        }

        // PUT: api/usrrolops/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putusrrolop(int id, usrrolop usrrolop)
        {
            if (id != usrrolop.iusrrolop)
            {
                return BadRequest();
            }

            _context.Entry(usrrolop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!usrrolopExists(id))
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

        // POST: api/usrrolops
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<usrrolop>> Postusrrolop(usrrolop usrrolop)
        {
            _context.usrrolop.Add(usrrolop);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getusrrolop", new { id = usrrolop.iusrrolop }, usrrolop);
        }

        // DELETE: api/usrrolops/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<usrrolop>> Deleteusrrolop(int id)
        {
            var usrrolop = await _context.usrrolop.FindAsync(id);
            if (usrrolop == null)
            {
                return NotFound();
            }

            _context.usrrolop.Remove(usrrolop);
            await _context.SaveChangesAsync();

            return usrrolop;
        }

        private bool usrrolopExists(int id)
        {
            return _context.usrrolop.Any(e => e.iusrrolop == id);
        }
    }
}
