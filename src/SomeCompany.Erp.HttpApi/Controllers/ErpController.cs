using SomeCompany.Erp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SomeCompany.Erp.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ErpController : AbpController
    {
        protected ErpController()
        {
            LocalizationResource = typeof(ErpResource);
        }
    }
}