using Problema_2._5.Models;
using Problema_2._5.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2._5.Repositorio.Implementacion
{
    public class ProductoRepositorio : IProductoRepositorio
    {
        private db_productosContext _context;
        public ProductoRepositorio(db_productosContext db_ProductosContext)
        {
            this._context = db_ProductosContext;
        }
        public void AgregarProducto(PRODUCTO producto)
        {
            _context.PRODUCTOs.Add(producto);
            _context.SaveChanges();
        }

        public void EliminarProducto(int codigo)
        {
            _context.PRODUCTOs.Remove(ObtenerProducto(codigo));
            _context.SaveChanges();
        }

        public void EliminarProducto(PRODUCTO producto)
        {
            _context.PRODUCTOs.Remove(producto);
            _context.SaveChanges();
        }

        public List<PRODUCTO> ListarProductos()
        {
            return _context.PRODUCTOs.ToList();
        }

        public void ModificarProducto(PRODUCTO producto)
        {
            _context.PRODUCTOs.Update(producto);
            _context.SaveChanges();
        }

        public PRODUCTO ObtenerProducto(int codigo)
        {
            return _context.PRODUCTOs.Find(codigo);
        }
    }
}


