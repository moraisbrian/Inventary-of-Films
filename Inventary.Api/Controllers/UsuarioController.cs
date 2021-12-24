using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Inventary.Application.DTOs;
using Inventary.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace Inventary.Api.Controllers;

[ApiController]
[Route("api/usuarios")]
public class UsuarioController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly IUsuarioService _userService;

    public UsuarioController(IConfiguration configuration, IUsuarioService usuarioService)
    {
        _configuration = configuration;
        _userService = usuarioService;
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Autenticar([FromBody] UsuarioDto usuarioDto)
    {
        try
        {
            var autenticado = await _userService.Autenticar(usuarioDto);

            if (autenticado != null)
            {
                return Ok(GenerateToken(autenticado));
            }

            return NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    private string GenerateToken(UsuarioDto usuario)
    {
        var secret = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["Auth:Secret"]));
        var credentials = new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(ClaimTypes.Email, usuario.Email!),
            new Claim(ClaimTypes.Role, usuario.Role!)
        };

        var token = new JwtSecurityToken(
            _configuration["Auth:Issuer"],
            _configuration["Auth:Audience"],
            claims,
            expires: DateTime.UtcNow.AddMinutes(15),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}