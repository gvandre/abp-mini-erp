using System;
using Volo.Abp.Domain.Entities;

namespace SomeCompany.Erp.ListaPrecios
{
    public class ListaPrecioDetalle : Entity
    {
        public Guid ListaPrecioId { get; set; }
        public Guid ProductoId { get; set; }
        public float Precio { get; set; }

        protected ListaPrecioDetalle()
        {

        }

        internal ListaPrecioDetalle(Guid listaPrecioId, Guid productoId, float precio)
        {
            ListaPrecioId = listaPrecioId;
            ProductoId = productoId;
            Precio = precio;
        }

        public override object[] GetKeys()
        {
            return new Object[] { ListaPrecioId, ProductoId };
        }
    }
}
