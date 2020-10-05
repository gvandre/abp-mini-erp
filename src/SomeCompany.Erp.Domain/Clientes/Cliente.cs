using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace SomeCompany.Erp.Clientes
{
    public class Cliente : AuditedEntity<Guid> // El Id es Guid y auto generado por abp
    {
        public string Nombre { get; set; }
        public string Ruc { get; set; }
        public string Dni { get; set; }
        public string Ce { get; set; } // Carnet de extranjeria char(12)
    }
}
