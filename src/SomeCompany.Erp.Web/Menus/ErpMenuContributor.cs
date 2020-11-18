using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using SomeCompany.Erp.Localization;
using SomeCompany.Erp.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace SomeCompany.Erp.Web.Menus
{
    public class ErpMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<ErpResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(ErpMenus.Home, l["Menu:Home"], "~/"));

            context.Menu.AddItem(new ApplicationMenuItem(
                    "Maestros",
                    "Maestros"
                    ).AddItem(new ApplicationMenuItem(
                        "Clientes",
                        "Clientes",
                        url: "Clientes"
                    )).AddItem(new ApplicationMenuItem(
                        "Productos",
                        "Productos",
                        url: "Productos"
                    ))
            );
        }
    }
}
