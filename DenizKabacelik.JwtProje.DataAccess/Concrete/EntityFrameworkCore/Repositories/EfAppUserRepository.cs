using DenizKabacelik.JwtProje.DataAccess.Interfaces;
using DenizKabacelik.JwtProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKabacelik.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
     public class EfAppUserRepository:EfGenericRepository<AppUser>,IAppUserDal
    {
    }
}
