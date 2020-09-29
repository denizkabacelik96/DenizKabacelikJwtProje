using DenizKabacelik.JwtProje.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKabacelik.JwtProje.Entities.Concrete
{
    public class AppUserRole:ITable
    {

        public int Id { get; set; }
        public int AppUserId{ get; set; }
        public AppUser AppUser { get; set; }

        public int AppRoleId { get; set; }

        public AppRole AppRole { get; set; }
    }
}
