using System;
using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace SomeCompany.Erp.Clientes
{
    public class ClienteControl : DomainService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteControl(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<Cliente> CreateClienteAsync (
            [NotNull] string nombre,
            [CanBeNull] string dni,
            [CanBeNull] string ruc,
            [CanBeNull] string ce
        )
        {
            Check.NotNullOrWhiteSpace(nombre, nameof(nombre));

            if (string.IsNullOrWhiteSpace(dni) && string.IsNullOrWhiteSpace(ruc) && string.IsNullOrWhiteSpace(ce))
            {
                throw new ExceptionClienteNoData();
            }

            var exiteClienteDni = string.IsNullOrWhiteSpace(dni) ? null : await _clienteRepository.FindByDniAsync(dni);

            var exiteClienteRuc = string.IsNullOrWhiteSpace(ruc) ? null : await _clienteRepository.FindByRucAsync(ruc);

            var exiteClienteCe = string.IsNullOrWhiteSpace(ce) ? null : await _clienteRepository.FindByCeAsync(ce);

            if (exiteClienteDni != null)
            {
                // Dni ya existe
                throw new ExceptionClienteExiste("dni", dni);
            }

            if (exiteClienteRuc != null)
            {
                // Ruc ya existe
                throw new ExceptionClienteExiste("ruc", ruc);
            }

            if (exiteClienteCe != null)
            {
                // Ce ya existe
                throw new ExceptionClienteExiste("ce", ce);
            }

            return new Cliente {
                Nombre = nombre,
                Dni = dni,
                Ruc = ruc,
                Ce = ce
            };
        }

        public async Task ChangeDniAsync(
            [NotNull] Cliente cliente,
            [CanBeNull] string dni
        )
        {
            Check.NotNull(cliente, nameof(cliente));

            if (!string.IsNullOrWhiteSpace(dni))
            {
                var existeCliente = await _clienteRepository.FindByDniAsync(dni);

                if (existeCliente != null && existeCliente.Id != cliente.Id)
                {
                    throw new ExceptionClienteExiste("dni", dni);
                }
            }

            cliente.Dni = dni;
        }

        public async Task ChangeRucAsync(
            [NotNull] Cliente cliente,
            [CanBeNull] string ruc
        )
        {
            Check.NotNull(cliente, nameof(cliente));

            if (!string.IsNullOrWhiteSpace(ruc))
            {
                var existeCliente = await _clienteRepository.FindByRucAsync(ruc);

                if (existeCliente != null && existeCliente.Id != cliente.Id)
                {
                    throw new ExceptionClienteExiste("ruc", ruc);
                }
            }

            cliente.Ruc = ruc;
        }

        public async Task ChangeCeAsync(
            [NotNull] Cliente cliente,
            [CanBeNull] string ce
        )
        {
            Check.NotNull(cliente, nameof(cliente));

            if (!string.IsNullOrWhiteSpace(ce))
            {
                var existeCliente = await _clienteRepository.FindByCeAsync(ce);

                if (existeCliente != null && existeCliente.Id != cliente.Id)
                {
                    throw new ExceptionClienteExiste("ce", ce);
                }
            }

            cliente.Ce = ce;
        }
    }
}
