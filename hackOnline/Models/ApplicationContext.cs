using hackOnline.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext()
        {

        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=hackaton;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }

        public DbSet<User> users { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<UserRole> user_roles {get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Image> images { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<Favorites> favorites { get; set; }
        public DbSet<Zakaz> zakaz { get; set; }
    }
}
