namespace Alfatec.Domain.Entities
{
    public class Comentario
    {
        public Comentario(int id,int Idproduto, string idUsuario, DateTime data, string textoComentario)
        {
            Id = id;
            IdProduto = Idproduto;
            IdUsuario = idUsuario ?? throw new ArgumentNullException(nameof(idUsuario));
            Data = data;
            TextoComentario = textoComentario ?? throw new ArgumentNullException(nameof(textoComentario));
        }

        public int Id { get; private set;  } 
        public int IdProduto { get; private set;  } 
        public Produto Produto { get; set;  } 
        public string IdUsuario { get; private set; } 
        public DateTime Data  { get; private set; } 
        public string TextoComentario { get; private set; }
        public int TipoObjeto { get; private set; } = 5;
    }
}
