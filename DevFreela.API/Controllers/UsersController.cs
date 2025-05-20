using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok("Get all users");
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok($"Get user with id {id}");
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

    [HttpPut("{id}/profile-picture")]
    public IActionResult PostProfilePicture(IFormFile file)
    {
        var description = $"File:{file.FileName}, Size: {file.Length}";
        //process the file here

        return Ok(description);
    }
}
