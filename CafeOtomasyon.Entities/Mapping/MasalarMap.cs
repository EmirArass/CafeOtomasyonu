﻿using CafeOtomasyon.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Mapping
{
    public class MasalarMap: EntityTypeConfiguration<Masalar>
    {
        public MasalarMap()
        {
            this.ToTable("Masalar");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.MasaAdi).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(300);
            this.Property(p => p.EklenmeTarihi).HasColumnType("date");

            this.HasOptional(m => m.Kullanicilar).WithMany(m => m.masalar).HasForeignKey(m => m.KullaniciId);
        }
    }
}
