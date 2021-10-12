using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ThisorThat.Models;

namespace ThisorThat.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        // database connection
        public DbSet<List> List { get; set; }
        public DbSet<Item> Item { get; set; }

        public DbSet<Post> Post { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
