using System.Net.Mail;
using VictorBack.DTOs;
using VictorBack.Models;

namespace VictorBack.Services;

/// <summary>
/// Not using a DB for this shit, sorry.
/// </summary>
public class DataAccess : IData
{
    //<inheritdoc cref="IData.GetAboutMe"/>
    public UserDTO GetAboutMe()
    {
        return new UserDTO{
            Presentation = "Hi! First of all sorry for this awful website. If you want to know more about me, feel free to contact me.",
            Birthday = new DateTime(1991,1,13),
            Email = new MailAddress("victorcm34@gmail.com", "Víctor Méndez"),
            Name = "Víctor Chen Méndez",
            Interests = new List<string>{
                "Sports",
                "Technologies",
                "Gaming"
            },
            SocialMedia = new Dictionary<string, string>{
                {"LinkedIn", " https://www.linkedin.com/in/victormendez-0225b151"},
                {"GitHub", "https://github.com/victorcm34"}
            }
        };
    }

    //<inheritdoc cref="IData.GetExperience"/>
    public ExperienceDTO GetExperience()
    {
        return new ExperienceDTO
        {
            Jobs = new List<JobDTO>
            {
                new JobDTO
                {
                    Company = new Company{
                        Id = new Guid(),
                        City = "Alcacer",
                        Country = "Spain",
                        Name = "TMEIC Port Technologies | Órbita"
                    },
                    From = new DateTime(2021,11,15),
                    To = DateTime.Now,
                    Name = "Product Engineer"
                },
                new JobDTO
                {
                    Company = new Company{
                        Id = new Guid(),
                        City = "Valencia",
                        Country = "Spain",
                        Name = "Universidad Católica de Valencia"
                    },
                    From = new DateTime(2020,9,1),
                    To = new DateTime(2021,11,13),
                    Name = "Software developer"
                },
                new JobDTO
                {
                    Company = new Company
                    {
                        Id = new Guid(),
                        City = "Valencia",
                        Country = "Spain",
                        Name = "Universidad Católica de Valencia"
                    },
                    From = new DateTime(2018,11,5),
                    To = new DateTime(2020,8,31),
                    Name = "IT support"
                }
            },
            Technologies = new List<TechnologyDTO>
            {
                new Technology
                {
                    Id = new Guid(),
                    Name = ".NetCore",
                    Level = "Expert"
                },
                new Technology
                {
                    Id = new Guid(),
                    Name = "EntityFramework",
                    Level = "Advanced"
                },
                new Technology
                {
                    Id = new Guid(),
                    Name = "Git",
                    Level = "Advanced"
                },
                new Technology
                {
                    Id = new Guid(),
                    Name = "MSSQL",
                    Level = "Advanced"
                },
                new Technology
                {
                    Id = new Guid(),
                    Name = "Jira",
                    Level = "Advanced"
                },
                new Technology
                {
                    Id = new Guid(),
                    Name = "BitBucket",
                    Level = "Advanced"
                }
            }
        };
    }
}
    
