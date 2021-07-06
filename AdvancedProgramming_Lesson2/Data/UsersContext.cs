using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdvancedProgramming_Lesson2.Models;

namespace AdvancedProgramming_Lesson2.Data
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options)
          : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
    }

}