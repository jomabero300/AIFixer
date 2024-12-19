using AIFixer.Backend.Data;
using AIFixer.Shared.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AIFixer.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ComponentTypesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ComponentTypesController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        return Ok(await _context.ComponentTypes.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync(int id)
    {
        var componentType = await _context.ComponentTypes.FirstOrDefaultAsync(c => c.Id == id);
        if (componentType == null)
        {
            return NotFound();
        }

        return Ok(componentType);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(ComponentType componentType)
    {
        _context.Add(componentType);
        await _context.SaveChangesAsync();
        return Ok(componentType);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var componentType = await _context.ComponentTypes.FirstOrDefaultAsync(c => c.Id == id);
        if (componentType == null)
        {
            return NotFound();
        }

        _context.Remove(componentType);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpPut]
    public async Task<IActionResult> PutAsync(ComponentType componentType)
    {
        _context.Update(componentType);
        await _context.SaveChangesAsync();
        return Ok(componentType);
    }
}