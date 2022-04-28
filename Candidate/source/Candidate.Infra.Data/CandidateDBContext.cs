using Candidate.Domain.Core;
using Candidate.Infra.Data.Candidate;
using Candidate.Infra.Data.CandidateExperience;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using CandidateAgg = Candidate.Domain.CandidateAggregate;
using CandidateExperienceAgg = Candidate.Domain.CandidateExperienceAggregate;

namespace Candidate.Infra.Data
{
    public class CandidateDBContext : DbContext
    {
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public CandidateDBContext(DbContextOptions options) : base(options) { }

        public DbSet<CandidateAgg.Candidate> Candidates { get; set; }

        public DbSet<CandidateExperienceAgg.CandidateExperience> CandidateExperiences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var candidate = 
                new CandidateAgg.Candidate("Jamil", 
                                            "Abrantes", 
                                            new System.DateTime(1989, 12, 31), 
                                            "jamilabrantes@gmail.com");

            var candidateExperience01 = 
                new CandidateExperienceAgg.CandidateExperience("Jamil LTDA", 
                                                                "Dev.Net SR", 
                                                                "Desenvolvimento de aplicativos", 
                                                                9.5m, 
                                                                new System.DateTime(2021, 01, 01), 
                                                                new System.DateTime(2022, 02, 02),
                                                                candidate.Id);

            var candidateExperience02 =
                new CandidateExperienceAgg.CandidateExperience("Jamil LTDA 02",
                                                                "Dev.Net SR 02",
                                                                "Desenvolvimento de aplicativos 02",
                                                                10.5m,
                                                                new System.DateTime(2023, 03, 03),
                                                                new System.DateTime(2024, 04, 04),
                                                                candidate.Id);

            modelBuilder.Entity<CandidateAgg.Candidate>().HasData(candidate);

            modelBuilder.Entity<CandidateExperienceAgg.CandidateExperience>().HasData(candidateExperience01);

            modelBuilder.Entity<CandidateExperienceAgg.CandidateExperience>().HasData(candidateExperience02);

            modelBuilder.Ignore<IntegrationEvent>();

            modelBuilder.ApplyConfiguration(new CandidateConfiguration());

            modelBuilder.ApplyConfiguration(new CandidateExperienceConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(loggerFactory)
                .EnableSensitiveDataLogging()
                .UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=CandidateDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}