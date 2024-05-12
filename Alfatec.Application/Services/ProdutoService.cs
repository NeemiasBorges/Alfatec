using Alfatec.Application.DTOs;
using Alfatec.Application.Enum;
using Alfatec.Application.Services.Interfaces;
using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces;
using Alfatec.Infra.Data.Repositories.Interface;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace Alfatec.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;
        private readonly IMapper _mapper;
        private readonly int _idModeloNotServico;
        private readonly string _numProposta;
        private readonly IModeloMensagemRepository _modeloRepository;
        private readonly IMensagensService _mensagemService;
        public ProdutoService(IMapper mapper, IProdutoRepository produto, IMensagensService mensagensService, IModeloMensagemRepository modeloMensagem, IConfiguration configuration)
        {
            _idModeloNotServico = int.Parse(configuration["ModeloNotService"]);
            _numProposta        = configuration["numProposta"].ToString();
            _repository         = produto;
            _mapper             = mapper;
            _mensagemService    = mensagensService;
            _modeloRepository = modeloMensagem;

        }
        public async Task Add(ProdutoDTO obj)
        {

            throw new NotImplementedException();
        }

        public async Task Comprar(DateTime dataEntrega, string horarioentrega)
        {
            await addInSendMessage(
                MessageTypes.RecebeProposta,
                dataEntrega,
                horarioentrega
             );
        }

        public async Task addInSendMessage(MessageTypes messageType, DateTime dataEntrega, string horarioentrega)
        {
            MensagemDTO mensagem = new();

            var modeloMensagem = await _modeloRepository.GetModeloById(_idModeloNotServico);
            mensagem.IdModelo = _idModeloNotServico;
            mensagem.StatusEnvio = "P";
            mensagem.Destinatario = $"{_numProposta}";
            mensagem.Remetente = "Bot";
            mensagem.DataEnvio = DateTime.Now;
            mensagem.MensagemTexto = modeloMensagem.TextoModelo;


            mensagem.MensagemTexto  = mensagem.MensagemTexto.Replace("{{NomeUsuario}}", "Neemias Borges"); 
            mensagem.MensagemTexto  = mensagem.MensagemTexto.Replace("{{TipoCarga}}", "Hortaliças - Brocolis");
            mensagem.MensagemTexto  = mensagem.MensagemTexto.Replace("{{PesoCarga}}", "1 KG");
            mensagem.MensagemTexto  = mensagem.MensagemTexto.Replace("{{Endereco}}", "R. Lucas Nogueira Garcez, 640, Itapetininga - SP");
            mensagem.MensagemTexto  = mensagem.MensagemTexto.Replace("{{CondicoesVia}}", "- Pista Molhada - Terreno Irregular - Ruas Estreitas");
            mensagem.MensagemTexto  = mensagem.MensagemTexto.Replace("{{TempoAproximado}}", "2Horas");
            mensagem.MensagemTexto  = mensagem.MensagemTexto.Replace("{{ValorHora}}", "R$ 350");
            mensagem.MensagemTexto  = mensagem.MensagemTexto.Replace("{{Total}}", "R$ 700");   

            await _mensagemService.Add(mensagem);
        }

    public async Task<ProdutoDTO> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProdutoDTO>> list()
        {
            List<Produto> produtos = new List<Produto>();

            Produto produto = new Produto(
                id: 1,
                nomeProduto: "Nome do Produto",
                descricaoProduto: "Descrição do Produto",
                status: "S",
                categoria: 1,
                unidadeVenda: "Unidade",
                idFotos: 123,
                variacao: "Variação",
                dataCriacao: DateTime.Now,
                validade: DateTime.Now.AddDays(30), // Exemplo de validade 30 dias a partir de hoje
                selos: "Selo",
                classificacao: 5,
                comentarios: 10,
                comentariosAdicionais: "Comentários adicionais"
            );
            produtos.Add(produto);
            try
            {
                var produtosFromRepository = await _repository.ListarTodosProdutos(); 
                produtos.AddRange(produtosFromRepository); 
                return _mapper.Map<List<ProdutoDTO>>(produtos); 
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public async Task Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
