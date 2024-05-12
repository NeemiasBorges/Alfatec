namespace Alfatec.Domain.Entities
{
    public class Noticia
        {
            public int Id { get; set; }
            public string Titulo { get; set; }
            public string Subtitulo { get; set; }
            public int UsuarioId { get; set; }
            public DateTime DataHoraCriacao { get; set; }
            public string CaminhoImagem { get; set; }
    }
}
