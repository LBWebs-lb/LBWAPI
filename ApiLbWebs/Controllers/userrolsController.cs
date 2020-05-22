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
    public class userrolsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public userrolsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/userrols
        [HttpGet]
        public async Task<ActionResult<IEnumerable<userrol>>> Getuserrol()
        {
            return await _context.userrol.ToListAsync();
        }

        // GET: api/userrols/5
        [HttpGet("{id}")]
        public async Task<ActionResult<userrol>> Getuserrol(int id)
        {
            var userrol = await _context.userrol.FindAsync(id);

            if (userrol == null)
            {
                return NotFound();
            }

            return userrol;
        }

        // PUT: api/userrols/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putuserrol(int id, userrol userrol)
        {
            if (id != userrol.irol)
            {
                return BadRequest();
            }

            _context.Entry(userrol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!userrolExists(id))
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

        // POST: api/userrols
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<userrol>> Postuserrol(userrol userrol)
        {
            _context.userrol.Add(userrol);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getuserrol", new { id = userrol.irol }, userrol);
        }

        // DELETE: api/userrols/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<userrol>> Deleteuserrol(int id)
        {
            var userrol = await _context.userrol.FindAsync(id);
            if (userrol == null)
            {
                return NotFound();
            }

            _context.userrol.Remove(userrol);
            await _context.SaveChangesAsync();

            return userrol;
        }

        private bool userrolExists(int id)
        {
            return _context.userrol.Any(e => e.irol == id);
        }
    }
}
