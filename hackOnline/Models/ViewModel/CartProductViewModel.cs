using Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.ViewModel
{
    public class CartProductViewModel
    {
        public IList<Product> Products { get; set; } = new List<Product>();
        public int userId { get; set; }
    }
}
