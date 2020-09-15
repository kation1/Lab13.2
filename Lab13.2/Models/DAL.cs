using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace Lab13._2.Models
{
    public class DAL
    {

        public static List<Product> Read()
        {
            System.Data.IDbConnection db = new System.Data.SqlClient.SqlConnection("Server=6PP7Q13\\SQLEXPRESS;Database=CoffeeShop;user id=asdf;password=asdf;");
            db.Open();

            List<Product> prods = db.GetAll<Product>().ToList();
            return prods;
        }

        public static Product AddProduct(string _name, decimal _price, string _description, string _category)
        {
            // Create the new Product instance
            Product prod = new Product() { Name = _name, Price = _price, Description = _description, Category = _category };

            // Save it to the database
            IDbConnection db = new SqlConnection("Server=6PP7Q13\\SQLEXPRESS;Database=CoffeeShop;user id=asdf;password=asdf;");
            long _id = db.Insert<Product>(prod);

            // Set the id column of the instance
            prod.id = _id;

            return prod;

        }

        public static void DeleteProduct(long _id)
        {
            IDbConnection db = new SqlConnection("Server=6PP7Q13\\SQLEXPRESS;Database=CoffeeShop;user id=asdf;password=asdf;");
            db.Delete(new Product() { id = _id });
        }

        public static Product GetProduct(long _id)
        {
            IDbConnection db = new SqlConnection("Server=6PP7Q13\\SQLEXPRESS;Database=CoffeeShop;user id=asdf;password=asdf;");
            Product prod = db.Get<Product>(_id);

            return prod;
        }

        public static void UpdateProduct(long _id, string name, decimal price, string description, string category)
        {
            IDbConnection db = new SqlConnection("Server=6PP7Q13\\SQLEXPRESS;Database=CoffeeShop;user id=asdf;password=asdf;");
            //Product prod = new Product { id = _id, Name =name, Price = price, Description = description, Category =category };
           // DeleteProduct(_id);
           // _id = db.Insert(prod);

              Product prod = (Product)db.Query("UPDATE [dbo].[Product] SET [id]=_id, [Name] = name,[Price] = price,[Description] = description,[Category] = category WHERE id = Product.id");

           
        }
    }
}
