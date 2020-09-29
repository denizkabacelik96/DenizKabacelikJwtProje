using DenizKabacelik.JwtProje.Bussiness.Concrete;
using DenizKabacelik.JwtProje.Bussiness.Interfaces;
using DenizKabacelik.JwtProje.DataAccess.Interfaces;
using DenizKabacelik.JwtProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace DenizKabacelik.JwtProje.Bussiness.Concrete
{
    public class AppUserManager:GenericManager<AppUser>,IAppUserService
    {
        public AppUserManager(IGenericDal<AppUser> genericDal):base(genericDal)
        {

        }
    }
}
 