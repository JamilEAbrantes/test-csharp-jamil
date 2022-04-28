using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CandidateExperienceAgg = Candidate.Domain.CandidateExperienceAggregate;

namespace Candidate.Infra.Data.CandidateExperience
{
    public class CandidateExperienceConfiguration : IEntityTypeConfiguration<CandidateExperienceAgg.CandidateExperience>
    {
        public void Configure(EntityTypeBuilder<CandidateExperienceAgg.CandidateExperience> builder)
        {
            builder.ToTable("CandidateExperiences");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Company).HasMaxLength(100).IsRequired();
            builder.Property(t => t.Job).HasMaxLength(100).IsRequired();
            builder.Property(t => t.Description).HasMaxLength(4000).IsRequired();
            builder.Property(t => t.Salary).HasColumnType("numeric(8, 2)").IsRequired();
            builder.Property(t => t.BeginDate).HasColumnType("datetime").IsRequired();
            builder.Property(t => t.EndDate).HasColumnType("datetime").IsRequired(false);
            builder.Property(t => t.InsertDate).HasColumnType("datetime").IsRequired();
            builder.Property(t => t.ModifyDate).HasColumnType("datetime").IsRequired(false);
            builder.Property(t => t.CandidateId).HasMaxLength(50).IsRequired();
        }
    }
}