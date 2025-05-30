using CivicMap.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivicMap.Infrastructure.Db
{
    public class AppDbContext : DbContext
    {
        public DbSet<Policy> Policies => Set<Policy>();
        public DbSet<City> Cities => Set<City>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
