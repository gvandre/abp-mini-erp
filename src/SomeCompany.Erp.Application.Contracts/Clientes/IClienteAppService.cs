using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SomeCompany.Erp.Clientes
{
    public interface IClienteAppService :
        ICrudAppService< //Defines CRUD methods
            ClienteDto, //Used to show Cliente
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateClienteDto> //Used to create/update a Cliente
    {

    }
}
