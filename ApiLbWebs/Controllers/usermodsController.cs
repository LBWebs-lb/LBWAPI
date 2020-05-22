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
    public class usermodsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public usermodsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/usermods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<usermod>>> Getusermod()
        {
            return await _context.usermod.ToListAsync();
        }

        // GET: api/usermods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<usermod>> Getusermod(int id)
        {
            var usermod = await _context.usermod.FindAsync(id);

            if (usermod == null)
            {
                return NotFound();
            }

            return usermod;
        }

        // PUT: api/usermods/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putusermod(int id, usermod usermod)
        {
            if (id != usermod.imod)
            {
                return BadRequest();
            }

            _context.Entry(usermod).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!usermodExists(id))
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

        // POST: api/usermods
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<usermod>> Postusermod(usermod usermod)
        {
            _context.usermod.Add(usermod);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getusermod", new { id = usermod.imod }, usermod);
        }

        // DELETE: api/usermods/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<usermod>> Deleteusermod(int id)
        {
            var usermod = await _context.usermod.FindAsync(id);
            if (usermod == null)
            {
                return NotFound();
            }

            _context.usermod.Remove(usermod);
            await _context.SaveChangesAsync();

            return usermod;
        }

        private bool usermodExists(int id)
        {
            return _context.usermod.Any(e => e.imod == id);
        }
    }
}
