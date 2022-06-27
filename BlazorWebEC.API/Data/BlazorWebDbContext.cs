using BlazorWebEC.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebEC.API.Data
{
    public class BlazorWebDbContext : DbContext
    {
        // Đây là lớp giao tiếp database
        public BlazorWebDbContext(DbContextOptions<BlazorWebDbContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
