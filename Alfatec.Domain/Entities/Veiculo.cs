namespace Alfatec.Domain.Entities
{
    public class Veiculo
    {
        public Veiculo(){}

        public Veiculo(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome{ get; set; }
        public int TipoObjeto { get; private set; } = 21;
    }
}
