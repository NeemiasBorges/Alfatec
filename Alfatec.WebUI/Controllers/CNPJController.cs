using Microsoft.AspNetCore.Mvc;

namespace Alfatec.WebUI.Controllers
{
    [ApiController]
    [Route("api/cnpjs")] 
    public class CNPJController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _urlCNPJReceita;

        public CNPJController(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _urlCNPJReceita = configuration["URLReceita"].ToString();
        }

        [HttpGet("{cnpj}")]
        public async Task<IActionResult> GetCNPJ(string cnpj)
        {
            var httpClient = _httpClientFactory.CreateClient();
            cnpj = cnpj.Replace("/", "").Replace("-","").Replace(".","").Replace("'", "");
            try
            {
                var response = await httpClient.GetAsync($"{_urlCNPJReceita}{cnpj}");

                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    if (response.ReasonPhrase.Contains("Error"))
                    {
                        return BadRequest($"Erro ao capturar CNPJ: {cnpj}");
                    }
                    return Ok(responseData);
                }
                else
                {
                    return StatusCode((int)response.StatusCode);
                }
            }
            catch (HttpRequestException ex)
            {
                return BadRequest($"Error fetching CNPJ data: {ex.Message}");
            }
        }
    }
}
