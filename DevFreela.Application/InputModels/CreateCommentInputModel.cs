namespace DevFreela.Application.InputModels;

public record CreateCommentInputModel(string content, int idUser, int idProject);