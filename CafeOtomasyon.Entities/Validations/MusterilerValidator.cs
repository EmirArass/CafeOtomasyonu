using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyon.Entities.Models;
using FluentValidation;

namespace CafeOtomasyon.Entities.Validations
{
    public class MusterilerValidator:AbstractValidator<Musteriler>
    {
        public MusterilerValidator()
        {
            RuleFor(p => p.AdiSoyadi).NotEmpty().WithMessage("Adı Soyadı alanı boş geçilemez.");
            RuleFor(p => p.Telefon).NotEmpty().WithMessage("Telefon alanı boş geçilemez."); 
        }
    }
}
