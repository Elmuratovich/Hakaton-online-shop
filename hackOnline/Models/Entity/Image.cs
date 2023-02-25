using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.Entity
{
    public class Image
    {
        [Key]
        public int id { get; set; }
        public int product_id { get; set; }
        public string file_name { get; set; }
        public string file_path { get; set;  }
        public string file_type { get; set;  }
        public DateTime record_time_stamp { get; set; }
    }
}
