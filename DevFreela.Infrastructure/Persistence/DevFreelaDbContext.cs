using DevFreela.Core;

namespace DevFreela.Infrastructure.Persistence;

public class DevFreelaDbContext
{
    public List<Project> Projects { get; set; }
    public List<User> Users { get; set; }
    public List<Skill> Skills { get; set; }
    public List<ProjectComment> ProjectComments { get; set; }

    public DevFreelaDbContext()
    {
        Projects = new List<Project>()
        {
            new Project("Projeto 1", "Projeto 1", 1, 1, 1000),
            new Project("Projeto 2", "Projeto 2", 2, 3, 1000),
            new Project("Projeto 3", "Projeto 3", 2, 3, 1000)
        };
        Users = new List<User>()
        {
            new User("user 1", "user 1", new DateTime(1992, 1, 1)),
            new User("user 2", "user 2", new DateTime(1992, 1, 1)),
            new User("user 3", "user 3", new DateTime(1992, 1, 1))
        };

        Skills = new List<Skill>()
        {
            new Skill("Skill 1"),
            new Skill("Skill 2"),
            new Skill("Skill 3")
        };
        
    }
}