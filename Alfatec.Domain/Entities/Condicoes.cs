
namespace Alfatec.Domain.Entities
{
    public class Condicoes
    {
        public Condicoes()
        {
        }
        public Condicoes(int id, string nome)
        {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int TipoObjeto { get; private set; } = 15;

    }
}
