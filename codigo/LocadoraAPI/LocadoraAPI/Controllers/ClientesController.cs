using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LocadoraAPI.Models;

namespace LocadoraAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly LocadoraContext _context;

        public ClientesController(LocadoraContext context)
        {
            _context = context;
        }

        // GET: Clientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> Index()
        {
            return await _context.Cliente.ToListAsync();
        }

        // GET: Clientes/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var cliente = await _context.Cliente.FirstOrDefaultAsync(m => m.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        // POST: Clientes/Create
        [HttpPost]
        public async Task<ActionResult<Cliente>> Create([FromBody] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                // Remover qualquer referência de reserva do cliente
                cliente.Reserva = null;

                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(Details), new { id = cliente.Id }, cliente);
            }

            return BadRequest(ModelState);
        }

        // PUT: Clientes/Edit/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return BadRequest();
            }

            _context.Entry(cliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteExists(id))
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

        // DELETE: Clientes/Delete/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _context.Cliente.Remove(cliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClienteExists(int id)
        {
            return _context.Cliente.Any(e => e.Id == id);
        }
    }
}
