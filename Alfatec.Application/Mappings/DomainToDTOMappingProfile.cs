using Alfatec.Application.DTOs;
using Alfatec.Domain.Entities;
using AutoMapper;

namespace Alfatec.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Noticia,NoticiaDTO>().ReverseMap();
            CreateMap<Arquivo,ArquivoDTO>().ReverseMap();
            CreateMap<Autorizacao,AutorizacaoDTO>().ReverseMap();
            CreateMap<Categoria,CategoriaDTO>().ReverseMap();
            CreateMap<Comentario, ComentarioDTO>().ReverseMap();
            CreateMap<Condicoes, CondicoesDTO>().ReverseMap();
            CreateMap<CondicoesEstrada, CondicoesEstradaDTO>().ReverseMap();
            CreateMap<ConfiguracoesUsuario, ConfiguracoesUsuarioDTO>().ReverseMap();
            CreateMap<Empresa, EmpresaDTO>().ReverseMap();
            CreateMap<Endereco, EnderecoDTO>().ReverseMap();
            CreateMap<Log, LogDTO>().ReverseMap();
            CreateMap<Mensagem, MensagemDTO>().ReverseMap();
            CreateMap<MidiaProduto, MidiaProdutoDTO>().ReverseMap();
            CreateMap<MidiaUsuario, MidiaUsuarioDTO>().ReverseMap();
            CreateMap<ModeloMensagem, ModeloMensagemDTO>().ReverseMap();
            CreateMap<ModoEnvio, ModoEnvioDTO>().ReverseMap();
            CreateMap<Negociacao, NegociacaoDTO>().ReverseMap();
            CreateMap<Selo, SeloDTO>().ReverseMap();
            CreateMap<Servicos, ServicosDTO>().ReverseMap();
            CreateMap<ServicosUsuario, ServicosUsuarioDTO>().ReverseMap();
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<Veiculo, VeiculoDTO>().ReverseMap();
            CreateMap<VeiculoUsuario, VeiculoUsuarioDTO>().ReverseMap();
            CreateMap<Produto,ProdutoDTO>().ReverseMap();
        }
    }
}
