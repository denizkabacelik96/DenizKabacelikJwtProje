using DenizKabacelik.JwtProje.Entities.Dtos.ProductDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKabacelik.JwtProje.Bussiness.ValidationRules.FluentValidation
{
    public class ProductAddDtoValidator:AbstractValidator<ProductAddDto>
    {


        public ProductAddDtoValidator()
        {
            RuleFor(I => I.Name).NotEmpty().WithMessage("Ad alanı  boş  geçilemez");
        }
    }
}
