using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDbSqlite.Modelos
{
    internal class FrutasModelo : DbContext
    {
        public FrutasModelo()
        {
            SQLitePCL.Batteries_V2.Init();

            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "bdUPT.db3");

            optionsBuilder
                .UseSqlite($"Filename={dbPath}");
        }

        public virtual DbSet<Fruta> Fruta { get; set; }
    }
}
