using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using practica_asp.net.Models;
using practica_asp.net.Models.Usuario;
using System.Collections.Generic;
using System.Net.Http;

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
            List<Result> usuarioList = new List<Result>();
            HttpResponseMessage response = _httpClient.GetAsync("").Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                var rootObject = JsonConvert.DeserializeObject<BaseUsuario>(data);
                usuarioList = rootObject.Results;
            }

            return Ok(usuarioList);
        }
    }
}


