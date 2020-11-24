using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SomeCompany.Erp.Productos;

namespace SomeCompany.Erp.Web.Pages.Productos
{
    public class CreateModalModel : ErpPageModel
    {
        [BindProperty]
        public CreateUpdateProductoDto Producto { get; set; }
        private readonly IProductoAppService _productoAppService;
        public CreateModalModel (IProductoAppService productoAppService)
        {
            _productoAppService = productoAppService;
        }
        public void OnGet()
        {
            Producto = new CreateUpdateProductoDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _productoAppService.CreateAsync(Producto);

            return NoContent();
        }
    }
}
