using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocadoraAPI.Models;

namespace LocadoraAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservasController : ControllerBase
    {
        private readonly LocadoraContext _context;

        public ReservasController(LocadoraContext context)
        {
            _context = context;
        }

        // GET: Reservas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reserva>>> Index()
        {
            return await _context.Reserva.ToListAsync();
        }

        // GET: Reservas/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reserva>> Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var reserva = await _context.Reserva.FirstOrDefaultAsync(m => m.Id == id);

            if (reserva == null)
            {
                return NotFound();
            }

            return reserva;
        }

        // POST: Reservas/Create
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reserva);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(Details), new { id = reserva.Id }, reserva);
            }
            return BadRequest(ModelState);
        }

        // PUT: Reservas/Edit/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] Reserva reserva)
        {
            if (id != reserva.Id)
            {
                return BadRequest();
            }

            _context.Entry(reserva).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservaExists(id))
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

        // DELETE: Reservas/Delete/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var reserva = await _context.Reserva.FindAsync(id);
            if (reserva == null)
            {
                return NotFound();
            }

            _context.Reserva.Remove(reserva);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReservaExists(int id)
        {
            return _context.Reserva.Any(e => e.Id == id);
        }
    }
}
