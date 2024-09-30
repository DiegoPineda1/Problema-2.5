using Problema_2._5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2._5.Servicio
{
    public interface IManagerProducto
    {
        List<PRODUCTO> ListarProductos();
        PRODUCTO ObtenerProducto(int codigo);
        void AgregarProducto(PRODUCTO producto);
        void ModificarProducto(PRODUCTO producto);
        void EliminarProducto(int codigo);
        void EliminarProducto(PRODUCTO producto);
    }
}
