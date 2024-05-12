using Alfatec.Application.DTOs;
using Alfatec.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Alfatec.WebUI.Controllers
{
    public class ServicoController : Controller
    {
        private readonly IServicoService _servicosService;
        public ServicoController(IServicoService servicosService)
        {
            _servicosService = servicosService;
        }
        public IActionResult Add()
        {
            return View();
        }

        public async Task<IActionResult> AddPost(ServicosDTO servico)
        {
            try
            {
                await _servicosService.Add(servico);
            }
            catch (Exception e)
            {

                throw;
            }
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
