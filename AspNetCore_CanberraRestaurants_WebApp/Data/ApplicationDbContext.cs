using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AspNetCore_CanberraRestaurants_WebApp.Models;

namespace AspNetCore_CanberraRestaurants_WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AspNetCore_CanberraRestaurants_WebApp.Models.ReviewsForum> ReviewsForum { get; set; }
    }
}
