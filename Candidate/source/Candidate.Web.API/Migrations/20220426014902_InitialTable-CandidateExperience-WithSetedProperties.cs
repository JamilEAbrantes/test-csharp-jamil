using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Candidate.Web.API.Migrations
{
    public partial class InitialTableCandidateExperienceWithSetedProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateExperiences_Candidates_CandidateId",
                table: "CandidateExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateExperiences",
                table: "CandidateExperiences");

            migrationBuilder.DeleteData(
                table: "CandidateExperiences",
                keyColumn: "Id",
                keyValue: new Guid("a55ebf1c-3753-468f-bd55-8f0c62dcc257"));

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: new Guid("c3364659-9899-4ffa-993b-baca6fccacbd"));

            migrationBuilder.RenameTable(
                name: "CandidateExperiences",
                newName: "CandidateExperience");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateExperiences_CandidateId",
                table: "CandidateExperience",
                newName: "IX_CandidateExperience_CandidateId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "CandidateExperience",
                type: "numeric(8, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "CandidateExperience",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CandidateExperience",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Company",
                table: "CandidateExperience",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateExperience",
                table: "CandidateExperience",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "Birthdate", "Email", "InsertDate", "ModifyDate", "Name", "Surname" },
                values: new object[] { new Guid("acf4875c-8610-4a94-9405-2213dd9174e6"), new DateTime(1989, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "jamilabrantes@gmail.com", new DateTime(2022, 4, 25, 22, 49, 1, 631, DateTimeKind.Local).AddTicks(7294), null, "Jamil", "Abrantes" });

            migrationBuilder.InsertData(
                table: "CandidateExperience",
                columns: new[] { "Id", "BeginDate", "CandidateId", "Company", "Description", "EndDate", "InsertDate", "Job", "ModifyDate", "Salary" },
                values: new object[] { new Guid("f20ecef3-9d68-4d83-827f-de1aa3af0e53"), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("acf4875c-8610-4a94-9405-2213dd9174e6"), "Jamil LTDA", "Desenvolvimento de aplicativos", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 22, 49, 1, 633, DateTimeKind.Local).AddTicks(1365), "Dev.Net SR", null, 9.5m });

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateExperience_Candidates_CandidateId",
                table: "CandidateExperience",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateExperience_Candidates_CandidateId",
                table: "CandidateExperience");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateExperience",
                table: "CandidateExperience");

            migrationBuilder.DeleteData(
                table: "CandidateExperience",
                keyColumn: "Id",
                keyValue: new Guid("f20ecef3-9d68-4d83-827f-de1aa3af0e53"));

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: new Guid("acf4875c-8610-4a94-9405-2213dd9174e6"));

            migrationBuilder.RenameTable(
                name: "CandidateExperience",
                newName: "CandidateExperiences");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateExperience_CandidateId",
                table: "CandidateExperiences",
                newName: "IX_CandidateExperiences_CandidateId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "CandidateExperiences",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(8, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "CandidateExperiences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CandidateExperiences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4000);

            migrationBuilder.AlterColumn<string>(
                name: "Company",
                table: "CandidateExperiences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateExperiences",
                table: "CandidateExperiences",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "Birthdate", "Email", "InsertDate", "ModifyDate", "Name", "Surname" },
                values: new object[] { new Guid("c3364659-9899-4ffa-993b-baca6fccacbd"), new DateTime(1989, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "jamilabrantes@gmail.com", new DateTime(2022, 4, 25, 22, 34, 27, 922, DateTimeKind.Local).AddTicks(2261), null, "Jamil", "Abrantes" });

            migrationBuilder.InsertData(
                table: "CandidateExperiences",
                columns: new[] { "Id", "BeginDate", "CandidateId", "Company", "Description", "EndDate", "InsertDate", "Job", "ModifyDate", "Salary" },
                values: new object[] { new Guid("a55ebf1c-3753-468f-bd55-8f0c62dcc257"), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3364659-9899-4ffa-993b-baca6fccacbd"), "Jamil LTDA", "Desenvolvimento de aplicativos", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 22, 34, 27, 923, DateTimeKind.Local).AddTicks(7458), "Dev .Net SR", null, 9.5m });

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateExperiences_Candidates_CandidateId",
                table: "CandidateExperiences",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
