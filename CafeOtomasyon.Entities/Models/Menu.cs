﻿using CafeOtomasyon.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Models
{
    [Table("Menu")]
    public class Menu:IEntity
    {
        public int Id { get; set; }
        public string MenuAdi { get; set; }
        public string Aciklama { get; set; }
        public virtual ICollection<Urun> Urun { get; set; }
    }
}
