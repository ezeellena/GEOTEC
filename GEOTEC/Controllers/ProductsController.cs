using AutoMapper;
using GEOTEC.Dto;
using GEOTEC.Interfaces;
using GEOTEC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GEOTEC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IProducto _producto;
        private readonly IMapper _mapper;

        public ProductsController(ILogger<ProductsController> logger, IMapper mapper, IProducto producto)
        {
            _logger = logger;
            _mapper = mapper;
            _producto = producto;
        }

        [HttpPost("BuscarProductos/{NombreProducto}")]
        public async Task<IEnumerable<ProductoDto>> BuscarProductos(string NombreProducto)
        {
            var producto = await _producto.BuscarProducto(NombreProducto);
            var productoDto = _mapper.Map<List<ProductoDto>>(producto);
            return productoDto;
        }

        [HttpGet("GetProductoDetalle/{Id}")]
        public ProductoDto GetProductDetails(int Id)
        {
            var producto = _producto.DetalleProducto(Id);
            var productoDto = _mapper.Map<ProductoDto>(producto);
            return productoDto;
        }

        [HttpGet("GetProductos")]
        public List<ProductoDto> GetProductos()
        {
            var producto = _producto.GetProductos();
            var productoDto = _mapper.Map<List<ProductoDto>>(producto);
            return productoDto;
        }
    }
}
