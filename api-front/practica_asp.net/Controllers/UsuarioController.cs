using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using practica_asp.net.Models;
using practica_asp.net.Models.Usuario;

namespace practica_asp.net.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        Uri baseAddress = new Uri("https://randomuser.me/api/");
        private readonly HttpClient _httpClient;

        public UsuarioController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = baseAddress;
        }


        public IActionResult Index()
        {
            List<BaseUsuario> usuarioList = new List<BaseUsuario>();
            HttpResponseMessage response = _httpClient.GetAsync(_httpClient.BaseAddress + "/usuario").Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                usuarioList = JsonConvert.DeserializeObject<List<BaseUsuario>>(data);
            }

            return Ok(usuarioList);
        }
    }
}
