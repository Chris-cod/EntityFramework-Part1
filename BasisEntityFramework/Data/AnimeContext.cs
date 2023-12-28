using BasisEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasisEntityFramework.Data
{
    public class AnimeContext : DbContext
    {
        public DbSet<Anime> Animes { get; set; } = null!;
        public DbSet<Staffel> Staffels { get; set; } = null!;
        public DbSet<Folge> Folges { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=(localdb)\MSSQLLocalDB;Initial Catalog=VoirAnime;Integrated Security=true");
        }
    }
}
