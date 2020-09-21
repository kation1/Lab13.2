using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Lab13._2.Models;
using Dapper.Contrib.Extensions;


namespace Lab13._2.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {

            //System.Data.IDbConnection db = new System.Data.SqlClient.SqlConnection("Server=6PP7Q13\\SQLEXPRESS;Database=CoffeeShop;user id=asdf;password=asdf;");
            //db.Open();

            //List<Product> products = db.Query<Product>("select * from Product").AsList<Product>();

            //db.Close();


            return View(DAL.Read());

        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
            // Return the instance

        }
        [HttpPost]
        public IActionResult AddProduct(string name, decimal price, string description, string category)
        {
            DAL.AddProduct(name, price, description, category);
            return RedirectToAction("Index", "Admin");

        }

        public IActionResult DeleteProduct(long id)
        {

            DAL.DeleteProduct(id);

            return RedirectToAction("Index", "Admin");
        }

        [HttpGet]

        public IActionResult UpdateProduct(long id)
        {
            Product prod = DAL.GetProduct(id);
            return View(prod);
        }

        [HttpPost]

        public IActionResult UpdateProduct(long id, string name, decimal price, string description, string category)
        {

            DAL.UpdateProduct(id,name, price, description, category);

            return RedirectToAction("Index", "Admin");
        }

    }
}
