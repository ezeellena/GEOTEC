using System;
using System.Collections.Generic;

#nullable disable

namespace GEOTEC.Models
{
    public partial class Color
    {
        public Color()
        {
            Productos = new HashSet<Producto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
