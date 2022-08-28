using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LMS.Web.Data;
using LMS.Web.Models;

namespace LMS.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountvaluesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CountvaluesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Countvalues
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Countvalue>>> GetCountvalues()
        {
            return await _context.Countvalues.ToListAsync();
        }

        // GET: api/Countvalues/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Countvalue>> GetCountvalue(int id)
        {
            var countvalue = await _context.Countvalues.FindAsync(id);

            if (countvalue == null)
            {
                return NotFound();
            }

            return countvalue;
        }

        // PUT: api/Countvalues/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountvalue(int id, Countvalue countvalue)
        {
            if (id != countvalue.Count)
            {
                return BadRequest();
            }

            _context.Entry(countvalue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountvalueExists(id))
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

        // POST: api/Countvalues
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Countvalue>> PostCountvalue(Countvalue countvalue)
        {
            _context.Countvalues.Add(countvalue);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCountvalue", new { id = countvalue.Count }, countvalue);
        }

        // DELETE: api/Countvalues/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Countvalue>> DeleteCountvalue(int id)
        {
            var countvalue = await _context.Countvalues.FindAsync(id);
            if (countvalue == null)
            {
                return NotFound();
            }

            _context.Countvalues.Remove(countvalue);
            await _context.SaveChangesAsync();

            return countvalue;
        }

        private bool CountvalueExists(int id)
        {
            return _context.Countvalues.Any(e => e.Count == id);
        }
    }
}
