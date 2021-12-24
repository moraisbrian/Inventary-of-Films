using System.Security.Cryptography;
using System.Text;
using AutoMapper;
using Inventary.Application.DTOs;
using Inventary.Application.Interfaces;
using Inventary.Domain.Entities;
using Inventary.Domain.Interfaces;

namespace Inventary.Application.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;
    private readonly IMapper _mapper;

    public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
    {
        _usuarioRepository = usuarioRepository;
        _mapper = mapper;
    }

    public async Task<UsuarioDto?> Autenticar(UsuarioDto usuarioDto)
    {
        var hash = GerarHash(usuarioDto.Senha!);
        var usuario = _mapper.Map<Usuario>(usuarioDto);
        usuario.Senha = hash;
        
        usuario = await _usuarioRepository.Autenticar(usuario);

        return _mapper.Map<UsuarioDto>(usuario);
    }

    private string GerarHash(string senha)
    {
        var valorCodificado = Encoding.UTF8.GetBytes(senha);
        var sha256 = SHA256.Create();
        var hashValue = sha256.ComputeHash(valorCodificado);
        var builder = new StringBuilder();

        foreach (var valor in hashValue)
        {
            builder.Append(valor.ToString("X2"));
        }

        return builder.ToString();
    }
}