using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Meal_Plan_Calendar.Models;

namespace MealPlanCalendar.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Meal_Plan_Calendar.Models.MenuItem> MenuItem { get; set; }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem
                {
                    Id = 1,
                    Meal_Type = "Dinner",
                    Meal_Name = "Beef Chili",
                    Meal_Ingredients = "2 1/2 pounds beef chuck, 2 red bell peppers, 1 yellow onion, 3 tomatoes, 2 cloves garlic, 2 1/2 tbsp chili powder, 3 tsp sea salt, 2 tsp cumin, 1/2 tsp paprika, 1/2 tsp curry powder, 1/2 tsp cinnamon, 1/4 tsp black pepper, 1/4 cayenne pepper",
                    Meal_Img = "Beef Chili.jpg"
                },
                new MenuItem
                {
                    Id = 2,
                    Meal_Type = "Lunch",
                    Meal_Name = "Curried Chicken Salad",
                    Meal_Ingredients = "2 lbs skinless, boneless chicken breasts, 2 tsp coconut oil, melted, salt and pepper, 1/2 cup mayonnaise, 1/2 cup grapes, halved, 1/2 cup cashew halves, toasted, 1/4 cup finely chopped celery, 1/4 finely chopped red onion, 1/4 cup finely shredded carrots, 1/2 tsp sea salt, Curry Spice Mix, 1 tbsp chopped fresh mint leaves",
                    Meal_Img = "Curried Chicken Salad.jpg"
                },
                new MenuItem
                {
                    Id = 3,
                    Meal_Type = "Lunch",
                    Meal_Name = "Club Sandwich Wrap",
                    Meal_Ingredients = "2 large iceberg lettuce leaves, 1/2 cup Pesto Mayo, 2 slices crispy cooked bacon, 2 ounces sliced roasted turkey or thinly sliced chicken breast, 2 slices vine-ripened tomato, 1 sliced avocado, dill pickles",
                    Meal_Img = "Club Sandwich Wrap.jpg"
                },
                new MenuItem
                {
                    Id = 4,
                    Meal_Type = "Dinner",
                    Meal_Name = "Curried Short Ribs",
                    Meal_Ingredients = "2 tbsp coconut oil, 4 lbs beef short ribs, salt and pepper, 1/3 cup tomato paste, 1/3 cup red curry paste, 4 cloves garlic, 2 tbsp fish sauce, 2 tsp fresh lime juice, 1 tsp ground ginger, 1/2 yellow onion, sliced, 1 lb carrots, peeled",
                    Meal_Img = "Curried Short Ribs.jpg"
                },
                new MenuItem
                {
                    Id = 5,
                    Meal_Type = "Dinner",
                    Meal_Name = "Indian-spiced Pork Roast",
                    Meal_Ingredients = "1 tbsp bacon fat, 3 lbs boneless pork top-loin, 1 tbspn garam masala, 1/2 tsp sea salt, 6 large carrots, peeled and cut, 1/2 tsp cumin, 1/4 tsp curry powder, Asian Pear Chutney",
                    Meal_Img = "Indian-spiced Pork Roast.jpg"
                },
                new MenuItem
                {
                    Id = 6,
                    Meal_Type = "Lunch",
                    Meal_Name = "Carne Asada Burrito Bowl",
                    Meal_Ingredients = "1/4 cup chopped cilantro, 3 cloves garlic, 2 tbsp coconut aminos, 2 tbsp orange juice, 1 tbsp fresh lime juice, 1/2 tbsp apple cider vinegar, 1/2 tsp cumin, 1/2 tsp sea salt, 1/2 tsp chili powder, 1/4 tsp dried oregano, 1/4 tsp paprika, 1/4 tsp cayenne pepper, 1/4 tsp black pepper, 1 lb flank steak",
                    Meal_Img = "Carne Asada Burrito Bowl.jpg"
                },
                new MenuItem
                {
                    Id = 7,
                    Meal_Type = "Breakfast",
                    Meal_Name = "Banana Pancakes",
                    Meal_Ingredients = "6 eggs, 1 cup blanched almond flour, 3/4 cup sliced bananas, 1/2 cup coconut milk, 1/4 cup coconut flour, 2 tsp pure vanilla extract, 2 tsp honey, 1 tsp baking soda, dash of sea salt, 1 tsp coconut oil",
                    Meal_Img = "Banana Pancakes.jpg"
                },
                new MenuItem
                {
                    Id = 8,
                    Meal_Type = "Dinner",
                    Meal_Name = "Lemon-basil Sea Bass",
                    Meal_Ingredients = "3 zucchini, julienne-sliced into noodles, 1/4 cup chopped basil, 4 6-oz sea bass fillets, 2 sliced roma tomatoes, 2 sliced lemons, 2 cloves garlic, 4 tbsp extra-virgin olive oil, salt and pepper, 4 sheets parchment paper",
                    Meal_Img = "Lemon-basil Sea Bass.jpg"
                },
                new MenuItem
                {
                    Id = 9,
                    Meal_Type = "Dinner",
                    Meal_Name = "Sesame-orange Chicken",
                    Meal_Ingredients = "2 lbs boneless, skinless chicken thighs, 1/3 cup coconut aminos, 1/3 cup honey, 2 tbsp orange juice, 2 tbsp tomato paste, 1 tbsp toased sesame oil, 2 tsp minced garlic, 1/2 tsp ground ginger, 3/4 tsp sea salt, 1/2 tsp red pepper flakes, 1/4 tsp cracked black pepper, garnish: sesame seeds",
                    Meal_Img = "Sesame-orange Chicken.jpg"
                }
            );
        }
    }
}