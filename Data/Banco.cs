using Microsoft.EntityFrameworkCore;
using myBug.Models;

namespace myBug.Data
{
    public class Banco : DbContext
    {
         public Banco(DbContextOptions<Banco> options) : base(options)
        {

        }

        public DbSet<Bug> Bugs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bug>().Property(p => p.Titulo).HasMaxLength(30);
            modelBuilder.Entity<Bug>().Property(p => p.Descricao).HasMaxLength(50);
            modelBuilder.Entity<Bug>().Property(p => p.Email).HasMaxLength(40);
            modelBuilder.Entity<Bug>().Property(p => p.Severidade).HasMaxLength(20);
            modelBuilder.Entity<Bug>().Property(p => p.Produto).HasMaxLength(60);
        }

    }
}
