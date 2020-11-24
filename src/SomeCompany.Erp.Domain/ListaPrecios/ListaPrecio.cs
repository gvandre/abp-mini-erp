using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace SomeCompany.Erp.ListaPrecios
{
    public class ListaPrecio : AuditedAggregateRoot<Guid>
    {
        public string Nombre { get; set; }
        public List<ListaPrecioDetalle> ListaDetalle { get; set; }
        protected ListaPrecio()
        {

        }
        public ListaPrecio(Guid id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            ListaDetalle = new List<ListaPrecioDetalle>();
        }
    }
}
