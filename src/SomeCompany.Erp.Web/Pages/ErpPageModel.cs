using SomeCompany.Erp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SomeCompany.Erp.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ErpPageModel : AbpPageModel
    {
        protected ErpPageModel()
        {
            LocalizationResourceType = typeof(ErpResource);
        }
    }
}