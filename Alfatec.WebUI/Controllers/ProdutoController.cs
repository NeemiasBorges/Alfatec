using Alfatec.Application.DTOs;
using Alfatec.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace Alfatec.WebUI.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly ISeloService _seloService;
        private readonly ICategoriaService _categoriaService;
        public ProdutoController(IProdutoService produtoService, ISeloService seloService, ICategoriaService categoriaService)
        {
            _produtoService = produtoService;
            _seloService = seloService;
            _categoriaService = categoriaService;

        }
        public IActionResult Index()
        {
            return View();
        } 
        
        public IActionResult Details()
        {
            return View();
        }
        
        public async Task<IActionResult> Comprar(DateTime dataEntrega, string horarioentrega)
        {
            try
            {
                await _produtoService.Comprar(dataEntrega, horarioentrega);
            }
            catch (Exception e)
            {

                throw;
            }
            return View();
        }

        public async Task<IActionResult> Add()
        {
            TempData["selos"]      = await _seloService.list();
            TempData["categorias"] = await _categoriaService.list();
            return View();
        }

        public async Task<IActionResult> AddPost(ProdutoDTO produto)
        {
            try
            {
                await _produtoService.Add(produto);
            }
            catch (Exception e )
            {

                throw;
            }
            return View();
        }
    }
}
