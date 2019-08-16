using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Required]
        public int DishId {get; set;}
        
        [Required]
        public string Name {get; set;}

        [Required]
        public string Chef {get; set;}

        [Required]
        [Range(1, 6)]
        public int Tastiness {get; set;}

        [Required]
        
        public int Calories {get; set;}

        [Required]
        public string Description {get; set;}

        [Required]
        public DateTime CreatedAt {get; set;} = DateTime.Now;

        [Required]
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}