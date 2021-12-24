using Inventary.Domain.Entities;

namespace Inventary.Domain.Interfaces;

public interface IUsuarioRepository
{
    Task<Usuario?> Autenticar(Usuario usuario);
}