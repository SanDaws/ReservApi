using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using Microsoft.IdentityModel.Tokens;
using ReservApi.Models;

namespace ReservApi.Utilities;
public class JWT
{
    public static string GenerateJwtToken(Employee user)
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
            new Claim(ClaimTypes.Email,user.Email),
        };

        var jwtKey = Environment.GetEnvironmentVariable("JWTKEY");
        var jwtIssuer = Environment.GetEnvironmentVariable("JWTISSUER");
        var jwtAudience = Environment.GetEnvironmentVariable("JWTAUDIENCE");
        var jwtExpiresIn = Environment.GetEnvironmentVariable("JWTEXPIRESIN");

        // Validar que las variables existen
        if (string.IsNullOrEmpty(jwtKey) || string.IsNullOrEmpty(jwtIssuer) || string.IsNullOrEmpty(jwtAudience))
        {
            throw new InvalidOperationException("JWT configuration values are missing.");
        }

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: jwtIssuer,
            audience: jwtAudience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(jwtExpiresIn)),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

}
