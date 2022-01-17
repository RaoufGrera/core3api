using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using core3api.Enums;
using core3api.Services;
using core3api.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using SystemData;
using SystemData.Models;
using System.IO;
using System.Net.Http.Headers;
using HeyRed.Mime;

namespace core3api.Controllers.v1
{
    [Route("v1/[controller]")]
    public class AuthController : ControllerBase
    {
        public IAuthService _authService;
        protected SystemContext _context;
         protected UserManager<AppUser> mUserManager;


        public AuthController(SystemContext context,
            UserManager<AppUser> userManager,

            IAuthService authService
 
           )
        {
            _authService = authService;
            _context = context;
            mUserManager = userManager;

        }
     

        [AllowAnonymous]
        [HttpPost("facebookAuth")]
        public  IActionResult  FacebookAuth([FromBody] string accessToken)
        {
            var user =  _authService.FacebookAuthFunc(accessToken);

            if (user.Result == null)
                return BadRequest(new { message = "خطاء اثناء تسجيل الدخول" });

            return Ok(user.Result);

        }
        [HttpPost("login")]
        public async Task<ActionResult<VUser>> Login()
        {
            var user = await mUserManager.Users
                .SingleOrDefaultAsync(x => x.UserName == "sara");

            if (user == null) return Unauthorized("Invalid username");


            var result = _authService.CreateToken(user);


            return Ok(result.Result);
        }

        [AllowAnonymous]
        [HttpPost("googleAuth")]
        public IActionResult GoogleAuth([FromBody] string accessToken)
        {
            var user = _authService.GmailAuthFunc(accessToken);
            if (user.Result == null)
                return BadRequest(new { message = "خطاء اثناء تسجيل الدخول" });

            return Ok(user.Result);

        }

        [HttpGet("users")]
        public IEnumerable GetUsers()
        {
            return _context.AppUser;
        }


        [Authorize]
        [HttpGet("Test")]
        public IActionResult Test()
        {
            var userName = User.Identity.Name;
            var OfficeId = ((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(x => x.Type == "OfficeId").Value;

            return Ok($"Super secret content, I hope you've got clearance for this {userName}..OfficeId: .{OfficeId}");
        }





    }
}