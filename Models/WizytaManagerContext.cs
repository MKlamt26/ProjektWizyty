using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class WizytaManagerContext : DbContext
    {
        public WizytaManagerContext( DbContextOptions options) : base(options)
        {
        }

        public DbSet<WizytaModel> Wizyty { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
