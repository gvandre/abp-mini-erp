using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SomeCompany.Erp.Productos;

namespace SomeCompany.Erp.Web.Pages.Productos
{
    public class EditModalModel : ErpPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateProductoDto Producto { get; set; }

        private readonly IProductoAppService _productoAppService;

        public EditModalModel(IProductoAppService productoAppService)
        {
            _productoAppService = productoAppService;
        }
        public async void OnGet()
        {
            var producto = await _productoAppService.GetAsync(Id);

            Producto = ObjectMapper.Map<ProductoDto, CreateUpdateProductoDto>(producto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _productoAppService.UpdateAsync(Id, Producto);

            return NoContent();
        }
    }
}
