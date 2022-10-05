using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace RecipesAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class AuthtController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("really_big_keyboard_cat"));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var issuer = "https://localhost:5001";
        var audience = "https://localhost:5001";
        var jwtValidity = DateTime.Now.AddMinutes(10);
        var token = new JwtSecurityToken(
            issuer,
            audience,
            expires: jwtValidity,
            signingCredentials: creds
        );
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
