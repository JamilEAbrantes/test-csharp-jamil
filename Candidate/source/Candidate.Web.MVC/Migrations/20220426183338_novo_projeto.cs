using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Candidate.Web.MVC.Migrations
{
    public partial class novo_projeto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("90aacaca-8f44-49b7-afc5-3ba374945f2f"), new DateTime(1989, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "jamilabrantes@gmail.com", new DateTime(2022, 4, 26, 15, 33, 38, 377, DateTimeKind.Local).AddTicks(8217), null, "Jamil", "Abrantes" });

            migrationBuilder.InsertData(
                table: "CandidateExperiences",
                columns: new[] { "Id", "BeginDate", "CandidateId", "Company", "Description", "EndDate", "InsertDate", "Job", "ModifyDate", "Salary" },
                values: new object[] { new Guid("293bc642-a5ae-4951-ab3a-81a6f882d746"), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("90aacaca-8f44-49b7-afc5-3ba374945f2f"), "Jamil LTDA", "Desenvolvimento de aplicativos", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 26, 15, 33, 38, 379, DateTimeKind.Local).AddTicks(1828), "Dev.Net SR", null, 9.5m });

            migrationBuilder.InsertData(
                table: "CandidateExperiences",
                columns: new[] { "Id", "BeginDate", "CandidateId", "Company", "Description", "EndDate", "InsertDate", "Job", "ModifyDate", "Salary" },
                values: new object[] { new Guid("bfb0c95e-65f6-47e7-b3a8-55201a8b5fd5"), new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("90aacaca-8f44-49b7-afc5-3ba374945f2f"), "Jamil LTDA 02", "Desenvolvimento de aplicativos 02", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 26, 15, 33, 38, 379, DateTimeKind.Local).AddTicks(2677), "Dev.Net SR 02", null, 9.5m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CandidateExperiences",
                keyColumn: "Id",
                keyValue: new Guid("293bc642-a5ae-4951-ab3a-81a6f882d746"));

            migrationBuilder.DeleteData(
                table: "CandidateExperiences",
                keyColumn: "Id",
                keyValue: new Guid("bfb0c95e-65f6-47e7-b3a8-55201a8b5fd5"));

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: new Guid("90aacaca-8f44-49b7-afc5-3ba374945f2f"));

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
    }
}
