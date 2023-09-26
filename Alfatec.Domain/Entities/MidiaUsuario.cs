using Alfatec.Domain.Interfaces;

namespace Alfatec.Domain.Entities
{
    public class MidiaUsuario
    {
        public MidiaUsuario(int id, string nome, string tipoArquivo, string diretorio, int idusuario)
        {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            TipoArquivo = tipoArquivo ?? throw new ArgumentNullException(nameof(tipoArquivo));
            Diretorio = diretorio ?? throw new ArgumentNullException(nameof(diretorio));
            idUsuario = idusuario;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string TipoArquivo { get; private set; }
        public string Diretorio { get; private set; }
        public int TipoObjeto { get; private set; } = 10;
        public int idUsuario { get; private set; }
        public Usuarios Usuario { get; set; }

    }
}
