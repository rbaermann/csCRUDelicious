using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private CRUDeliciousContext dbContext;

        public HomeController(CRUDeliciousContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public ViewResult Index()
        {
            List<Dish> dishes = dbContext.Dishes.OrderByDescending(d => d.CreatedAt).ToList();
            return View("Index", dishes);
        }

        [HttpGet("new")]
        public ViewResult NewDish()
        {
            return View("NewDish");
        }

        [HttpPost("addingnewdish")]
        public IActionResult AddingNewDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index", newDish);
            }
            else
            {
                return View("NewDish");
            }
        }

        [HttpGet("{id}")]
        public ViewResult DisplayDish(int id)
        {
            Dish dish = dbContext.Dishes.FirstOrDefault(d => d.DishId == id);
            return View("DisplayDish", dish);
        }

        [HttpGet("edit/{id}")]
        public ViewResult EditDish(int id)
        {
            Dish dish = dbContext.Dishes.FirstOrDefault(d => d.DishId == id);
            return View("EditDish", dish);
        }

        [HttpPost("update")]
        public IActionResult UpdatingDish(Dish updatingDish)
        {
            if(ModelState.IsValid)
            {
                Dish dish = dbContext.Dishes.FirstOrDefault(d => d.DishId == updatingDish.DishId);
                dish.Name = updatingDish.Name;
                dish.Chef = updatingDish.Chef;
                dish.Tastiness = updatingDish.Tastiness;
                dish.Calories = updatingDish.Calories;
                dish.Description = updatingDish.Description;
                dish.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("DisplayDish", new {id = dish.DishId});
            }
            else{
                return View("EditDish", updatingDish);
            }
        }

        [HttpGet("delete/{id}")]
        public RedirectToActionResult DeleteDish(int id)
        {
            Dish dish = dbContext.Dishes.FirstOrDefault(d => d.DishId == id);
            dbContext.Dishes.Remove(dish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
