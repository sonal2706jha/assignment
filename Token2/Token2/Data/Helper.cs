using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Token2.Models;

namespace Token2.Data
{
    public class Helper : IHelper
    {
        public IConfiguration _config;

        public Helper(IConfiguration config)
        {
            _config = config;
        }

        private Login GetUser(string username, string password, string role)
        {
            var _context = new Models.TokenContext();
            return _context.Login.FirstOrDefault(u => u.UserName == username && u.UserPassword == password && u.UserRole == role);
        }
        public string TokenGenerate(Login login)
        {

            var user = GetUser(login.UserName, login.UserPassword, login.UserRole);
            if (user != null)
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Role,login.UserRole) // role = Admin                   
                };
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Issuer"],
                claims: claims,
                expires: DateTime.Now.AddSeconds(60),
                signingCredentials: credentials);

                return (new JwtSecurityTokenHandler().WriteToken(token));


            }
            else
            {
                return ("404 Error!!!!");
            }
        }
    }
}
