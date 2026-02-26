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
            .Select(project => new ProjectViewModel(project.Id ,project.Title, project.CreatedAt))
            .ToList();
        
        return projectViewModels;
    }

    public ProjectDetailsViewModel GetById(int id)
    {
        var project = _dbContext.Projects.FirstOrDefault(p => p.Id == id);
        
        if(project == null)
            return null;
        
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

    public int Create(CreateProjectInputModel projectInputModel)
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

    public bool Update(UpdateProjectInputModel updateProjectInputModel)
    {
        var project = _dbContext.Projects.FirstOrDefault(p => p.Id == updateProjectInputModel.id);
        if(project == null)
            return false;
        
        project.Update(updateProjectInputModel.title, updateProjectInputModel.description, updateProjectInputModel.totalCost);
        return true;
    }   

    public bool Delete(int id)
    {
        var project = _dbContext.Projects.FirstOrDefault(p => p.Id == id);
        if (project == null)  return false;
        
        project.Cancel();
        return true;
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