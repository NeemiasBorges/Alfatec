using Alfatec.Domain.Entities;

namespace Alfatec.Infra.Data.Repositories.Interface
{
    public interface IUsuarioRepository
    {
        Task CriarUsuario(Usuario novoUsuario);
        Task AtualizarUsuario(Usuario usuárioAtualizado);
        Task<Usuario> BuscarUsuarioPorID(int idUsuario);
        Task<Usuario> BuscarUsuarioPorEmail(string emailUsuario);
        Task<Usuario> AutenticarUsuario(string email, string senha);
        Task<List<Usuario>> ListarTodosUsuarios();
        Task RemoverUsuario(int idUsuario);
        Task AlterarSenha(int idUsuario, string novaSenha);
        Task<dynamic> VerificarPermissoes(int idUsuario);
    }
}
