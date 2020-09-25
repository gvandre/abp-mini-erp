using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace SomeCompany.Erp.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(ErpHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ErpConsoleApiClientModule : AbpModule
    {
        
    }
}
