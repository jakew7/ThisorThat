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
        public DbSet<ListIt> Lists { get; set; }
        public DbSet<Item> Items { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
