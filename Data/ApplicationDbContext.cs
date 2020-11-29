using CRUDCORE5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDCORE5.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {

        }
        public DbSet<Speaker> Speakers { get; set; }
    }
}
