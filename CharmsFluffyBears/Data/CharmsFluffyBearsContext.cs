using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CharmsFluffyBears.Models;

namespace CharmsFluffyBears.Data
{
    public class CharmsFluffyBearsContext : DbContext
    {
        public CharmsFluffyBearsContext (DbContextOptions<CharmsFluffyBearsContext> options)
            : base(options)
        {
        }

        public DbSet<CharmsFluffyBears.Models.FluffyBears> FluffyBears { get; set; }
    }
}
