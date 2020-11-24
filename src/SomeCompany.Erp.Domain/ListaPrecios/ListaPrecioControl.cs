using System;
using System.Linq;
using Volo.Abp.Domain.Services;

namespace SomeCompany.Erp.ListaPrecios
{
    public class ListaPrecioControl : DomainService
    {
        /*private ListaPrecio _listaPrecio;
        public ListaPrecioControl()
        {
        }

        public ListaPrecio CrearListaPrecio(string nombre)
        {
            if (nombre.Length > 5)
            {
                // Precio no deberia ser 0 o negativo
            }

            _listaPrecio = new ListaPrecio(GuidGenerator.Create(), nombre);

            return _listaPrecio;
        }
        public void AgregarProducto(Guid productoId, float precio)
        {
            if (precio <= 0)
            {
                // Precio no deberia ser 0 o negativo
            }

            var existeEnLista = _listaPrecio.ListaDetalle.FirstOrDefault(producto => producto.ProductoId == productoId);

            if (existeEnLista == null)
            {
                _listaPrecio.ListaDetalle.Add(new ListaPrecioDetalle(_listaPrecio.Id, productoId, precio));
            } else {
                existeEnLista.Precio = precio;
            }
        }*/
    }
}
