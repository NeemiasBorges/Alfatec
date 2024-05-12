using Alfatec.Application.DTOs;
using Alfatec.Application.Enum;
using Alfatec.Application.Services.Interfaces;
using Alfatec.Domain.Entities;
using Alfatec.Infra.Data.Repositories.Interface;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace Alfatec.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository        _repository;
        private readonly IModeloMensagemRepository _modeloRepository;
        private readonly IMensagensService         _mensagemService;
        private readonly int                       _idModeloPrimeiroAcesso;
        private readonly string                    _linkDeAcesso;
        private readonly IMapper                   _mapper;
        public UsuarioService(IMapper mapper, 
            IUsuarioRepository userRepo,
            IModeloMensagemRepository modeloMensagem,
            IMensagensService mensagensService,
            IConfiguration configuration)
        {
            _idModeloPrimeiroAcesso = int.Parse(configuration["ModeloPrimeiroAcesso"]);
            _linkDeAcesso           = configuration["LinkDeAcesso"];
            _repository             = userRepo;
            _mapper                 = mapper;
            _modeloRepository       = modeloMensagem;
            _mensagemService        = mensagensService;
        }
        public async Task Add(UsuarioDTO obj)
        {
            try
            {
                obj.Senha = await GeneratePassword();
                var entittyOBJ = _mapper.Map<Usuario>(obj);
                entittyOBJ.Nome = $"{obj.Nome} {obj.Sobrenome}";
                await _repository.CriarUsuario(entittyOBJ);
                await addInSendMessage(
                    MessageTypes.CriaUsuario,
                    obj
                    );

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task addInSendMessage(MessageTypes messageType, UsuarioDTO usuario)
        {
            MensagemDTO mensagem = new();
            
            var modeloMensagem       = await _modeloRepository.GetModeloById(_idModeloPrimeiroAcesso);
            mensagem.IdModelo        = _idModeloPrimeiroAcesso;
            mensagem.StatusEnvio     = "P";
            mensagem.Destinatario    = $"{usuario.DDD}{usuario.Telefone}";
            mensagem.Remetente       = "Bot";
            mensagem.DataEnvio       = DateTime.Now;
            mensagem.MensagemTexto   = modeloMensagem.TextoModelo;

            mensagem.MensagemTexto = mensagem.MensagemTexto.Replace("{{NomeUsuario}}", usuario.Nome);
            mensagem.MensagemTexto = mensagem.MensagemTexto.Replace("{{Email}}", usuario.Email);
            mensagem.MensagemTexto = mensagem.MensagemTexto.Replace("{{SenhaTemp}}", $"*{usuario.Senha}*");
            mensagem.MensagemTexto = mensagem.MensagemTexto.Replace("{{Link de acesso}}", _linkDeAcesso);

            string tipoUser = "";
            switch (usuario.Tipo)
            {
                case "PRS":
                    tipoUser = "Prestador de Servico";
                    break;
                case "MRC":
                    tipoUser = "Mercado ou Distribuidor";
                    break;
                case "AGR":
                    tipoUser = "Produtor Rural";
                    break;
                default:
                    tipoUser = "Tipo de usuário desconhecido";
                    break;
            }

            mensagem.MensagemTexto = mensagem.MensagemTexto.Replace("[Tipo de usuário]", tipoUser);

            await _mensagemService.Add(mensagem);
        }

        public async Task<string> GeneratePassword()
        {
            DateTime now = DateTime.Now;
            string password = $"{now.Day}{now.Hour}{now.Minute}";
            password += GenerateRandomChars(2); // Adicionando 2 caracteres aleatórios
            password = ShuffleString(password);

            if (password.Length < 6)
            {
                int diff = 6 - password.Length;
                password += GenerateRandomChars(diff);
            }
            else if (password.Length > 6)
            {
                password = password.Substring(0, 6);
            }

            return password;
        }

        private string GenerateRandomChars(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private string ShuffleString(string str)
        {
            char[] array = str.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                char value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }

        public async Task<UsuarioDTO> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UsuarioDTO>> list()
        {
            throw new NotImplementedException();
        }

        public async Task<UsuarioDTO> login(string emailorphone, string password)
        {
            try
            {
                var user = await _repository.AutenticarUsuario(emailorphone, password);
                var entittyOBJ = _mapper.Map<UsuarioDTO>(user);
                return entittyOBJ;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<bool> logout()
        {
            throw new NotImplementedException();
        }

        public async Task Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
