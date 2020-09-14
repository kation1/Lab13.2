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
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            System.Data.IDbConnection db = new System.Data.SqlClient.SqlConnection("Server=6PP7Q13\\SQLEXPRESS;Database=CoffeeShop;user id=asdf;password=asdf;");
            db.Open();

            List<Product> products = db.Query<Product>("select * from Product").AsList<Product>();

            db.Close();
            return View(products);
        }

        public IActionResult Detail(int id)
        {
            System.Data.IDbConnection db = new System.Data.SqlClient.SqlConnection("Server=6PP7Q13\\SQLEXPRESS;Database=CoffeeShop;user id=asdf;password=asdf;");
            db.Open();

            Product prodselected= db.QuerySingle<Product>($"select * from Product where id = {id}");


            db.Close();
            return View(prodselected);
        }
    }
}
