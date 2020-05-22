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
    public class userslbsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public userslbsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/userslbs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<userslb>>> Getuserslb()
        {
            return await _context.userslb.ToListAsync();
        }

        // GET: api/userslbs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<userslb>> Getuserslb(int id)
        {
            var userslb = await _context.userslb.FindAsync(id);

            if (userslb == null)
            {
                return NotFound();
            }

            return userslb;
        }

        // PUT: api/userslbs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putuserslb(int id, userslb userslb)
        {
            if (id != userslb.iduser)
            {
                return BadRequest();
            }

            _context.Entry(userslb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!userslbExists(id))
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

        // POST: api/userslbs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<userslb>> Postuserslb(userslb userslb)
        {
            _context.userslb.Add(userslb);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getuserslb", new { id = userslb.iduser }, userslb);
        }

        // DELETE: api/userslbs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<userslb>> Deleteuserslb(int id)
        {
            var userslb = await _context.userslb.FindAsync(id);
            if (userslb == null)
            {
                return NotFound();
            }

            _context.userslb.Remove(userslb);
            await _context.SaveChangesAsync();

            return userslb;
        }

        private bool userslbExists(int id)
        {
            return _context.userslb.Any(e => e.iduser == id);
        }
    }
}
