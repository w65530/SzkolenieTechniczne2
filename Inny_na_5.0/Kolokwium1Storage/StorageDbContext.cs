using Kolokwium1Storage.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1Storage
{
    public class StorageDbContext : DbContext
    {
        public DbSet<Konkursy> Konkursy { get; set; }
        public DbSet<Uczestnicy> Uczestnicy { get; set; }
        public StorageDbContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("Kolokwium1");
            }
        }
    }
}
