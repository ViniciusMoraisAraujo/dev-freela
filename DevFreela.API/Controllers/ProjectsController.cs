using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Core;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers;

public class ProjectsController(IProjectService projectService) : ControllerBase
{
    private readonly IProjectService _projectService = projectService;

    [HttpGet]
    public IActionResult Get(string query)
    {
        var project = _projectService.GetAll(query);
        return Ok(project);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var project = _projectService.GetById(id);

        return project == null ? NotFound() : Ok(project);
    }

    [HttpPost]
    public IActionResult Post([FromBody] CreateProjectInputModel createProjectModel)
    {
        var id = _projectService.Create(createProjectModel);

        return CreatedAtAction(nameof(GetById), new { Id = id  }, createProjectModel);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] UpdateProjectInputModel updateProjectModel)
    { 
        var project = _projectService.Update(updateProjectModel);

        if (!project)
            return NotFound(); 
        
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var project = _projectService.Delete(id);
        if(!project) NotFound();
        
        return NoContent();
    }

    [HttpPost("{id}/comments")]
    public IActionResult PostComment(int id, [FromBody] CreateCommentInputModel comment)
    {
        _projectService.CreateComment(comment);
        
        return CreatedAtAction(nameof(GetById), new { Id = id });
    }

    [HttpPut("{id}/start")]
    public IActionResult Start(int id)
    {
        var project = _projectService.Start(id);
        if (!project) return NotFound();
        
        return NoContent();
    }

    [HttpPut("{id}/finish")]
    public IActionResult Finish(int id)
    {
        var project = _projectService.Finish(id);
        if (!project) return NotFound();
        
        return NoContent();
    }
}