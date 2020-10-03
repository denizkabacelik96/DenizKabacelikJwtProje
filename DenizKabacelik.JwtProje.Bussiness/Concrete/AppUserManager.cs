using DenizKabacelik.JwtProje.Bussiness.Interfaces;
using DenizKabacelik.JwtProje.DataAccess.Interfaces;
using DenizKabacelik.JwtProje.Entities.Concrete;
using DenizKabacelik.JwtProje.Entities.Dtos.AppUserDtos;
using System.Threading.Tasks;

namespace DenizKabacelik.JwtProje.Bussiness.Concrete
{
    public class AppUserManager:GenericManager<AppUser>,IAppUserService
    {

        private readonly IAppUserDal _appUserDal;
        public AppUserManager(IGenericDal<AppUser> genericDal, IAppUserDal appUserDal) :base(genericDal)
        {
            _appUserDal = appUserDal;
        }

        public async Task<bool> CheckPassword(AppUserLoginDto appUserLoginDto)
        {
            var appUser = await _appUserDal.GetByFilter(I => I.Username == appUserLoginDto.Username);
            return appUser.Password == appUserLoginDto.Password ? true : false;
            



            


        }

        public  async Task<AppUser> FindByUserName(string userName)
        {
            return await _appUserDal.GetByFilter(I => I.Username == userName);
        }
    }
}
 