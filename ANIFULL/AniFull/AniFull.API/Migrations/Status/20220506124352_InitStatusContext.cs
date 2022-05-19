using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AniFull.API.Migrations.Status
{
    public partial class InitStatusContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Viewed = table.Column<int>(type: "INTEGER", nullable: false),
                    Looking = table.Column<int>(type: "INTEGER", nullable: false),
                    InPlan = table.Column<int>(type: "INTEGER", nullable: false),
                    Postponned = table.Column<int>(type: "INTEGER", nullable: false),
                    Abandoned = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
