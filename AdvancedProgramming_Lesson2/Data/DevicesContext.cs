using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvancedProgramming_Lesson2.Models;
namespace AdvancedProgramming_Lesson2.Data
{
    public class DevicesContext : DbContext
    {
            public DevicesContext (DbContextOptions<DevicesContext> options)
                : base(options)
        {

        }
        public DbSet<Devices> Device { get; set; }
    }
}
