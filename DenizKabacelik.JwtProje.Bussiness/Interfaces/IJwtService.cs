using DenizKabacelik.JwtProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKabacelik.JwtProje.Bussiness.Interfaces
{
   public  interface IJwtService
    {

        string GenereateJwt(AppUser appUser, List<AppRole> roles);
    }
}
