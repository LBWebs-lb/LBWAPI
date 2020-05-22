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
    public class clilbsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public clilbsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/clilbs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<clilb>>> Getclilb()
        {
            return await _context.clilb.ToListAsync();
        }

        // GET: api/clilbs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<clilb>> Getclilb(int id)
        {
            var clilb = await _context.clilb.FindAsync(id);

            if (clilb == null)
            {
                return NotFound();
            }

            return clilb;
        }

        // PUT: api/clilbs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putclilb(int id, clilb clilb)
        {
            if (id != clilb.icli)
            {
                return BadRequest();
            }

            _context.Entry(clilb).State = EntityState.Modified;

            try
            {

                clilb.hmod = DateTime.Now.ToString("HH:mm");
                clilb.fmod = DateTime.Now.ToString("dd/M/yyyy");
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!clilbExists(id))
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

        // POST: api/clilbs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<clilb>> Postclilb(clilb clilb)
        {

            clilb.faltrto = DateTime.Now;
            clilb.hmod = DateTime.Now.ToString("HH:mm");
            clilb.fmod = DateTime.Now.ToString("dd/M/yyyy");

            _context.clilb.Add(clilb);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getclilb", new { id = clilb.icli }, clilb);
        }

        // DELETE: api/clilbs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<clilb>> Deleteclilb(int id)
        {
            var clilb = await _context.clilb.FindAsync(id);
            if (clilb == null)
            {
                return NotFound();
            }

            _context.clilb.Remove(clilb);
            await _context.SaveChangesAsync();

            return clilb;
        }

        private bool clilbExists(int id)
        {
            return _context.clilb.Any(e => e.icli == id);
        }
    }
}
