using Alfatec.Domain.Entities;

namespace Alfatec.Infra.Data.Repositories.Interface
{
    public interface IEnderecoRepository
    {
        Task CriarEndereco(Endereco novoEndereco);
        Task AtualizarEndereco(Endereco enderecoAtualizado);
        Task<Endereco> BuscarEnderecoPorId(int idEndereco);
        Task<List<Endereco>> ListarTodosEnderecos();
        Task RemoverEndereco(int idEndereco);
        Task addCondicoes(Condicoes condicoes);
        Task<List<Condicoes>> listaCondicoes();
    }
}
