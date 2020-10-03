using DenizKabacelik.JwtProje.Entities.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKabacelik.JwtProje.Bussiness.ValidationRules
{
    public class AppUserLoginDtovalidator:AbstractValidator<AppUserLoginDto>
    {

        public AppUserLoginDtovalidator()
        {
            RuleFor(I => I.Username).NotEmpty().WithMessage("Kullanıcı adı boş  geçilemez");
            RuleFor(I => I.Password).NotEmpty().WithMessage("Şifre boş  geçilemez");
        }
    }
}
