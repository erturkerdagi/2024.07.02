using LayerEntity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerDataAccess
{
    public class DbConnect : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=BlogProjesi;Integrated Security=True; TrustServerCertificate=True");
        }

        public DbSet<Hakkinda> Hakkinda { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Mesaj> Mesaj { get; set; }
        public DbSet<Yazar> Yazar { get; set; }
        public DbSet<Yazi> Yazi { get; set; }
        public DbSet<Yorum> Yorum { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<Bulten> Bulten { get; set; }
    }
}