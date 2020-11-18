using System;
using Volo.Abp.Application.Dtos;

namespace SomeCompany.Erp.Productos
{
    public class ProductoDto : AuditedEntityDto<Guid>
    {
        public string Nombre { get; set; }
        public string CodigoProducto { get; set; }
    }
}
