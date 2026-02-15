using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core;
using DevFreela.Infrastructure.Persistence;

namespace DevFreela.Application.Services.Implementations;

public class ProjectService : IProjectService
{

    private readonly DevFreelaDbContext _dbContext;
    public ProjectService(DevFreelaDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public List<ProjectViewModel> GetAll(string query)
    {
        var projects = _dbContext.Projects;
        var projectViewModels = projects
            .Select(project => new ProjectViewModel(project.Title, project.CreatedAt))
            .ToList();
        
        return projectViewModels;
    }

    public ProjectDetailsViewModel GetById(int id)
    {
        var project = _dbContext.Projects.FirstOrDefault(p => p.Id == id);
        var projectDetailsViewModel = new ProjectDetailsViewModel(
            project.Id,
            project.Title,
            project.Description,
            project.TotalCost,
            project.StartedAt,
            project.FinishedAt
        );
        
        return projectDetailsViewModel;
    }

    public int Create(NewProjectInputModel projectInputModel)
    {
        var project = new Project(
            projectInputModel.title,
            projectInputModel.description,
            projectInputModel.idClient,
            projectInputModel.idFreelance,
            projectInputModel.totalCost);
        
        _dbContext.Projects.Add(project);
        return project.Id;
    }

    public void Update(UpdateProjectInputModel updateProjectInputModel)
    {
        var project = _dbContext.Projects.FirstOrDefault(p => p.Id == updateProjectInputModel.id);
        project.Update(updateProjectInputModel.title, updateProjectInputModel.description, updateProjectInputModel.totalCost);
        
    }   

    public void Delete(int id)
    {
        var project = _dbContext.Projects.FirstOrDefault(p => p.Id == id);
        project.Cancel();
    }

    public void Start(int id)
    {
        var project = _dbContext.Projects.FirstOrDefault(p => p.Id == id);
        project.Start();
    }

    public void Finish(int id)
    {
        var project = _dbContext.Projects.FirstOrDefault(p => p.Id == id);
        project.Finish();
    }

    public void CreateComment(CreateCommentInputModel createCommentInputModel)
    {
        var comment = new ProjectComment(createCommentInputModel.content, createCommentInputModel.idUser, createCommentInputModel.idProject);
        _dbContext.ProjectComments.Add(comment);
    }
}