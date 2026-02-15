namespace DevFreela.Application.ViewModels;

public record ProjectDetailsViewModel(int id, string title, string description, decimal totalCost, DateTime? startedAt, DateTime? finishedAt);