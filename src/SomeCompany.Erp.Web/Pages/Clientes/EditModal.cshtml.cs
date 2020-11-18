using System;
using SomeCompany.Erp.Clientes;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SomeCompany.Erp.Web.Pages.Clientes
{
    public class EditModalModel : ErpPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateClienteDto Cliente { get; set; }

        private IClienteAppService _clienteAppService;

        public EditModalModel (IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }
        public async Task OnGet()
        {
            var clienteDto = await _clienteAppService.GetAsync(Id);

            Cliente = ObjectMapper.Map<ClienteDto, CreateUpdateClienteDto>(clienteDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _clienteAppService.UpdateAsync(Id, Cliente);

            return NoContent();
        }
    }
}
