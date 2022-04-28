using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Candidate.Web.MVC.Migrations
{
    public partial class correçãonovoprojetomvc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Surname = table.Column<string>(maxLength: 150, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Email = table.Column<string>(maxLength: 250, nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateExperiences",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Company = table.Column<string>(maxLength: 100, nullable: false),
                    Job = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 4000, nullable: false),
                    Salary = table.Column<decimal>(type: "numeric(8, 2)", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CandidateId = table.Column<Guid>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateExperiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CandidateExperiences_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "Birthdate", "Email", "InsertDate", "ModifyDate", "Name", "Surname" },
                values: new object[] { new Guid("545ad1ec-2d34-432d-861b-90f260e25688"), new DateTime(1989, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "jamilabrantes@gmail.com", new DateTime(2022, 4, 26, 15, 27, 5, 372, DateTimeKind.Local).AddTicks(4021), null, "Jamil", "Abrantes" });

            migrationBuilder.InsertData(
                table: "CandidateExperiences",
                columns: new[] { "Id", "BeginDate", "CandidateId", "Company", "Description", "EndDate", "InsertDate", "Job", "ModifyDate", "Salary" },
                values: new object[] { new Guid("0422023a-10d6-457f-987b-7daafec1b80b"), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("545ad1ec-2d34-432d-861b-90f260e25688"), "Jamil LTDA", "Desenvolvimento de aplicativos", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 26, 15, 27, 5, 373, DateTimeKind.Local).AddTicks(8292), "Dev.Net SR", null, 9.5m });

            migrationBuilder.InsertData(
                table: "CandidateExperiences",
                columns: new[] { "Id", "BeginDate", "CandidateId", "Company", "Description", "EndDate", "InsertDate", "Job", "ModifyDate", "Salary" },
                values: new object[] { new Guid("b056dfe5-fd6f-42ef-930c-f83cd771dfa8"), new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("545ad1ec-2d34-432d-861b-90f260e25688"), "Jamil LTDA 02", "Desenvolvimento de aplicativos 02", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 26, 15, 27, 5, 373, DateTimeKind.Local).AddTicks(9235), "Dev.Net SR 02", null, 9.5m });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateExperiences_CandidateId",
                table: "CandidateExperiences",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_Email",
                table: "Candidates",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateExperiences");

            migrationBuilder.DropTable(
                name: "Candidates");
        }
    }
}
