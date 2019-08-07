using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkBegins.Models {
    class AppDbContext : DbContext {

        public AppDbContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            var connStr = "server=localhost\\sqlexpress;database=AppEfDb;trusted_connection=true;";
            builder.UseLazyLoadingProxies();
            builder.UseSqlServer(connStr);
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Major> majors { get; set; }

    }
}
