﻿using SomeCompany.Erp.Clientes;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SomeCompany.Erp.Web.Pages.Clientes
{
    public class CreateModalModel : ErpPageModel
    {
        [BindProperty]
        public CreateUpdateClienteDto Cliente { get; set; }

        private IClienteAppService _clienteAppService;

        public CreateModalModel (IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }
        public void OnGet()
        {
            Cliente = new CreateUpdateClienteDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _clienteAppService.CreateAsync(Cliente);

            return NoContent();
        }
    }
}