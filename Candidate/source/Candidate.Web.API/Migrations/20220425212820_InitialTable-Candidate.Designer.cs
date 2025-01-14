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
    [Migration("20220425212820_InitialTable-Candidate")]
    partial class InitialTableCandidate
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Candidates");

                    b.HasData(
                        new
                        {
                            Id = new Guid("867a4b2e-79e2-491b-9832-8e57987dc84e"),
                            Birthdate = new DateTime(1989, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jamilabrantes@gmail.com",
                            InsertDate = new DateTime(2022, 4, 25, 18, 28, 20, 622, DateTimeKind.Local).AddTicks(1880),
                            Name = "Jamil",
                            Surname = "Abrantes"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
