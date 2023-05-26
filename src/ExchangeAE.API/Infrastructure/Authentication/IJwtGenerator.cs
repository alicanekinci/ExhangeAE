using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ExchangeAE.Authentication;
    public interface IJwtGenerator
    {
        string GenerateToken(List<Claim> claims);
        JwtSecurityToken ReadToken(string token);
    }