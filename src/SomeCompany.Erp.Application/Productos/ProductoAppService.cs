using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace SomeCompany.Erp.Productos
{
    public class ProductoAppService : CrudAppService<
            Producto, //The Cliente entity
            ProductoDto, //Used to show clientes
            Guid, //Primary key of the Cliente entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateProductoDto>, IProductoAppService, ITransientDependency
    {
        private readonly IDataFilter<ISoftDelete> _softDeleteFilter;
        public ProductoAppService (IRepository<Producto, Guid> repository,
            IDataFilter<ISoftDelete> softDeleteFilter) : base(repository)
        {
            _softDeleteFilter = softDeleteFilter;
        }

        public async override Task<PagedResultDto<ProductoDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            using (_softDeleteFilter.Disable())
            {
                return await base.GetListAsync(input);
            }
        }
        public async override Task<ProductoDto> GetAsync(Guid id)
        {
            using (_softDeleteFilter.Disable())
            {
                return await base.GetAsync(id);
            }
        }
        public async override Task<ProductoDto> UpdateAsync(Guid id, CreateUpdateProductoDto input)
        {
            using (_softDeleteFilter.Disable())
            {
                return await base.UpdateAsync(id, input);
            }
        }

        public async override Task DeleteAsync(Guid id)
        {
            using (_softDeleteFilter.Disable())
            {
                var producto = await Repository.GetAsync(id);

                producto.IsDeleted = !producto.IsDeleted;

                await Repository.UpdateAsync(producto);
            }
        }
    }
}
