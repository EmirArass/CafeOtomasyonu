using CafeOtomasyon.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Validations
{
    public class UrunValidator:AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(p => p.UrunKodu).NotEmpty().WithMessage("Ürün Kodu alanı boş geçilemez.");
            RuleFor(p => p.UrunAdi).NotEmpty().WithMessage("Ürün Adı alanı boş geçilemez.");

            RuleFor(p => p.BirimFiyat1).NotEmpty().WithMessage("Birim Fiyatı1 alanı boş geçilemez");
            RuleFor(p => p.BirimFiyat2).NotEmpty().WithMessage("Birim Fiyatı2 alanı boş geçilemez");
            RuleFor(p => p.BirimFiyat3).NotEmpty().WithMessage("Birim Fiyatı3 alanı boş geçilemez");

        }
    }
}
