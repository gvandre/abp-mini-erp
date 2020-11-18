using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace SomeCompany.Erp.ListaPrecios
{
    public class ListaPrecio : AuditedAggregateRoot<Guid>
    {
        public string Nombre { get; set; }
    }
}
