using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Services.Interfaces;

public interface IProjectService
{
    List<ProjectViewModel> GetAll(string query);
    ProjectDetailsViewModel GetById(int id);
    int Create(CreateProjectInputModel projectInputModel);
    bool Update(UpdateProjectInputModel  updateProjectInputModel);
    bool Delete(int id);
    void Start(int id);
    void Finish(int id);
    void CreateComment(CreateCommentInputModel createCommentInputModel);
    
}