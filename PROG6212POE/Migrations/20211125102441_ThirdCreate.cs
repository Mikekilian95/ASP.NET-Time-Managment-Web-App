using Microsoft.EntityFrameworkCore.Migrations;

namespace PROG6212POE.Migrations
{
    public partial class ThirdCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    ScheduleID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MondayModule = table.Column<string>(type: "TEXT", nullable: true),
                    TuesdayModule = table.Column<string>(type: "TEXT", nullable: true),
                    WednesdayModule = table.Column<string>(type: "TEXT", nullable: true),
                    ThursdayModule = table.Column<string>(type: "TEXT", nullable: true),
                    FridayModule = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.ScheduleID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedule");
        }
    }
}
