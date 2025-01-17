﻿// <auto-generated />
using System;
using Candidate.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Candidate.Web.API.Migrations
{
    [DbContext(typeof(CandidateDBContext))]
    [Migration("20220426020547_Correção_Propriedades")]
    partial class Correção_Propriedades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Candidate.Domain.CandidateAggregate.Candidate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Candidates");

                    b.HasData(
                        new
                        {
                            Id = new Guid("99d30852-9d07-4457-bcf5-13cce9e6ed15"),
                            Birthdate = new DateTime(1989, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jamilabrantes@gmail.com",
                            InsertDate = new DateTime(2022, 4, 25, 23, 5, 47, 460, DateTimeKind.Local).AddTicks(3534),
                            Name = "Jamil",
                            Surname = "Abrantes"
                        });
                });

            modelBuilder.Entity("Candidate.Domain.CandidateExperienceAggregate.CandidateExperience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("CandidateId")
                        .HasColumnType("uniqueidentifier")
                        .HasMaxLength(50);

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000);

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Salary")
                        .HasColumnType("numeric(8, 2)");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.ToTable("CandidateExperiences");

                    b.HasData(
                        new
                        {
                            Id = new Guid("10c0b25e-9db0-4176-ab7e-6b0df4375ba5"),
                            BeginDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CandidateId = new Guid("99d30852-9d07-4457-bcf5-13cce9e6ed15"),
                            Company = "Jamil LTDA",
                            Description = "Desenvolvimento de aplicativos",
                            EndDate = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InsertDate = new DateTime(2022, 4, 25, 23, 5, 47, 461, DateTimeKind.Local).AddTicks(7763),
                            Job = "Dev.Net SR",
                            Salary = 9.5m
                        },
                        new
                        {
                            Id = new Guid("fbea27b2-96ae-4ed6-bc99-8d91f52c4475"),
                            BeginDate = new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CandidateId = new Guid("99d30852-9d07-4457-bcf5-13cce9e6ed15"),
                            Company = "Jamil LTDA 02",
                            Description = "Desenvolvimento de aplicativos 02",
                            EndDate = new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InsertDate = new DateTime(2022, 4, 25, 23, 5, 47, 461, DateTimeKind.Local).AddTicks(8598),
                            Job = "Dev.Net SR 02",
                            Salary = 9.5m
                        });
                });

            modelBuilder.Entity("Candidate.Domain.CandidateExperienceAggregate.CandidateExperience", b =>
                {
                    b.HasOne("Candidate.Domain.CandidateAggregate.Candidate", "Candidate")
                        .WithMany("CandidateExperiences")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
