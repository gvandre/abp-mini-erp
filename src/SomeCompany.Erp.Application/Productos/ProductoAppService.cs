using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Entities;

namespace SomeCompany.Erp.Productos
{
    public class ProductoAppService : CrudAppService<
            Producto, //The Cliente entity
            ProductoDto, //Used to show clientes
            Guid, //Primary key of the Cliente entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateProductoDto>, IProductoAppService
    {
        public ProductoAppService (IRepository<Producto, Guid> repository) : base(repository)
        {
        }

        public override async Task<PagedResultDto<ProductoDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            // await CheckGetPolicyAsync();

            return null;
        }
    }
}
