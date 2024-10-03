using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;

namespace Identity.Api.Services.TokenService;

public class TokenService : ITokenService
{
    private readonly JwtConfig _jwtConfig;
    private readonly ILogger<TokenService> _logger;

    public TokenService(ILogger<TokenService> logger, IOptions<JwtConfig> jwtConfigOptions)
    {
        _logger = logger;
        _jwtConfig = jwtConfigOptions.Value;
    }

    public string GenerateAccessToken(IEnumerable<Claim> claims)
    {
        var signKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.SecretKey));
        var signingCredentials = new SigningCredentials(signKey, _jwtConfig.Algorithm);
        var optionsHeader = new Dictionary<string, string>
        {
            ["alg"] = signingCredentials.Algorithm,
            ["typ"] = JwtConstants.TokenType
        };
        var header = new JwtHeader(signingCredentials, optionsHeader);

        var payload = new JwtPayload(
            issuer: _jwtConfig.Issuer,
            audience: _jwtConfig.Audience,
            expires: DateTime.UtcNow.AddDays(Convert.ToInt64(_jwtConfig.Expires)),
            notBefore: DateTime.UtcNow,
            claims: claims);

        var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        var token = jwtSecurityTokenHandler.WriteToken(new JwtSecurityToken(header, payload));
        return token;
    }

    public string GenerateRefreshToken()
    {
        return Convert.ToBase64String(Guid.NewGuid().ToByteArray());
    }
}