using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hackOnline.Models.Entity
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public DateTime RecordTimeStamp { get; set; }
    }
}
