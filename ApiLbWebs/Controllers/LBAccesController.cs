using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiLbWebs.Models;
using ApiLbWebs.Classes;

namespace ApiLbWebs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LBAccesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LBAccesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/LBAcces
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LBAcces>>> GetLBAcces()
        {            
            return await _context.LBAcces.ToListAsync();
        }

        // GET: api/LBAcces/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LBAcces>> GetLBAcces(int id)
        {
            var lBAcces = await _context.LBAcces.FindAsync(id);

            if (lBAcces == null)
            {
                return NotFound();
            }

            return lBAcces;
        }

        // PUT: api/LBAcces/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLBAcces(int id, LBAcces lBAcces)
        {
            if (id != lBAcces.idlb)
            {
                return BadRequest();
            }

            _context.Entry(lBAcces).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LBAccesExists(id))
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

        // POST: api/LBAcces
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LBAcces>> PostLBAcces(LBAcces lBAcces)
        {
            //byte[] data = System.Text.Encoding.ASCII.GetBytes(lBAcces.passWd);
            //data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            //String hash = System.Text.Encoding.ASCII.GetString(data);
            //lBAcces.passWd = hash;

            lBAcces.passWd = Encriptacion.Encrypt(lBAcces.passWd, true);

            _context.LBAcces.Add(lBAcces);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLBAcces", new { id = lBAcces.idlb }, lBAcces);
        }

        // DELETE: api/LBAcces/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LBAcces>> DeleteLBAcces(int id)
        {
            var lBAcces = await _context.LBAcces.FindAsync(id);
            if (lBAcces == null)
            {
                return NotFound();
            }

            _context.LBAcces.Remove(lBAcces);
            await _context.SaveChangesAsync();

            return lBAcces;
        }

        private bool LBAccesExists(int id)
        {
            return _context.LBAcces.Any(e => e.idlb == id);
        }

        [HttpGet]
        [Route("getpass/{param1}")] //   /api/example/get1/1?param2=4
        public ActionResult<LBAcces> Get(string param1)
        {
            Object example = Encriptacion.Decrypt(param1, true);
            return Ok(example);
        }


    }
}
