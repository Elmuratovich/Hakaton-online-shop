using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.Entity
{
    public class Comment
    {
        [Key]
        public int id { get; set; }
        public string description { get; set; }
        public int user_id { get; set; }
        public int product_id { get; set; }
        public DateTime record_time_stamp { get; set; }
    }
}
