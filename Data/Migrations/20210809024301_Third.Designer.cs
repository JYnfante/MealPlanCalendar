﻿// <auto-generated />
using System;
using MealPlanCalendar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MealPlanCalendar.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210809024301_Third")]
    partial class Third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Meal_Plan_Calendar.Models.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Meal_Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Meal_Ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Meal_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Meal_Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MenuItem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Meal_Img = "Beef Chili.jpg",
                            Meal_Ingredients = "2 1/2 pounds beef chuck, 2 red bell peppers, 1 yellow onion, 3 tomatoes, 2 cloves garlic, 2 1/2 tbsp chili powder, 3 tsp sea salt, 2 tsp cumin, 1/2 tsp paprika, 1/2 tsp curry powder, 1/2 tsp cinnamon, 1/4 tsp black pepper, 1/4 cayenne pepper",
                            Meal_Name = "Beef Chili",
                            Meal_Type = "Dinner"
                        },
                        new
                        {
                            Id = 2,
                            Meal_Img = "Curried Chicken Salad.jpg",
                            Meal_Ingredients = "2 lbs skinless, boneless chicken breasts, 2 tsp coconut oil, melted, salt and pepper, 1/2 cup mayonnaise, 1/2 cup grapes, halved, 1/2 cup cashew halves, toasted, 1/4 cup finely chopped celery, 1/4 finely chopped red onion, 1/4 cup finely shredded carrots, 1/2 tsp sea salt, Curry Spice Mix, 1 tbsp chopped fresh mint leaves",
                            Meal_Name = "Curried Chicken Salad",
                            Meal_Type = "Lunch"
                        },
                        new
                        {
                            Id = 3,
                            Meal_Img = "Club Sandwich Wrap.jpg",
                            Meal_Ingredients = "2 large iceberg lettuce leaves, 1/2 cup Pesto Mayo, 2 slices crispy cooked bacon, 2 ounces sliced roasted turkey or thinly sliced chicken breast, 2 slices vine-ripened tomato, 1 sliced avocado, dill pickles",
                            Meal_Name = "Club Sandwich Wrap",
                            Meal_Type = "Lunch"
                        },
                        new
                        {
                            Id = 4,
                            Meal_Img = "Curried Short Ribs.jpg",
                            Meal_Ingredients = "2 tbsp coconut oil, 4 lbs beef short ribs, salt and pepper, 1/3 cup tomato paste, 1/3 cup red curry paste, 4 cloves garlic, 2 tbsp fish sauce, 2 tsp fresh lime juice, 1 tsp ground ginger, 1/2 yellow onion, sliced, 1 lb carrots, peeled",
                            Meal_Name = "Curried Short Ribs",
                            Meal_Type = "Dinner"
                        },
                        new
                        {
                            Id = 5,
                            Meal_Img = "Indian-spiced Pork Roast.jpg",
                            Meal_Ingredients = "1 tbsp bacon fat, 3 lbs boneless pork top-loin, 1 tbspn garam masala, 1/2 tsp sea salt, 6 large carrots, peeled and cut, 1/2 tsp cumin, 1/4 tsp curry powder, Asian Pear Chutney",
                            Meal_Name = "Indian-spiced Pork Roast",
                            Meal_Type = "Dinner"
                        },
                        new
                        {
                            Id = 6,
                            Meal_Img = "Carne Asada Burrito Bowl.jpg",
                            Meal_Ingredients = "1/4 cup chopped cilantro, 3 cloves garlic, 2 tbsp coconut aminos, 2 tbsp orange juice, 1 tbsp fresh lime juice, 1/2 tbsp apple cider vinegar, 1/2 tsp cumin, 1/2 tsp sea salt, 1/2 tsp chili powder, 1/4 tsp dried oregano, 1/4 tsp paprika, 1/4 tsp cayenne pepper, 1/4 tsp black pepper, 1 lb flank steak",
                            Meal_Name = "Carne Asada Burrito Bowl",
                            Meal_Type = "Lunch"
                        },
                        new
                        {
                            Id = 7,
                            Meal_Img = "Banana Pancakes.jpg",
                            Meal_Ingredients = "6 eggs, 1 cup blanched almond flour, 3/4 cup sliced bananas, 1/2 cup coconut milk, 1/4 cup coconut flour, 2 tsp pure vanilla extract, 2 tsp honey, 1 tsp baking soda, dash of sea salt, 1 tsp coconut oil",
                            Meal_Name = "Banana Pancakes",
                            Meal_Type = "Breakfast"
                        },
                        new
                        {
                            Id = 8,
                            Meal_Img = "Lemon-basil Sea Bass.jpg",
                            Meal_Ingredients = "3 zucchini, julienne-sliced into noodles, 1/4 cup chopped basil, 4 6-oz sea bass fillets, 2 sliced roma tomatoes, 2 sliced lemons, 2 cloves garlic, 4 tbsp extra-virgin olive oil, salt and pepper, 4 sheets parchment paper",
                            Meal_Name = "Lemon-basil Sea Bass",
                            Meal_Type = "Dinner"
                        },
                        new
                        {
                            Id = 9,
                            Meal_Img = "Sesame-orange Chicken.jpg",
                            Meal_Ingredients = "2 lbs boneless, skinless chicken thighs, 1/3 cup coconut aminos, 1/3 cup honey, 2 tbsp orange juice, 2 tbsp tomato paste, 1 tbsp toased sesame oil, 2 tsp minced garlic, 1/2 tsp ground ginger, 3/4 tsp sea salt, 1/2 tsp red pepper flakes, 1/4 tsp cracked black pepper, garnish: sesame seeds",
                            Meal_Name = "Sesame-orange Chicken",
                            Meal_Type = "Dinner"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
