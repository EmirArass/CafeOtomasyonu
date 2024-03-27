using CafeOtomasyon.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Entities.Validations
{
    public class KullanicilarValidator:AbstractValidator<Kullanicilar>
    {
        public KullanicilarValidator()
        {
            RuleFor(p => p.AdSoyad).NotEmpty().WithMessage("Ad Soyad alanı boş geçilemez.");
            RuleFor(p => p.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı Adı alanı boş geçilemez.");
            RuleFor(p => p.KullaniciAdi).MinimumLength(5).WithMessage("Kullanıcı Adı alanı en az 5 karakter olmalıdır.");
            RuleFor(p => p.KullaniciAdi).MaximumLength(35).WithMessage("Kullanıcı Adı alanı en fazla 35 karakter olmalıdır.");
            RuleFor(p => p.Parola).NotEmpty().WithMessage("Parola alanı boş geçilemez.");
            RuleFor(p => p.Parola).MinimumLength(5).WithMessage("Parola en az 5 karakter olmalıdır.");
            RuleFor(p => p.Parola).MaximumLength(10).WithMessage("Parola en fazla 10 karakter olmalıdır.");
            RuleFor(p => p.Telefon).NotEmpty().WithMessage("Telefon alanı boş geçilemez.");
            RuleFor(p => p.Email).NotEmpty().WithMessage("E-Mail alanı boş geçilemez.");

            RuleFor(p => p.Email).EmailAddress().WithMessage("Yanlış E-Mail adres formatı.");
        }
    }
}
