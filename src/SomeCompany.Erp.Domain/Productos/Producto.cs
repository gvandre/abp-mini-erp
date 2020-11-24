using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace SomeCompany.Erp.Productos
{
    public class Producto : FullAuditedAggregateRoot<Guid>
    {
        public string Nombre { get; set; }
        public string CodigoProducto { get; set; }
    }
}
