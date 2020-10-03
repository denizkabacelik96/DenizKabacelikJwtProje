using DenizKabacelik.JwtProje.Entities.Concrete;
using DenizKabacelik.JwtProje.Entities.Dtos.ProductDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKabacelik.JwtProje.Bussiness.ValidationRules.FluentValidation
{
   public  class ProductUpdateDtoValidator:AbstractValidator<ProductUpdateDto>
    {

        public ProductUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(0, int.MaxValue);
            RuleFor(I => I.Name).NotEmpty().WithMessage("Ad  alanı  boş  bırakılamaz");
        }
    }
}
