using DevFreela.API.Model;
using DevFreela.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers;

[Route("api/projects")]
[ApiController]
public class ProjectsController(IOptions<FreelanceTotalCostConfig> options,
                                IConfigService configService) : ControllerBase
{
    private readonly FreelanceTotalCostConfig _config = options.Value;
    private readonly IConfigService _configService = configService;

    [HttpGet]
    public IActionResult Get(string seach ="")
    {
        return Ok(_configService.GetValue());
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok($"Get project with id {id}");
    }
    [HttpPost]
    public IActionResult Post(CreateProjectInputModel model)
    {
        if (model.TotalCost < _config.Minimum || model.TotalCost > _config.Maximum)
        {
            return BadRequest("Total cost is out of range");
        }
        return CreatedAtAction(nameof(GetById), new { id = 1 }, model);
    }
    [HttpPut("{id}")]
    public IActionResult Put(int id, UpdateProjectInputModel model)
    {
        return NoContent();
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return NoContent();
    }
    [HttpPut("{id}/start")]
    public IActionResult Start(int id)
    {
        return NoContent();
    }
    [HttpPut("{id}/compleate")]
    public IActionResult Compleate(int id)
    {
        return NoContent();
    }
    [HttpPost("{id}/comment")]
    public IActionResult PostComment(int id, CreateProjectCommentInputModel model)
    {
        return CreatedAtAction(nameof(GetById), new { id = 1 }, null);
    }
}
