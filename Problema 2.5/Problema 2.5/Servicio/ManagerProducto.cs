using Problema_2._5.Models;
using Problema_2._5.Repositorio.Implementacion;
using Problema_2._5.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2._5.Servicio
{
    public class ManagerProducto : IManagerProducto
    {
        private IProductoRepositorio _productoRepositorio;
        public ManagerProducto(IProductoRepositorio productoRepositorio)
        {
            _productoRepositorio = productoRepositorio;
        }
        public void AgregarProducto(PRODUCTO producto)
        {
            _productoRepositorio.AgregarProducto(producto);
        }

        public void EliminarProducto(int codigo)
        {
            _productoRepositorio.EliminarProducto(codigo);
        }

        public void EliminarProducto(PRODUCTO producto)
        {
            _productoRepositorio.EliminarProducto(producto);
        }

        public List<PRODUCTO> ListarProductos()
        {
            return _productoRepositorio.ListarProductos();
        }

        public void ModificarProducto(PRODUCTO producto)
        {
            _productoRepositorio.ModificarProducto(producto);
        }

        public PRODUCTO ObtenerProducto(int codigo)
        {
            return _productoRepositorio.ObtenerProducto(codigo);
        }
    }
}
