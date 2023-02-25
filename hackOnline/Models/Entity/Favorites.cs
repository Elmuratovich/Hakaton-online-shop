using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hackOnline.Models.Entity
{
    public class Favorites
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public int productId { get; set; }
        public DateTime RecordTimeStamp { get; set; }
    }
}
