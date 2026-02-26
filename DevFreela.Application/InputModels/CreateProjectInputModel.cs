namespace DevFreela.Application.InputModels;

public record CreateProjectInputModel(string title, string description, int idClient, int idFreelance, decimal totalCost);