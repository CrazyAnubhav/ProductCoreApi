using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProductCoreApi.Models
{
    public class ProductCoreApiContext : DbContext
    {
        public ProductCoreApiContext (DbContextOptions<ProductCoreApiContext> options)
            : base(options)
        {
        }

        public DbSet<ProductCoreApi.Models.Product> Product { get; set; }
    }
}
