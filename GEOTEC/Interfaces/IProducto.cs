using GEOTEC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GEOTEC.Interfaces
{
    public interface IProducto
    {
        public Task<IEnumerable<Producto>> BuscarProducto(string NombreProducto);
        public Producto DetalleProducto(int Id);
        public List<Producto> GetProductos();
    }
}
