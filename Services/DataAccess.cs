using VictorBack.Models;

namespace VictorBack.Services
{
    public class DataAccess : IData
    {
        /// <summary>
        /// Not using a DB for this shit, sorry.
        /// </summary>
        public Experience GetExperience()
        {
            return new Experience
            {
                Jobs = new List<Job>
                {
                    new Job
                    {
                        Id = new Guid(),
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
                    },
                    new Job
                    {
                        Id = new Guid(),
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
                    new Job
                    {
                        Id = new Guid(),
                        Company = new Company{
                            Id = new Guid(),
                            City = "Alcacer",
                            Country = "Spain",
                            Name = "TMEIC Port Technologies | Órbita"
                        },
                        From = new DateTime(2021,11,15),
                        To = DateTime.Now,
                        Name = "Product Engineer"
                    }
                },
                Technologies = new List<Technology>
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
    
}