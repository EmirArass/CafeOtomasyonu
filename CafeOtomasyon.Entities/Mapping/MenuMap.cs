using CafeOtomasyon.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Mapping
{
    public class MenuMap:EntityTypeConfiguration<Menu>
    {
        private DatabaseGeneratedOption? databaseGeneratedOption;

        public MenuMap()
        {
            this.ToTable("Menu");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.MenuAdi).HasColumnType("varchar").HasMaxLength(60);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(300);
        }
    }
}
