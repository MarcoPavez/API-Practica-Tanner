using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practica_asp.net.Models;

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using practica_asp.net.Models.Producto;

namespace practica_asp.net.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        private readonly CsharpApiContext _dbContext;

        // Constructor
        public ProductoController(CsharpApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("lista")]
        public async Task<IActionResult> ObtenerProductos()
        {
            List<Producto> list = await _dbContext.Productos.ToListAsync();
            return StatusCode(StatusCodes.Status200OK, list);
        }

        [HttpPut]
        [Route("editarProducto/{idProducto:int}")]

        [HttpPost]
        [Route("agregarProducto")]
        public async Task<IActionResult> AgregarProducto([FromBody] Producto productoCliente)
        {
            try
            {
                _dbContext.Productos.AddAsync(productoCliente);
                _dbContext.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Producto Agregado" });
            }catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpDelete]
        [Route("eliminarProducto/{idProducto:int}")]
        public async Task<IActionResult> EliminarProducto(int idProducto)
        {
            Producto objetoProducto = _dbContext.Productos.Find(idProducto);

            if(objetoProducto == null)
            {
                return BadRequest("Tontito");
            }
            try
            {
                _dbContext.Productos.Remove(objetoProducto);
                _dbContext.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Producto Eliminado" });
            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }


    }
}
