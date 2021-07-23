using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testcsharpAPI.Models.DBContext;
using testcsharpAPI.models;

namespace testcsharpAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistanDatensController : ControllerBase
    {
        private readonly AppDBContext _context;

        public DistanDatensController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/DistanDatens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DistanDaten>>> GetDistanz()
        {
            return await _context.Distanz.ToListAsync();
        }

        // GET: api/DistanDatens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DistanDaten>> GetDistanDaten(int id)
        {
            var distanDaten = await _context.Distanz.FindAsync(id);

            if (distanDaten == null)
            {
                return NotFound();
            }

            return distanDaten;
        }

        // PUT: api/DistanDatens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDistanDaten(int id, DistanDaten distanDaten)
        {
            if (id != distanDaten.Id)
            {
                return BadRequest();
            }

            _context.Entry(distanDaten).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DistanDatenExists(id))
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

        // POST: api/DistanDatens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DistanDaten>> PostDistanDaten(DistanDaten distanDaten)
        {
            _context.Distanz.Add(distanDaten);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDistanDaten", new { id = distanDaten.Id }, distanDaten);
        }

        // DELETE: api/DistanDatens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDistanDaten(int id)
        {
            var distanDaten = await _context.Distanz.FindAsync(id);
            if (distanDaten == null)
            {
                return NotFound();
            }

            _context.Distanz.Remove(distanDaten);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DistanDatenExists(int id)
        {
            return _context.Distanz.Any(e => e.Id == id);
        }
    }
}
