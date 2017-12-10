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

        public DbSet<Imagem> Imagens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bug>().Property(p => p.Titulo).HasMaxLength(30);
            modelBuilder.Entity<Bug>().Property(p => p.Descricao).HasMaxLength(150);
            modelBuilder.Entity<Bug>().Property(p => p.Email).HasMaxLength(40);
            modelBuilder.Entity<Bug>().Property(p => p.Severidade).HasMaxLength(20);
            modelBuilder.Entity<Bug>().Property(p => p.Comentario).HasMaxLength(200);

            modelBuilder.Entity<Imagem>().Property(p => p.ImgCaminho).HasMaxLength(200);
            modelBuilder.Entity<Imagem>().Property(p => p.ImagName).HasMaxLength(120);
        }

    }
}
