using GEOTEC.Interfaces;
using GEOTEC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GEOTEC.Services
{
    public class ProductoServicio : IProducto
    {
        private readonly ILogger<ProductoServicio> _logger;
        private readonly GEOTECContext _context;

        public ProductoServicio(ILogger<ProductoServicio> logger, GEOTECContext context)
        {
            _logger = logger;
            _context = context;
        }
        public async Task<IEnumerable<Producto>> BuscarProducto(string NombreProducto)
        {
            var nombre = NombreProducto.ToLower();
            var producto = await _context.Productos
                .Include(c => c.Marca)
                .Include(c => c.Color)
                .Include(c => c.Talle)
                .Where(y => y.Nombre.ToLower().Contains(nombre)).ToListAsync();
            return producto;
        }

        public Producto DetalleProducto(int Id)
        {
            return _context.Productos.FirstOrDefault(x => x.Id == Id);
        }
        public List<Producto> GetProductos()
        {
            return _context.Productos.ToList();
        }
    }
}
