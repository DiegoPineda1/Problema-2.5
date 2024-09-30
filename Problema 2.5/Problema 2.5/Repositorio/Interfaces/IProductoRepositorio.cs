using Problema_2._5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2._5.Repositorio.Interfaces
{
    public  interface IProductoRepositorio
    {
        List<PRODUCTO> ListarProductos();
        PRODUCTO ObtenerProducto(int codigo);
        void AgregarProducto(PRODUCTO producto);
        void ModificarProducto(PRODUCTO producto);
        void EliminarProducto(int codigo);
        void EliminarProducto(PRODUCTO producto);

    }
}
