using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Api.Model;
using Microsoft.IdentityModel.Tokens;

namespace Api.Service
{
    public class JwtTokenGenerator
    {
        private readonly string secretKey;
        public JwtTokenGenerator(IConfiguration configuration)
        {
            secretKey = configuration["AuthSettings:SeсretKey"];
        }
        public string GenerateJwtToken(AppUser appUser, IList<string> roles)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("FirstName", appUser.FirstName),
                    new Claim("id", appUser.Id),
                    new Claim(ClaimTypes.Email, appUser.Email),
                    new Claim(ClaimTypes.Role, string.Join(",", roles))
                }),

                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key), 
                    SecurityAlgorithms.HmacSha512Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}