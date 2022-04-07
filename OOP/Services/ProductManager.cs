using OOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Services
{
    public class ProductManager
    {
        List<Product> products = new()
        {
            new Product {Id = 1, Name = "Iphone 13", Desc = "Telefon", Hit = 5 },
            new Product {Id = 2, Name = "Iphone 12", Desc = "Telefon", Hit = 6 },
            new Product {Id = 3, Name = "Iphone 11", Desc = "Telefon", Hit = 7 },
            new Product {Id = 4, Name = "Iphone X", Desc = "Telefon", Hit = 8 },
            new Product {Id = 5, Name = "Iphone 8", Desc = "Telefon", Hit = 10 },
            new Product {Id = 6, Name = "Xiomi", Desc = "Telefon", Hit = 500 },
        };


        public List<Product> Getall()
        {
            return products;
        }

        public Product GetById(int id)
        {
            return products.FirstOrDefault(x=>x.Id == id);
        }

      
    }
}
