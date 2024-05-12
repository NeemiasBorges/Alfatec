namespace Alfatec.Infra.Data.Repositories.Interface
{
    public interface ITermoUsoRepository
    {
        Task GetByUsuarioAndTermoUso(int Id, int empresaId);
        //Task Update( termosUso);

        //Task List<AceiteTermosDeUsoDTO> List();
    }
}
