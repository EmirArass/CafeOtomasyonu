using CafeOtomasyon.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Validations
{
    public class MasaHareketleriValidator:AbstractValidator<MasaHareketleri>
    {
        public MasaHareketleriValidator()
        {
            RuleFor(p => p.SatisKodu).NotEmpty().WithMessage("Satı Kodu alanı boş geçilemez.");
            //RuleFor(p => p.SatisKodu).Length(12).WithMessage("Satış Kodu 12 karakterden oluşmalıdır");
            RuleFor(p => p.Miktari).NotEmpty().WithMessage("Miktar alanı boş geçilemez.");
            RuleFor(p => p.Miktari).GreaterThan(0).WithMessage("Miktar 1'den küçük olamaz");

            RuleFor(p => p.BirimFiyati).NotEmpty().WithMessage("Birim Fiyatı alanı boş geçilemez");
            RuleFor(p => p.BirimFiyati).LessThanOrEqualTo(150).WithMessage("Birim Fiyatı en fazla 150 olabilir");
        }
    }
}
