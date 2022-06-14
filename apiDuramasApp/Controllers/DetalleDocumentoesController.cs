using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiDuramasApp.Data;
using apiDuramasApp.Models;

namespace apiDuramasApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleDocumentoesController : ControllerBase
    {
        private readonly Contexto _context;

        public DetalleDocumentoesController(Contexto context)
        {
            _context = context;
        }

        // GET: api/DetalleDocumentoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleDocumento>>> GetdetalleDocumentos()
        {
            return await _context.detalleDocumentos.ToListAsync();
        }

        // GET: api/DetalleDocumentoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleDocumento>> GetDetalleDocumento(int id)
        {
            var detalleDocumento = await _context.detalleDocumentos.FindAsync(id);

            if (detalleDocumento == null)
            {
                return NotFound();
            }

            return detalleDocumento;
        }

        // PUT: api/DetalleDocumentoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalleDocumento(int id, DetalleDocumento detalleDocumento)
        {
            if (id != detalleDocumento.DetalleDocumentoId)
            {
                return BadRequest();
            }

            _context.Entry(detalleDocumento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalleDocumentoExists(id))
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

        // POST: api/DetalleDocumentoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DetalleDocumento>> PostDetalleDocumento(DetalleDocumento detalleDocumento)
        {
            _context.detalleDocumentos.Add(detalleDocumento);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DetalleDocumentoExists(detalleDocumento.DetalleDocumentoId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDetalleDocumento", new { id = detalleDocumento.DetalleDocumentoId }, detalleDocumento);
        }

        // DELETE: api/DetalleDocumentoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalleDocumento(int id)
        {
            var detalleDocumento = await _context.detalleDocumentos.FindAsync(id);
            if (detalleDocumento == null)
            {
                return NotFound();
            }

            _context.detalleDocumentos.Remove(detalleDocumento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetalleDocumentoExists(int id)
        {
            return _context.detalleDocumentos.Any(e => e.DetalleDocumentoId == id);
        }
    }
}
