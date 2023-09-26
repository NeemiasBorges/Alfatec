using Alfatec.Domain.Interfaces;

namespace Alfatec.Domain.Entities
{
    public class Autorizacoes
    {
        public Autorizacoes(int id,int Idusuario, string bloqueado, string editarProduto, string inserirProduto, string desativarProduto, string editarInformacoesEmpresa, string editarInformacoesUsuario, string acessoModuloContato)
        {
            Id = id;
            IdUsuario = Idusuario;
            Bloqueado = bloqueado ?? throw new ArgumentNullException(nameof(bloqueado));
            EditarProduto = editarProduto ?? throw new ArgumentNullException(nameof(editarProduto));
            InserirProduto = inserirProduto ?? throw new ArgumentNullException(nameof(inserirProduto));
            DesativarProduto = desativarProduto ?? throw new ArgumentNullException(nameof(desativarProduto));
            EditarInformacoesEmpresa = editarInformacoesEmpresa ?? throw new ArgumentNullException(nameof(editarInformacoesEmpresa));
            EditarInformacoesUsuario = editarInformacoesUsuario ?? throw new ArgumentNullException(nameof(editarInformacoesUsuario));
            AcessoModuloContato = acessoModuloContato ?? throw new ArgumentNullException(nameof(acessoModuloContato));
        }

        public int Id { get; private set;}
        public int IdUsuario { get; private set; }
        public string Bloqueado { get; private set; }
        public string EditarProduto { get; private set; }
        public string InserirProduto { get; private set; }
        public string DesativarProduto { get; private set; }
        public string EditarInformacoesEmpresa { get; private set; }
        public string EditarInformacoesUsuario { get; private set; }
        public string AcessoModuloContato { get; private set; }
        public Usuarios Usuario { get; set; }
        public int TipoObjeto { get; private set; } = 2;


    }
}
