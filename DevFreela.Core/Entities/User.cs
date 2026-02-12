namespace DevFreela.Core;

public class User : BaseEntity
{
    public string Fullname { get; private set; }
    public string Email { get; private set; }
    public DateTime BirthDate { get; private set; }
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public bool Active { get; set; }
    public List<UserSkill> Skills { get; set; } = new List<UserSkill>();
    public List<Project> OwnedProjects { get; private set; } = new List<Project>();
    public List<Project> FreelanceProjects { get; set; } = new List<Project>();

    public User(string fullname, string email, DateTime birthDate)
    {
        Fullname = fullname;
        Email = email;
        BirthDate = birthDate;
        CreatedAt = DateTime.UtcNow;
        Active = true;
    }
}