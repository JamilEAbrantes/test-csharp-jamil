using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Candidate.Web.API.Migrations
{
    public partial class Correção_Propriedade_Birthdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CandidateExperiences",
                keyColumn: "Id",
                keyValue: new Guid("10c0b25e-9db0-4176-ab7e-6b0df4375ba5"));

            migrationBuilder.DeleteData(
                table: "CandidateExperiences",
                keyColumn: "Id",
                keyValue: new Guid("fbea27b2-96ae-4ed6-bc99-8d91f52c4475"));

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: new Guid("99d30852-9d07-4457-bcf5-13cce9e6ed15"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "Candidates",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "Birthdate", "Email", "InsertDate", "ModifyDate", "Name", "Surname" },
                values: new object[] { new Guid("c66c787c-35eb-4113-aa15-8581fc6beabe"), new DateTime(1989, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "jamilabrantes@gmail.com", new DateTime(2022, 4, 25, 23, 8, 6, 906, DateTimeKind.Local).AddTicks(5562), null, "Jamil", "Abrantes" });

            migrationBuilder.InsertData(
                table: "CandidateExperiences",
                columns: new[] { "Id", "BeginDate", "CandidateId", "Company", "Description", "EndDate", "InsertDate", "Job", "ModifyDate", "Salary" },
                values: new object[] { new Guid("407ee2f5-7ded-4991-8baf-5d7e6b83d402"), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c66c787c-35eb-4113-aa15-8581fc6beabe"), "Jamil LTDA", "Desenvolvimento de aplicativos", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 23, 8, 6, 907, DateTimeKind.Local).AddTicks(8856), "Dev.Net SR", null, 9.5m });

            migrationBuilder.InsertData(
                table: "CandidateExperiences",
                columns: new[] { "Id", "BeginDate", "CandidateId", "Company", "Description", "EndDate", "InsertDate", "Job", "ModifyDate", "Salary" },
                values: new object[] { new Guid("c7283ab2-7a3d-4ae9-b12f-9bdc892a429a"), new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c66c787c-35eb-4113-aa15-8581fc6beabe"), "Jamil LTDA 02", "Desenvolvimento de aplicativos 02", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 23, 8, 6, 907, DateTimeKind.Local).AddTicks(9699), "Dev.Net SR 02", null, 9.5m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CandidateExperiences",
                keyColumn: "Id",
                keyValue: new Guid("407ee2f5-7ded-4991-8baf-5d7e6b83d402"));

            migrationBuilder.DeleteData(
                table: "CandidateExperiences",
                keyColumn: "Id",
                keyValue: new Guid("c7283ab2-7a3d-4ae9-b12f-9bdc892a429a"));

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: new Guid("c66c787c-35eb-4113-aa15-8581fc6beabe"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "Candidates",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "Birthdate", "Email", "InsertDate", "ModifyDate", "Name", "Surname" },
                values: new object[] { new Guid("99d30852-9d07-4457-bcf5-13cce9e6ed15"), new DateTime(1989, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "jamilabrantes@gmail.com", new DateTime(2022, 4, 25, 23, 5, 47, 460, DateTimeKind.Local).AddTicks(3534), null, "Jamil", "Abrantes" });

            migrationBuilder.InsertData(
                table: "CandidateExperiences",
                columns: new[] { "Id", "BeginDate", "CandidateId", "Company", "Description", "EndDate", "InsertDate", "Job", "ModifyDate", "Salary" },
                values: new object[] { new Guid("10c0b25e-9db0-4176-ab7e-6b0df4375ba5"), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("99d30852-9d07-4457-bcf5-13cce9e6ed15"), "Jamil LTDA", "Desenvolvimento de aplicativos", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 23, 5, 47, 461, DateTimeKind.Local).AddTicks(7763), "Dev.Net SR", null, 9.5m });

            migrationBuilder.InsertData(
                table: "CandidateExperiences",
                columns: new[] { "Id", "BeginDate", "CandidateId", "Company", "Description", "EndDate", "InsertDate", "Job", "ModifyDate", "Salary" },
                values: new object[] { new Guid("fbea27b2-96ae-4ed6-bc99-8d91f52c4475"), new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("99d30852-9d07-4457-bcf5-13cce9e6ed15"), "Jamil LTDA 02", "Desenvolvimento de aplicativos 02", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 23, 5, 47, 461, DateTimeKind.Local).AddTicks(8598), "Dev.Net SR 02", null, 9.5m });
        }
    }
}
