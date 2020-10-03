using DenizKabacelik.JwtProje.Bussiness.Concrete;
using DenizKabacelik.JwtProje.Bussiness.Interfaces;
using DenizKabacelik.JwtProje.Bussiness.ValidationRules.FluentValidation;
using DenizKabacelik.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using DenizKabacelik.JwtProje.DataAccess.Interfaces;
using DenizKabacelik.JwtProje.Entities.Dtos.ProductDtos;
using DenizKabacelik.JwtProje.Entities.Interfaces;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using DenizKabacelik.JwtProje.Bussiness.ValidationRules.FluentValidation;
using DenizKabacelik.JwtProje.Entities.Dtos.ProductDtos;
using DenizKabacelik.JwtProje.Entities.Dtos.AppUserDtos;
using DenizKabacelik.JwtProje.Bussiness.ValidationRules;

namespace DenizKabacelik.JwtProje.Bussiness.Containers.MicrosoftIoc
{
   public static  class CustomExtention
    {
       

        public static void AddDependecies(this IServiceCollection services) {

            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped<IProductDal, EfProductRepository>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();
            services.AddScoped<IAppUserService, AppUserManager>();

            services.AddScoped<IAppRoleDal, EfAppRoleRepository>();
            services.AddScoped<IAppRoleService, AppRoleManager>();
            services.AddScoped<IAppUserRoleDal, EfAppUserRoleRepository>();
            services.AddScoped<IAppUserRoleService, AppUserRoleManager>();
            services.AddScoped<IJwtService, JwtManager>();
            services.AddTransient<IValidator<ProductAddDto>, ProductAddDtoValidator>();
            services.AddTransient<IValidator<ProductUpdateDto>, ProductUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginDtovalidator>();
        }

    }


   
}
