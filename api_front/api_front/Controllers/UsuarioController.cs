using Microsoft.AspNetCore.Mvc;
using api_front.Models;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace practica_asp.net.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public UsuarioController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://randomuser.me/api/");
        }

        public IActionResult Index()
        {
            Usuario usuarioList = new Usuario();
            HttpResponseMessage response = _httpClient.GetAsync("").Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                var rootObject = JsonConvert.DeserializeObject<Usuario>(data);
                usuarioList = rootObject;
            }

            return Ok(usuarioList);
        }
    }
}


