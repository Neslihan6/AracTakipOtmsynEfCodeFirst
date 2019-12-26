using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
        public class AracDbContext : DbContext
            public AracDbContext() : base("cstr")
            {

            }

            public DbSet<AracTakip> Araclar { get; set; }
            public DbSet<CihazMarka> Markalar { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                //Fluent Api
                modelBuilder.Entity<AracTakip>().ToTable("tblAraclar");

                modelBuilder.Entity<AracTakip>().Property(o => o.Ad).HasMaxLength(50).IsRequired().HasColumnType("varchar");
                
            }

        }
    }
}
