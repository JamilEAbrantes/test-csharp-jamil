using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Candidate.Web.API.Migrations
{
    public partial class Correção_Nome_Tabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateExperiences",
                table: "CandidateExperiences",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateExperiences_Candidates_CandidateId",
                table: "CandidateExperiences",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("2aedc2fe-529a-4b15-8852-74b5e744a6a0"));

            migrationBuilder.DeleteData(
                table: "CandidateExperiences",
                keyColumn: "Id",
                keyValue: new Guid("ea35c23f-0890-4bb6-a192-9077fe165c5a"));

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: new Guid("4379621c-83af-4109-96b0-665626fce5bc"));

            migrationBuilder.RenameTable(
                name: "CandidateExperiences",
                newName: "CandidateExperience");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateExperiences_CandidateId",
                table: "CandidateExperience",
                newName: "IX_CandidateExperience_CandidateId");

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
    }
}
