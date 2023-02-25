using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models.Entity
{
    public class Role
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
