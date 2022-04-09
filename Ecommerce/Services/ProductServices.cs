using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ecommerce.Services
{
    public class ProductServices
    {
        List<Product> products = new()
        {
            new Product
            {
                Id = 1,
                Name = "1 Super temirli ev.",
                Kateqoriya = "Ev",
                Kupca = true,
                Sahe = 125.5M,
                OtaqSayi = 5,
                BaxisSayi = 200,
                Price = 100000,
                PublishDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            },
            new Product
            {
                Id = 2,
                Name = "2 Super temirli ev.",
                Kateqoriya = "Ev",
                Kupca = true,
                Sahe = 125.5M,
                OtaqSayi = 7,
                BaxisSayi = 200,
                Price = 200000,
                PublishDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            },
            new Product
            {
                Id = 3,
                Name = "3 Super temirli ev.",
                Kateqoriya = "Ev",
                Kupca = true,
                Sahe = 125.5M,
                OtaqSayi = 5,
                BaxisSayi = 200,
                Price = 300000,
                PublishDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            },
            new Product
            {
                Id = 4,
                Name = "4 Super temirli ev.",
                Kateqoriya = "Ev",
                Kupca = true,
                Sahe = 125.5M,
                OtaqSayi = 5,
                BaxisSayi = 200,
                Price = 400000,
                PublishDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            },
            new Product
            {
                Id = 5,
                Name = "5 Super temirli ev.",
                Kateqoriya = "Ev",
                Kupca = true,
                Sahe = 125.5M,
                OtaqSayi = 5,
                BaxisSayi = 200,
                Price = 700000,
                PublishDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            }
        };


        public List<Product> GetHamisiGetir()
        {
            return products;
        }

        public Product GetBiriniGetir(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            product.BaxisSayi += 1;
            return product;
        }

        public List<Product> GetFilterEleGetir(int? qiymet=0)
        {


            return products.Where(x=>x.Price >= qiymet).ToList();
        }

    }
}
