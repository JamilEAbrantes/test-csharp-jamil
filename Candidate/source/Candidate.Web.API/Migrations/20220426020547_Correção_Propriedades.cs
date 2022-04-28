using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Candidate.Web.API.Migrations
{
    public partial class Correção_Propriedades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CandidateExperiences",
                keyColumn: "Id",
                keyValue: new Guid("2aedc2fe-529a-4b15-8852-74b5e744a6a0"));

            migrationBuilder.DeleteData(
                table: "CandidateExperiences",
                keyColumn: "Id",
                keyValue: new Guid("ea35c23f-0890-4bb6-a192-9077fe165c5a"));

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: new Guid("4379621c-83af-4109-96b0-665626fce5bc"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Candidates",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDate",
                table: "Candidates",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "CandidateExperiences",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDate",
                table: "CandidateExperiences",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "CandidateExperiences",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginDate",
                table: "CandidateExperiences",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "ModifyDate",
                table: "Candidates",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDate",
                table: "Candidates",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "CandidateExperiences",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertDate",
                table: "CandidateExperiences",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "CandidateExperiences",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginDate",
                table: "CandidateExperiences",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "Birthdate", "Email", "InsertDate", "ModifyDate", "Name", "Surname" },
                values: new object[] { new Guid("4379621c-83af-4109-96b0-665626fce5bc"), new DateTime(1989, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "jamilabrantes@gmail.com", new DateTime(2022, 4, 25, 22, 55, 6, 951, DateTimeKind.Local).AddTicks(66), null, "Jamil", "Abrantes" });

            migrationBuilder.InsertData(
                table: "CandidateExperiences",
                columns: new[] { "Id", "BeginDate", "CandidateId", "Company", "Description", "EndDate", "InsertDate", "Job", "ModifyDate", "Salary" },
                values: new object[] { new Guid("ea35c23f-0890-4bb6-a192-9077fe165c5a"), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4379621c-83af-4109-96b0-665626fce5bc"), "Jamil LTDA", "Desenvolvimento de aplicativos", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 22, 55, 6, 952, DateTimeKind.Local).AddTicks(4112), "Dev.Net SR", null, 9.5m });

            migrationBuilder.InsertData(
                table: "CandidateExperiences",
                columns: new[] { "Id", "BeginDate", "CandidateId", "Company", "Description", "EndDate", "InsertDate", "Job", "ModifyDate", "Salary" },
                values: new object[] { new Guid("2aedc2fe-529a-4b15-8852-74b5e744a6a0"), new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4379621c-83af-4109-96b0-665626fce5bc"), "Jamil LTDA 02", "Desenvolvimento de aplicativos 02", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 22, 55, 6, 952, DateTimeKind.Local).AddTicks(4976), "Dev.Net SR 02", null, 9.5m });
        }
    }
}
