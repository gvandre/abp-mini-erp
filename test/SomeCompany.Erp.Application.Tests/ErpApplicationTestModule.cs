using Volo.Abp.Modularity;

namespace SomeCompany.Erp
{
    [DependsOn(
        typeof(ErpApplicationModule),
        typeof(ErpDomainTestModule)
        )]
    public class ErpApplicationTestModule : AbpModule
    {

    }
}