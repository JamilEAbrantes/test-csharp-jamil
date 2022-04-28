using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using CandidateAgg = Candidate.Domain.CandidateAggregate;

namespace Candidate.Infra.Data.Candidate
{
    public class CandidateConfiguration : IEntityTypeConfiguration<CandidateAgg.Candidate>
    {
        public void Configure(EntityTypeBuilder<CandidateAgg.Candidate> builder)
        {
            builder.ToTable("Candidates");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Surname).HasMaxLength(150).IsRequired();
            builder.Property(t => t.Birthdate).HasColumnType("datetime").IsRequired();
            builder.Property(t => t.Email).HasMaxLength(250).IsRequired();
            builder.HasIndex(t => t.Email).IsUnique();
            builder.Property(t => t.InsertDate).HasColumnType("datetime").IsRequired();
            builder.Property(t => t.ModifyDate).HasColumnType("datetime").IsRequired(false);
            builder.HasMany(t => t.CandidateExperiences).WithOne(t => t.Candidate).HasForeignKey(t => t.CandidateId);
        }
    }
}