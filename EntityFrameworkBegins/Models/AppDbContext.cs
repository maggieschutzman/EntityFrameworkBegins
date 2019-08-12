using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkBegins.Models {
    public class AppDbContext : DbContext {
        AppDbContext context = null;
        public AppDbContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            var connStr = "server=localhost\\sqlexpress;database=AppEfDb;trusted_connection=true;";
            builder.UseLazyLoadingProxies();
            builder.UseSqlServer(connStr);
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Major> majors { get; set; }
        public DbSet<Course> course { get; set; }
        public DbSet<Schedule> schedule { get; set; }

        

    }
}
