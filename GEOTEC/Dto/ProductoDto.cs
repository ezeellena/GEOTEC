
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GEOTEC.Dto
{
    public class ProductoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public decimal Precio { get; set; }
        public string Nombre_Color { get; set; }
        public string Nombre_Marca { get; set; }
        public string Nombre_Talle { get; set; }

    }
}
