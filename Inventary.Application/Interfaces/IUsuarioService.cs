using Inventary.Application.DTOs;

namespace Inventary.Application.Interfaces;

public interface IUsuarioService
{
    Task<UsuarioDto?> Autenticar(UsuarioDto usuarioDto);
}