using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class CategoryServives
    {
        List<Category> categories = new()
        {
            new Category { Id = 1, Name = "Telefon" }
        };

        public List<Category> GetAllCategories()
        {
            return categories;
        }

    }
}
