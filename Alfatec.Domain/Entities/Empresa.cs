using Alfatec.Domain.Interfaces;

namespace Alfatec.Domain.Entities
{
    public class Empresa
    {
        public Empresa(int id, string nomeEmpresa, string tipo, string email, string grupo, int iDEndereco, string areaAtuacao, int vendasConcluidas, int classificacao, string cNPJ, string iE, DateTime dataCriacao)
        {
            Id = id;
            NomeEmpresa = nomeEmpresa ?? throw new ArgumentNullException(nameof(nomeEmpresa));
            Tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Grupo = grupo ?? throw new ArgumentNullException(nameof(grupo));
            IDEndereco = iDEndereco;
            AreaAtuacao = areaAtuacao ?? throw new ArgumentNullException(nameof(areaAtuacao));
            VendasConcluidas = vendasConcluidas;
            Classificacao = classificacao;
            CNPJ = cNPJ ?? throw new ArgumentNullException(nameof(cNPJ));
            IE = iE ?? throw new ArgumentNullException(nameof(iE));
            DataCriacao = dataCriacao;
        }

        public int Id  { get; private set; }
        public string NomeEmpresa  { get; private set; }
        public string Tipo  { get; private set; }
        public string Email  { get; private set; }
        public string Grupo  { get; private set; }
        public int IDEndereco { get; private set; }
        public string AreaAtuacao  { get; private set; }
        public int VendasConcluidas  { get; private set; }
        public int Classificacao  { get; private set; }
        public string CNPJ  { get; private set; }
        public string IE  { get; private set; }
        public DateTime DataCriacao  { get; private set; }
        public int TipoObjeto { get; private set; } = 3;
        public ICollection<Usuarios> Usuario { get; set; }

    }
}
