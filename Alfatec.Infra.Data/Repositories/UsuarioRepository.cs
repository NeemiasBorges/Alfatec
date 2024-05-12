using Alfatec.Domain.Entities;
using Alfatec.Infra.Data.Context;
using Alfatec.Infra.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Alfatec.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        ApplicationDbContext _context;
        public UsuarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AlterarSenha(int idUsuario, string novaSenha)
        {
            throw new NotImplementedException();
        }

        public async Task AtualizarUsuario(Usuario usuárioAtualizado)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> AutenticarUsuario(string emailorphone, string senha)
        {
            try
            {
                var user = await _context.Usuario.FirstOrDefaultAsync(u => u.Email == emailorphone || u.Telefone == emailorphone);
                if (user != null)
                {
                    if (user != null)
                    {
                        if (user.Senha == senha)
                        {
                            return new Usuario
                            {
                                Id = user.Id,
                                Nome = user.Nome,
                                Email = user.Email
                            };
                        }
                    }
                }

                throw new Exception("Usuário ou senha incorretos");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Usuario> BuscarUsuarioPorEmail(string emailUsuario)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> BuscarUsuarioPorID(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public async Task CriarUsuario(Usuario novoUsuario)
        {
            await _context.Usuario.AddAsync(novoUsuario);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Usuario>> ListarTodosUsuarios()
        {
            throw new NotImplementedException();
        }

        public async Task RemoverUsuario(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public async Task<dynamic> VerificarPermissoes(int idUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
