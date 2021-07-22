
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testcsharp.models;

namespace testcsharp.Models.DBContext
{
    public class AppDBContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;

        public AppDBContext(DbContextOptions options) : base(options)
        {
            _options = options;
        
    }
        public DbSet<DistanDaten> DistanDatens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        
    }
}
