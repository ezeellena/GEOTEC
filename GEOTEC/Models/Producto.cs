using System;
using System.Collections.Generic;

#nullable disable

namespace GEOTEC.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public decimal Precio { get; set; }
        public int? MarcaId { get; set; }
        public int? ColorId { get; set; }
        public int? TalleId { get; set; }

        public virtual Color Color { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual Talle Talle { get; set; }
    }
}
