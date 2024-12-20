using DevFreela.Core.Entities;

namespace DevFreela.Infra.Persistence;

public class DevFreelaDbContext
{
    public DevFreelaDbContext()
    {
        Projects =
        [
            new("Projeto ASPNET Core 1", "Description 1", 1, 1, 10000),
            new("Projeto ASPNET Core 2", "Description 2", 1, 1, 20000),
            new("Projeto ASPNET Core 3", "Description 3", 1, 1, 30000),
        ];

        Users =
        [
            new("Usuario 1", "usario1@teste.com", DateTime.Now)
        ];

        Skills =
        [
            new(".NET Core"),
            new("C#"),
            new("SQL")
        ];
    }
    public List<Project> Projects { get; set; }
    public List<User> Users { get; set; }
    public List<Skill> Skills { get; set; }
    public List<ProjectComment> ProjectComments { get; set; }
}
