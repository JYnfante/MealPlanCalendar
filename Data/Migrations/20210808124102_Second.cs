using Microsoft.EntityFrameworkCore.Migrations;

namespace MealPlanCalendar.Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "Id", "Meal_Img", "Meal_Ingredients", "Meal_Name", "Meal_Type" },
                values: new object[] { 1, "Beef Chili.jpg", "2 1/2 pounds beef chuck, 2 red bell peppers, 1 yellow onion, 3 tomatoes, 2 cloves garlic, 2 1/2 tbsp chili powder, 3 tsp sea salt, 2 tsp cumin, 1/2 tsp paprika, 1/2 tsp curry powder, 1/2 tsp cinnamon, 1/4 tsp black pepper, 1/4 cayenne pepper", "Beef Chili", null });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "Id", "Meal_Img", "Meal_Ingredients", "Meal_Name", "Meal_Type" },
                values: new object[] { 2, "Curried Chicken Salad.jpg", "2 lbs skinless, boneless chicken breasts, 2 tsp coconut oil, melted, salt and pepper, 1/2 cup mayonnaise, 1/2 cup grapes, halved, 1/2 cup cashew halves, toasted, 1/4 cup finely chopped celery, 1/4 finely chopped red onion, 1/4 cup finely shredded carrots, 1/2 tsp sea salt, Curry Spice Mix, 1 tbsp chopped fresh mint leaves", "Curried Chicken Salad", null });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "Id", "Meal_Img", "Meal_Ingredients", "Meal_Name", "Meal_Type" },
                values: new object[] { 3, "Club Sandwich Wrap.jpg", "2 large iceberg lettuce leaves, 1/2 cup Pesto Mayo, 2 slices crispy cooked bacon, 2 ounces sliced roasted turkey or thinly sliced chicken breast, 2 slices vine-ripened tomato, 1 sliced avocado, dill pickles", "Club Sandwich Wrap", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
