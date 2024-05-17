using E_Commerce.DAL.Settings;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace E_Commerce.BL.Authentication;

public class JwtProvider : IJwtProvider
{
    private readonly JwtSettings _jwtSettings;

    public JwtProvider(IOptions<JwtSettings> options)
    {
        _jwtSettings = options.Value;
    }

    public string GenerateJwtToken(string email, string role)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Email, email),
            new Claim(ClaimTypes.Role, role)
        };
        var duration = DateTime.Now.AddMinutes(_jwtSettings.AccessTokenExpiration);
        var token = new JwtSecurityToken(_jwtSettings.Issuer,
                                         _jwtSettings.Audience,
                                         claims,
                                         expires: duration,
                                         signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}