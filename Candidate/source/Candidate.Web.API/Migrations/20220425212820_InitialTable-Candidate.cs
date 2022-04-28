using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Candidate.Web.API.Migrations
{
    public partial class InitialTableCandidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "Birthdate", "Email", "InsertDate", "ModifyDate", "Name", "Surname" },
                values: new object[] { new Guid("867a4b2e-79e2-491b-9832-8e57987dc84e"), new DateTime(1989, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "jamilabrantes@gmail.com", new DateTime(2022, 4, 25, 18, 28, 20, 622, DateTimeKind.Local).AddTicks(1880), null, "Jamil", "Abrantes" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidates");
        }
    }
}
