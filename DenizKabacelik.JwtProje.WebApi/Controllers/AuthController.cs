using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DenizKabacelik.JwtProje.Bussiness.Interfaces;
using DenizKabacelik.JwtProje.Entities.Dtos.AppUserDtos;
using DenizKabacelik.JwtProje.WebApi.CustomFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DenizKabacelik.JwtProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IJwtService _jwtService;
        private readonly IAppUserService _appUserService;
        public AuthController(IJwtService jwtService, IAppUserService appUserService)
        {
            _jwtService = jwtService;
            _appUserService = appUserService;
        }
        [HttpGet("[action]")]
        [ValidModel]
        public async Task<IActionResult> Signin(AppUserLoginDto appUserLoginDto)
        {


            var appUser = await _appUserService.FindByUserName(appUserLoginDto.Username);
            if (appUser == null)
            {

                return BadRequest("Kullanıcı  adı veya şifre hatalı");
            }
            else
            {




                if (await _appUserService.CheckPassword(appUserLoginDto))
                {
                   var token= _jwtService.GenereateJwt(appUser, null);
                    return Created("", token);
                }
                return BadRequest("Kullanıcı adı veya şifre hatalı");
            }

        }
    }
}
