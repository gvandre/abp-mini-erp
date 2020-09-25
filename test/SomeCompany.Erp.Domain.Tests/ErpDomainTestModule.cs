using SomeCompany.Erp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SomeCompany.Erp
{
    [DependsOn(
        typeof(ErpEntityFrameworkCoreTestModule)
        )]
    public class ErpDomainTestModule : AbpModule
    {

    }
}