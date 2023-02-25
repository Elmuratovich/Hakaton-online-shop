using Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.ViewModel
{
    public class EditProductViewModel
    {
        public IList<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}
