using Alfatec.Domain.Validations;

namespace Alfatec.Domain.Entities
{
    public class Comentario
    {
        public Comentario(){}
        public Comentario(int id, int usuarioQueComentou, DateTime dataComentario, string comentario)
        {
            ValidateDomain(id, usuarioQueComentou, dataComentario, comentario);

            Id = id;
            UsuarioQueComentou = usuarioQueComentou;
            DataComentario = dataComentario;
            ComentarioTexto = comentario;
        }

        private void ValidateDomain(int id, int usuarioQueComentou, DateTime dataComentario, string comentario)
        {
            DomainExceptionValidation.When(id <= 0, "ID inválido");
            DomainExceptionValidation.When(usuarioQueComentou <= 0, "Usuário que comentou é obrigatório");
            DomainExceptionValidation.When(dataComentario == default(DateTime), "Data do comentário é obrigatória");
            DomainExceptionValidation.When(string.IsNullOrEmpty(comentario), "Comentário é obrigatório");
            DomainExceptionValidation.When(comentario.Length > 25600, "Comentário excede o limite de 25600 caracteres");
        }

        public int Id { get; private set; }
        public int UsuarioQueComentou { get; private set; }
        public DateTime DataComentario { get; private set; }
        public string ComentarioTexto { get; private set; }
        public int TipoObjeto { get; private set; } = 6;
    }
}
