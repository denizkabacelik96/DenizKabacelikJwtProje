using DenizKabacelik.JwtProje.Bussiness.Interfaces;
using DenizKabacelik.JwtProje.DataAccess.Interfaces;
using DenizKabacelik.JwtProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKabacelik.JwtProje.Bussiness.Concrete
{
   public  class AppRoleManager:GenericManager<AppRole>,IAppRoleService
    {
        public AppRoleManager(IGenericDal<AppRole> genericDal):base(genericDal)
        {

        }



    }


}
