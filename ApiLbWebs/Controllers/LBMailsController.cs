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
    public class LBMailsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LBMailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/LBMails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LBMail>>> GetLBMail()
        {
            return await _context.LBMail.ToListAsync();
        }

        // GET: api/LBMails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LBMail>> GetLBMail(int id)
        {
            var lBMail = await _context.LBMail.FindAsync(id);

            if (lBMail == null)
            {
                return NotFound();
            }

            return lBMail;
        }

        // PUT: api/LBMails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLBMail(int id, LBMail lBMail)
        {
            if (id != lBMail.idlbmail)
            {
                return BadRequest();
            }

            _context.Entry(lBMail).State = EntityState.Modified;

            try
            {
                lBMail.hmod = DateTime.Now.ToString("HH:mm");
                lBMail.fmod = DateTime.Now.ToString("dd/M/yyyy");

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LBMailExists(id))
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

        // POST: api/LBMails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LBMail>> PostLBMail(LBMail lBMail)
        {
            lBMail.faltrto = DateTime.Now;
            lBMail.hmod = DateTime.Now.ToString("HH:mm");
            lBMail.fmod = DateTime.Now.ToString("dd/M/yyyy");

            _context.LBMail.Add(lBMail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLBMail", new { id = lBMail.idlbmail }, lBMail);
        }

        // DELETE: api/LBMails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LBMail>> DeleteLBMail(int id)
        {
            var lBMail = await _context.LBMail.FindAsync(id);
            if (lBMail == null)
            {
                return NotFound();
            }

            _context.LBMail.Remove(lBMail);
            await _context.SaveChangesAsync();

            return lBMail;
        }

        private bool LBMailExists(int id)
        {
            return _context.LBMail.Any(e => e.idlbmail == id);
        }
    }
}
