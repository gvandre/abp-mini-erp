using System;
using System.Threading.Tasks;

namespace SomeCompany.Erp.Clientes
{
    public interface IClienteRepository
    {
        Task<Cliente> FindByDniAsync(string dni);
        Task<Cliente> FindByRucAsync(string ruc);
        Task<Cliente> FindByCeAsync(string ce);
    }
}
