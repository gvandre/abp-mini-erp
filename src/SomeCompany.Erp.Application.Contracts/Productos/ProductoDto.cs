using System;
using Volo.Abp.Application.Dtos;

namespace SomeCompany.Erp.Productos
{
    public class ProductoDto : FullAuditedEntityDto<Guid>
    {
        public string Nombre { get; set; }
        public string CodigoProducto { get; set; }
    }
}
