using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace LoginService.Utils
{
    public static class TokenUtil
    {
        public static string GenerateTokenJWT()
        {
            var config = Startup.StaticConfig;

            var issuer = config["Jwt:Issuer"];
            var audience = config["Jwt:Audience"];
            var expiry = DateTime.Now.AddMinutes(120);
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(issuer: issuer, audience: audience, expires: expiry, signingCredentials: credentials);
            var tokenHandler = new JwtSecurityTokenHandler();
            var stringToken = tokenHandler.WriteToken(token);
            return stringToken;
        }
    }
}
