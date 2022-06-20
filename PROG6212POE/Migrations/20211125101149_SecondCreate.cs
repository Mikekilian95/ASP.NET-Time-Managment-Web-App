using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROG6212POE.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SelfStudy",
                columns: table => new
                {
                    SelfStudyID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserID = table.Column<int>(type: "INTEGER", nullable: false),
                    ModuleID = table.Column<int>(type: "INTEGER", nullable: false),
                    ModuleChosen = table.Column<int>(type: "INTEGER", nullable: false),
                    DateChosen = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StudyHours = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelfStudy", x => x.SelfStudyID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SelfStudy");
        }
    }
}
