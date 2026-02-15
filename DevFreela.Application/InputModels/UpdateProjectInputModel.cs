namespace DevFreela.Application.InputModels;

public record UpdateProjectInputModel(int id, string title, string description, decimal totalCost);