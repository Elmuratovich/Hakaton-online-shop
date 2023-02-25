using Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.ViewModel
{
    public class GetAllProductsViewModel
    {
        public IList<Category> Categories { get; set; }
        public IList<Product> Products { get; set; }
        public IList<CommentProduct> CommentProducts { get; set; } = new List<CommentProduct>();
        public Product GetProduct { get; set; }
        public int userId { get; set; }
        public int productId { get; set; }
        public string role { get; set; }
        public IList<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
    }

    public class CommentProduct
    {
        public int id { get; set; }
        public string description { get; set; }
        public int user_id { get; set; }
        public int product_id { get; set; }
        public string username { get; set; }
        public DateTime record_time_stamp { get; set; }
    }

    public class ProductImage
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public int stock { get; set; }
        public bool available { get; set; }
        public DateTime created { get; set; }
        public int category { get; set; }
        public string file_name { get; set; }
        public bool isImage { get; set; }
    }
}
