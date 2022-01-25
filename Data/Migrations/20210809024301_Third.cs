using Microsoft.EntityFrameworkCore.Migrations;

namespace MealPlanCalendar.Data.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "Meal_Type",
                value: "Dinner");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "Meal_Type",
                value: "Lunch");

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "Meal_Type",
                value: "Lunch");

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "Id", "Meal_Img", "Meal_Ingredients", "Meal_Name", "Meal_Type" },
                values: new object[,]
                {
                    { 4, "Curried Short Ribs.jpg", "2 tbsp coconut oil, 4 lbs beef short ribs, salt and pepper, 1/3 cup tomato paste, 1/3 cup red curry paste, 4 cloves garlic, 2 tbsp fish sauce, 2 tsp fresh lime juice, 1 tsp ground ginger, 1/2 yellow onion, sliced, 1 lb carrots, peeled", "Curried Short Ribs", "Dinner" },
                    { 5, "Indian-spiced Pork Roast.jpg", "1 tbsp bacon fat, 3 lbs boneless pork top-loin, 1 tbspn garam masala, 1/2 tsp sea salt, 6 large carrots, peeled and cut, 1/2 tsp cumin, 1/4 tsp curry powder, Asian Pear Chutney", "Indian-spiced Pork Roast", "Dinner" },
                    { 6, "Carne Asada Burrito Bowl.jpg", "1/4 cup chopped cilantro, 3 cloves garlic, 2 tbsp coconut aminos, 2 tbsp orange juice, 1 tbsp fresh lime juice, 1/2 tbsp apple cider vinegar, 1/2 tsp cumin, 1/2 tsp sea salt, 1/2 tsp chili powder, 1/4 tsp dried oregano, 1/4 tsp paprika, 1/4 tsp cayenne pepper, 1/4 tsp black pepper, 1 lb flank steak", "Carne Asada Burrito Bowl", "Lunch" },
                    { 7, "Banana Pancakes.jpg", "6 eggs, 1 cup blanched almond flour, 3/4 cup sliced bananas, 1/2 cup coconut milk, 1/4 cup coconut flour, 2 tsp pure vanilla extract, 2 tsp honey, 1 tsp baking soda, dash of sea salt, 1 tsp coconut oil", "Banana Pancakes", "Breakfast" },
                    { 8, "Lemon-basil Sea Bass.jpg", "3 zucchini, julienne-sliced into noodles, 1/4 cup chopped basil, 4 6-oz sea bass fillets, 2 sliced roma tomatoes, 2 sliced lemons, 2 cloves garlic, 4 tbsp extra-virgin olive oil, salt and pepper, 4 sheets parchment paper", "Lemon-basil Sea Bass", "Dinner" },
                    { 9, "Sesame-orange Chicken.jpg", "2 lbs boneless, skinless chicken thighs, 1/3 cup coconut aminos, 1/3 cup honey, 2 tbsp orange juice, 2 tbsp tomato paste, 1 tbsp toased sesame oil, 2 tsp minced garlic, 1/2 tsp ground ginger, 3/4 tsp sea salt, 1/2 tsp red pepper flakes, 1/4 tsp cracked black pepper, garnish: sesame seeds", "Sesame-orange Chicken", "Dinner" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "Meal_Type",
                value: null);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "Meal_Type",
                value: null);

            migrationBuilder.UpdateData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "Meal_Type",
                value: null);
        }
    }
}
