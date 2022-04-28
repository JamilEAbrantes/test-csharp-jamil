using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Candidate.Web.API.Migrations
{
    public partial class InitialTableCandidateExperience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: new Guid("305af134-c66a-45b0-a18d-4b9486452fdd"));

            migrationBuilder.CreateTable(
                name: "CandidateExperiences",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Company = table.Column<string>(nullable: true),
                    Job = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Salary = table.Column<decimal>(nullable: false),
                    BeginDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    CandidateId = table.Column<Guid>(nullable: false)
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
                values: new object[] { new Guid("c3364659-9899-4ffa-993b-baca6fccacbd"), new DateTime(1989, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "jamilabrantes@gmail.com", new DateTime(2022, 4, 25, 22, 34, 27, 922, DateTimeKind.Local).AddTicks(2261), null, "Jamil", "Abrantes" });

            migrationBuilder.InsertData(
                table: "CandidateExperiences",
                columns: new[] { "Id", "BeginDate", "CandidateId", "Company", "Description", "EndDate", "InsertDate", "Job", "ModifyDate", "Salary" },
                values: new object[] { new Guid("a55ebf1c-3753-468f-bd55-8f0c62dcc257"), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3364659-9899-4ffa-993b-baca6fccacbd"), "Jamil LTDA", "Desenvolvimento de aplicativos", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 22, 34, 27, 923, DateTimeKind.Local).AddTicks(7458), "Dev .Net SR", null, 9.5m });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateExperiences_CandidateId",
                table: "CandidateExperiences",
                column: "CandidateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateExperiences");

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: new Guid("c3364659-9899-4ffa-993b-baca6fccacbd"));

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "Birthdate", "Email", "InsertDate", "ModifyDate", "Name", "Surname" },
                values: new object[] { new Guid("305af134-c66a-45b0-a18d-4b9486452fdd"), new DateTime(1989, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "jamilabrantes@gmail.com", new DateTime(2022, 4, 25, 18, 58, 11, 813, DateTimeKind.Local).AddTicks(9292), null, "Jamil", "Abrantes" });
        }
    }
}
