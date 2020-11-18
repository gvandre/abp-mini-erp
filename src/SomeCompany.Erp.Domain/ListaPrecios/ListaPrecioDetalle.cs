using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace SomeCompany.Erp.ListaPrecios
{
    public class ListaPrecioDetalle : AuditedEntity<Guid>
    {
        public Guid ListaPrecioId { get; set; }
        public Guid ProductoId { get; set; }
        public float Precio { get; set; }
    }
}
