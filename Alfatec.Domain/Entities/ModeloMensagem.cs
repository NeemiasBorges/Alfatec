namespace Alfatec.Domain.Entities
{
    public class ModeloMensagem
    {
        public ModeloMensagem()
        { }
        public ModeloMensagem(int id,string nomemodelo,string textomodelo)
        {
            Id = id;
            nomeModelo = nomemodelo;
            TextoModelo = textomodelo;
        }
        public int    Id { get; set; }
        public string nomeModelo { get; set; }
        public string TextoModelo { get; set; }
        public int TipoObjeto { get; private set; } = 20;
    }
}
