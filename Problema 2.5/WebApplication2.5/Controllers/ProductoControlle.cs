using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Problema_2._5.Repositorio.Interfaces;
using Problema_2._5.Repositorio.Implementacion;
using Problema_2._5.Models;


namespace WebApplication2._5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoControlle : ControllerBase
    {
        private readonly IProductoRepositorio _productoService;
        public ProductoControlle(IProductoRepositorio productoRepositorio)
        {
            _productoService = productoRepositorio;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                if(_productoService.ListarProductos().Count > 0)
                {
                    
                    return Ok(_productoService.ListarProductos());
                }
                    return NotFound("No hay productos registrados");
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error al obtener los productos");
            }
        }
        [HttpGet("{codigo}")]
        public IActionResult Get(int id)
        {
            try
            {
                var producto = _productoService.ObtenerProducto(id);
                if (producto != null)
                {
                    return Ok(producto);
                }
                return NotFound("El producto no existe");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al obtener el producto");
            }
        }
        [HttpPost]
        public IActionResult Post(PRODUCTO producto)
        {
            try
            {
                _productoService.AgregarProducto(producto);
                return Ok("Producto agregado correctamente");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al agregar el producto");
            }
        }
        [HttpPut]
        public IActionResult Put([FromBody] PRODUCTO producto)
        {
            try
            {
                _productoService.ModificarProducto(producto);
                return Ok("Producto modificado correctamente");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al modificar el producto");
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _productoService.EliminarProducto(id);
                return Ok("Producto eliminado correctamente");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al eliminar el producto");
            }
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] PRODUCTO producto)
        {
            try
            {
                _productoService.EliminarProducto(producto);
                return Ok("Producto eliminado correctamente");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al eliminar el producto");
            }
        }
    }
}
