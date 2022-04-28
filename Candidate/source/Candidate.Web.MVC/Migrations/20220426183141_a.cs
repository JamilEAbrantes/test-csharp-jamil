using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Candidate.Web.MVC.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CandidateExperiences",
                keyColumn: "Id",
                keyValue: new Guid("0422023a-10d6-457f-987b-7daafec1b80b"));

            migrationBuilder.DeleteData(
                table: "CandidateExperiences",
                keyColumn: "Id",
                keyValue: new Guid("b056dfe5-fd6f-42ef-930c-f83cd771dfa8"));

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: new Guid("545ad1ec-2d34-432d-861b-90f260e25688"));

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "Birthdate", "Email", "InsertDate", "ModifyDate", "Name", "Surname" },
                values: new object[] { new Guid("e4040850-384b-4c08-a117-a5bacb54d6e8"), new DateTime(1989, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "jamilabrantes@gmail.com", new DateTime(2022, 4, 26, 15, 31, 40, 873, DateTimeKind.Local).AddTicks(9426), null, "Jamil", "Abrantes" });

            migrationBuilder.InsertData(
                table: "CandidateExperiences",
                columns: new[] { "Id", "BeginDate", "CandidateId", "Company", "Description", "EndDate", "InsertDate", "Job", "ModifyDate", "Salary" },
                values: new object[] { new Guid("d7dcbc05-9895-43fe-b112-34b7c444d5c7"), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e4040850-384b-4c08-a117-a5bacb54d6e8"), "Jamil LTDA", "Desenvolvimento de aplicativos", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 26, 15, 31, 40, 875, DateTimeKind.Local).AddTicks(3198), "Dev.Net SR", null, 9.5m });

            migrationBuilder.InsertData(
                table: "CandidateExperiences",
                columns: new[] { "Id", "BeginDate", "CandidateId", "Company", "Description", "EndDate", "InsertDate", "Job", "ModifyDate", "Salary" },
                values: new object[] { new Guid("4ae2618b-885a-4a74-acc3-a05a97ecdccb"), new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e4040850-384b-4c08-a117-a5bacb54d6e8"), "Jamil LTDA 02", "Desenvolvimento de aplicativos 02", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 26, 15, 31, 40, 875, DateTimeKind.Local).AddTicks(4136), "Dev.Net SR 02", null, 9.5m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CandidateExperiences",
                keyColumn: "Id",
                keyValue: new Guid("4ae2618b-885a-4a74-acc3-a05a97ecdccb"));

            migrationBuilder.DeleteData(
                table: "CandidateExperiences",
                keyColumn: "Id",
                keyValue: new Guid("d7dcbc05-9895-43fe-b112-34b7c444d5c7"));

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: new Guid("e4040850-384b-4c08-a117-a5bacb54d6e8"));

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
        }
    }
}
