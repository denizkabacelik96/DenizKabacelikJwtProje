using DenizKabacelik.JwtProje.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKabacelik.JwtProje.Entities.Dtos.AppUserDtos
{
   public  class AppUserLoginDto:IDto
    {

        public string Username { get; set; }
        public string Password { get; set; }
    }
}
