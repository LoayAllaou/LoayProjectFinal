using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllaouFinalPro.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
