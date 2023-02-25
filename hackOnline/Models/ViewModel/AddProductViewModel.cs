using Microsoft.AspNetCore.Http;
using Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.ViewModel
{
    public class AddProductViewModel
    {
        public Product Product { get; set; } 
        public IList<Category> Categories { get; set; }
        public List<IFormFile> Photo { get; set; } 
    }
}
