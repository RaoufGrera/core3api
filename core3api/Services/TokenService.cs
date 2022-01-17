using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using core3api.Interfaces;
using core3api.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SystemData.Models;
using SystemData;
namespace core3api.Services
{
    public class TokenService : ITokenService
    {
        private readonly SymmetricSecurityKey _key;
        private readonly UserManager<AppUser> _userManager;
        private readonly SystemContext _context;
        public TokenService(IConfiguration config, UserManager<AppUser> userManager,SystemContext context)
        {
            _userManager = userManager;
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["AppSettings:Secret"]));
            _context = context;
        }

        public async Task<VUser> CreateToken(AppUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.NameId, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName),
            };

            var roles = await _userManager.GetRolesAsync(user);

            claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

            var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(7),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);


            var _token  = tokenHandler.WriteToken(token);
            _context.Entry(user).Property("Token").IsModified = true;
            _context.AppUser.Update(user);
            return new VUser
            {
                Message = " „  ”ÃÌ· «·œŒÊ· »‰Ã«Õ",
                UserId = user.Id,
                Name = user.Name,
                UserName = user.UserName,
                Token = user.Token,
                Gender = user.GenderId,
                Image = user.Image

            };
          
        }
    }
}