using Alfatec.Application.DTOs;
using Alfatec.Application.Services.Interfaces;
using Alfatec.Domain.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Alfatec.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IConfiguration _configuration;
        private string _apiKey;

        private readonly IUsuarioService _usuarioService;
        private readonly IEnderecoService _enrecoService;

        public LoginController(IConfiguration configuration, IUsuarioService usuarioService, IEnderecoService enrecoService)
        {
            _configuration = configuration;
            _apiKey = _configuration["MapApiKey"];
            _usuarioService = usuarioService;
            _enrecoService = enrecoService;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            TempData["apiKey"] = _apiKey;
            TempData["condicoes"] = await _enrecoService.listaCondicoes();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterPost(UsuarioDTO usuario)
        {
            try
            {
                await _usuarioService.Add(usuario);
                return Json(new { success = true, message = "Usuário registrado com sucesso" });
            }
            catch (Exception e)
            {
                return Json(new { success = false, message = e.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> LoginPost(string emailOrPhone, string password)
        {
            try
            {
                var usuario = await _usuarioService.login(emailOrPhone, password);

                if (usuario == null)
                {
                    return NotFound("Usuário ou senha incorretos");
                }

                //await RegistrarIdentidadeUsuario(usuario);
                TempData["usuario"] = usuario;
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Erro interno do servidor: {e.Message}");
            }
        }


        private async Task RegistrarIdentidadeUsuario(UsuarioDTO usuario)
        {
            if (usuario != null && usuario.Id != null && usuario.Email != null)
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                    new Claim(ClaimTypes.Email, usuario.Email),
                };

                var identity = new ClaimsIdentity(claims);
                var identities = new List<ClaimsIdentity>() { identity };
                HttpContext.User = new ClaimsPrincipal(identities);
            }
            else
            {
            }
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            TempData["usuario"] = null;
            await HttpContext.SignOutAsync();
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }
    }
}