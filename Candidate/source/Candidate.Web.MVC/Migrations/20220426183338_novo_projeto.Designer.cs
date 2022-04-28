﻿// <auto-generated />
using System;
using Candidate.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Candidate.Web.MVC.Migrations
{
    [DbContext(typeof(CandidateDBContext))]
    [Migration("20220426183338_novo_projeto")]
    partial class novo_projeto
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
                        .HasColumnType("datetime");

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
                            Id = new Guid("90aacaca-8f44-49b7-afc5-3ba374945f2f"),
                            Birthdate = new DateTime(1989, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jamilabrantes@gmail.com",
                            InsertDate = new DateTime(2022, 4, 26, 15, 33, 38, 377, DateTimeKind.Local).AddTicks(8217),
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
                            Id = new Guid("293bc642-a5ae-4951-ab3a-81a6f882d746"),
                            BeginDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CandidateId = new Guid("90aacaca-8f44-49b7-afc5-3ba374945f2f"),
                            Company = "Jamil LTDA",
                            Description = "Desenvolvimento de aplicativos",
                            EndDate = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InsertDate = new DateTime(2022, 4, 26, 15, 33, 38, 379, DateTimeKind.Local).AddTicks(1828),
                            Job = "Dev.Net SR",
                            Salary = 9.5m
                        },
                        new
                        {
                            Id = new Guid("bfb0c95e-65f6-47e7-b3a8-55201a8b5fd5"),
                            BeginDate = new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CandidateId = new Guid("90aacaca-8f44-49b7-afc5-3ba374945f2f"),
                            Company = "Jamil LTDA 02",
                            Description = "Desenvolvimento de aplicativos 02",
                            EndDate = new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InsertDate = new DateTime(2022, 4, 26, 15, 33, 38, 379, DateTimeKind.Local).AddTicks(2677),
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
