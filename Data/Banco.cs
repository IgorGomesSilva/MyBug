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

    }
}
