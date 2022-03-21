using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GEOTEC.Dto
{
    public class TalleDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<ProductoDto> Productos { get; set; }
    }
}
