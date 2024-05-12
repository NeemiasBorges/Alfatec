using System.ComponentModel.DataAnnotations;

namespace Alfatec.Domain.Entities
{
    public class Endereco
    {
        public Endereco()
        {
        }

        public Endereco(int id, string? rua, string? cidade, string? numero, string? bairro, string? cEP, string? complemento, string? uF, string? observacoes, int tipoObjeto, string? latitude, string? longitude)
        {
            Id = id;
            Rua = rua;
            Cidade = cidade;
            Numero = numero;
            Bairro = bairro;
            CEP = cEP;
            Complemento = complemento;
            UF = uF;
            Observacoes = observacoes;
            TipoObjeto = tipoObjeto;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public int      Id           { get; private set; }
        public string?   Rua          { get; private set; }
        public string?   Cidade       { get; private set; }
        public string?   Numero       { get; private set; }
        public string?   Bairro       { get; private set; }
        public string?   CEP          { get; private set; }
        public string? Complemento { get; private set; } = "";
        public string?   UF           { get; private set; }
        public string? Observacoes { get; private set; } = "";
        public int TipoObjeto { get; private set; } = 8;
        public string?   latitude     { get; private set; }
        public string?   longitude    { get; private set; }
        public string?  Nome { get; set; }
    }
}



