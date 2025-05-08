using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers;

[Route("api/skills")]
[ApiController]
public class SkillsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok("Get all skills");
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok($"Get skill with id {id}");
    }
    [HttpPost]
    public IActionResult Post()
    {
        return CreatedAtAction(nameof(GetById), new { id = 1 }, null);
    }
    [HttpPut("{id}")]
    public IActionResult Put(int id)
    {
        return NoContent();
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return NoContent();
    }
}
