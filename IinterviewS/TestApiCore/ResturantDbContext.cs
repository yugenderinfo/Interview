using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
namespace TestApiCore
{
    public class ResturantDbContext:DbContext
    {
        public ResturantDbContext(DbContextOptions<ResturantDbContext> options)
        : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
