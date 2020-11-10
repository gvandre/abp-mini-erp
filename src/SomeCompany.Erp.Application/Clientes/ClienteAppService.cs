using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SomeCompany.Erp.Clientes
{
    public class ClienteAppService :
        CrudAppService<
            Cliente, //The Cliente entity
            ClienteDto, //Used to show clientes
            Guid, //Primary key of the Cliente entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateClienteDto>, //Used to create/update a Cliente
         IClienteAppService//implement the IBookAppService
    {
        public ClienteAppService(IRepository<Cliente, Guid> repository)
        : base(repository)
        {
        }
    }
}
