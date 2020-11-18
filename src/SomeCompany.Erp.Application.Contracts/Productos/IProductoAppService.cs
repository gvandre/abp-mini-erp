using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SomeCompany.Erp.Productos
{
    public interface IProductoAppService :
         ICrudAppService<
            ProductoDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateProductoDto>
    {
    }
}
