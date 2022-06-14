using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiDuramasApp.Data;
using apiDuramasApp.Models;

namespace apiDuramasApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToolsController : ControllerBase
    {
        private readonly Contexto _context;

        public ToolsController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Tools
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tools>>> GetTools()
        {
            return await _context.Tools.ToListAsync();
        }

        // DELETE: api/Tools/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTools(int id)
        {
            var tools = await _context.Tools.FindAsync(id);
            if (tools == null)
            {
                return NotFound();
            }

            _context.Tools.Remove(tools);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Tools
        [HttpPost]
        public async Task<ActionResult<Tools>> PostClientes(Tools tool)
        {
            if (tool.ToolsId > 0)
            {
                if (ToolsExists(tool.ToolsId))
                {
                    _context.Entry(tool).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    return Ok();
                }
                else
                {
                    _context.Tools.Add(tool);
                    await _context.SaveChangesAsync();
                    return CreatedAtAction("GetTools", new { id = tool.ToolsId }, tool);
                }
            }
            else
                return CreatedAtAction("PostAsync", tool);
        }

        private bool ToolsExists(int id)
        {
            return _context.Tools.Any(e => e.ToolsId == id);
        }
    }
}
