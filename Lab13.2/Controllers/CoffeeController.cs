using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Lab13._2.Models;



namespace Lab13._2.Controllers
{
    public class CoffeeController : Controller
    {
        [HttpGet]
        public IActionResult OrderCoffee()
        {
            System.Data.IDbConnection db = new System.Data.SqlClient.SqlConnection("Server=6PP7Q13\\SQLEXPRESS;Database=CoffeeShop;user id=asdf;password=asdf;");
            db.Open();

            List<Product> products = db.Query<Product>("select * from Product").AsList<Product>();

            db.Close();
            return View(products);
        }

        [HttpPost]
        public IActionResult Receipt(string coffeeType, string size, string service, DateTime pickUpTime, string name)
        {
            if (service == "delivery")
            {
                pickUpTime = pickUpTime.AddMinutes(15);
                ViewBag.TimeMessage = $"Your expected Delivery time is {@pickUpTime}";
            }
            else
            {
                ViewBag.TimeMessage = $"Your expected Pick Up time is {pickUpTime}";
            }

            CoffeeOrder order = new CoffeeOrder() 
                { CoffeeType = coffeeType, Size = size, Pickup = service, PickUpTime = pickUpTime, CustomerName = ""};
            return View(order);
        }
    }
}