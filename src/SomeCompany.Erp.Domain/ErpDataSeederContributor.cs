using System;
using System.Threading.Tasks;
using SomeCompany.Erp.Clientes;
using SomeCompany.Erp.Productos;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace SomeCompany.Erp
{
    public class ErpDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Cliente, Guid> _clienteRepository;

        private readonly IRepository<Producto, Guid> _productoRepository;

        public ErpDataSeederContributor(IRepository<Cliente, Guid> clienteRepository, IRepository<Producto, Guid> productoRepository)
        {
            _clienteRepository = clienteRepository;
            _productoRepository = productoRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _clienteRepository.GetCountAsync() <= 0)
            {
                await _clienteRepository.InsertAsync(
                    new Cliente
                    {
                        Nombre = "Cliente 1",
                        Ruc = "1234567890A",
                        Dni = "12345678",
                        Ce = "1234567890AB"
                    },
                    autoSave: true
                );

                await _clienteRepository.InsertAsync(
                    new Cliente
                    {
                        Nombre = "Cliente 2",
                        Ruc = "A0987654321",
                        Dni = "87654321",
                        Ce = "BA0987654321"
                    },
                    autoSave: true
                );
            }

            if (await _productoRepository.GetCountAsync() <= 0)
            {
                await _productoRepository.InsertAsync(
                    new Producto
                    {
                        Nombre = "Producto 1",
                    },
                    autoSave: true
                );

                await _productoRepository.InsertAsync(
                    new Producto
                    {
                        Nombre = "Producto 2",
                    },
                    autoSave: true
                );
            }
        }
    }
}
