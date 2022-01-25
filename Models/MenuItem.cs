using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Meal_Plan_Calendar.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        public string Meal_Type { get; set; }
        public string Meal_Name { get; set; }
        public string Meal_Ingredients { get; set; }
        public string Meal_Img { get; set; }
    }
}
