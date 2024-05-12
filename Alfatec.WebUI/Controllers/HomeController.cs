using Alfatec.Application.Services.Interfaces;
using Alfatec.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Alfatec.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoriaService _categoriaService;
        //private readonly INoticiaService _noticiaService;
        private readonly IProdutoService _produtoService;
        private readonly IServicoService _servicosService;

        public HomeController(ILogger<HomeController> logger,
            ICategoriaService categoriaService, IProdutoService produtoService, IServicoService servicosService)
        {
            //_noticiaService = noticiaService;
            _logger = logger;
            _categoriaService = categoriaService;
            _produtoService = produtoService;
            _servicosService = servicosService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categorias         = await _categoriaService.list();
            TempData["Categorias"] = categorias.Take(4).Reverse().ToList();
            var produtos           = await _produtoService.list();
            TempData["Produtos"]   = produtos;
            //TempData["Servicos"] = await _servicosService.list();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
