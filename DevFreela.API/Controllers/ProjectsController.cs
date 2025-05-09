﻿using DevFreela.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers;

[Route("api/projects")]
[ApiController]
public class ProjectsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok("Get all projects");
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok($"Get project with id {id}");
    }
    [HttpPost]
    public IActionResult Post(CreateProjectInputModel model)
    {
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
        return CreatedAtAction(nameof(GetById), new { id = 1 }, comment);
    }
}
