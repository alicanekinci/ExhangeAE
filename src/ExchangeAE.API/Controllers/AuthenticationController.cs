using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ExchangeAE.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace ExchangeAE.API.Controllers;

public class AuthenticationController : BaseApiController
{
    private readonly JwtSettings _jwtSettings;

    public AuthenticationController(JwtSettings jwtSettings)
    {
        _jwtSettings = jwtSettings;
    }

    [AllowAnonymous]
    [HttpPost("Generate Toekn")]
    public string GenerateToken()
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_jwtSettings.Secret);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                    new Claim(ClaimTypes.Name, "Admin")
            }),
            Expires = DateTime.UtcNow.AddMinutes(_jwtSettings.AccessTokenExpiration),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);
        var tokenString = tokenHandler.WriteToken(token);

        return tokenString;
    }
}