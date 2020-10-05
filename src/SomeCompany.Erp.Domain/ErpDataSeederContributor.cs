using System;
using System.Threading.Tasks;
using SomeCompany.Erp.Clientes;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace SomeCompany.Erp
{
    public class ErpDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Cliente, Guid> _clienteRepository;

        public ErpDataSeederContributor(IRepository<Cliente, Guid> clienteRepository)
        {
            _clienteRepository = clienteRepository;
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
        }
    }
}
