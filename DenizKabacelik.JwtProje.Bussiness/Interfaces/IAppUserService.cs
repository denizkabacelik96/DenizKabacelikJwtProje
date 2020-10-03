using DenizKabacelik.JwtProje.Entities.Concrete;
using DenizKabacelik.JwtProje.Entities.Dtos.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DenizKabacelik.JwtProje.Bussiness.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        Task<AppUser> FindByUserName(string userName);
        Task<bool> CheckPassword(AppUserLoginDto appUserLoginDto);


    }
}
