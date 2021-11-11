using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShiSida_Engineering.Models;

namespace ShiSida_Engineering.Data
{
    public class ShiSida_EngineeringContext : DbContext
    {
        public ShiSida_EngineeringContext (DbContextOptions<ShiSida_EngineeringContext> options)
            : base(options)
        {
        }

        public DbSet<ShiSida_Engineering.Models.PriceList> PriceList { get; set; }
    }
}
