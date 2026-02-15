using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;

namespace DevFreela.Application.Services.Implementations;

public class SkillService : ISkillService
{
    private readonly DevFreelaDbContext _dbContext;

    public SkillService()
    {
        _dbContext = new DevFreelaDbContext();
    }
    
    public List<SkillViewModel> GetAllSkills()
    {
        var skills = _dbContext.Skills;
        var skillViewModel = skills
            .Select(s => new SkillViewModel(s.Id, s.Description)).ToList();

        return skillViewModel;
    }
}