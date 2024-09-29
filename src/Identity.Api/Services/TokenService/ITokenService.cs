using System.IdentityModel.Tokens.Jwt;

namespace Identity.Api.Services.TokenService;

public interface ITokenService
{
    string GenerateAccessToken(IEnumerable<Claim> claims);
    string GenerateRefreshToken();
    JwtSecurityToken DecodeToken(string accessToken);
}