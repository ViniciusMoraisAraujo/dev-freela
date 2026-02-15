namespace DevFreela.Application.InputModels;

public record NewProjectInputModel(string title, string description, int idClient, int idFreelance, decimal totalCost);