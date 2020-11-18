using System;
using System.ComponentModel.DataAnnotations;

namespace SomeCompany.Erp.Productos
{
    public class CreateUpdateProductoDto
    {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(10)]
        public string CodigoProducto { get; set; }
    }
}
