using Microsoft.EntityFrameworkCore.Migrations;

namespace MealPlanCalendar.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Meal_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Meal_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Meal_Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Meal_Img = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItem");
        }
    }
}
