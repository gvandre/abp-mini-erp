using System;
using System.Collections.Generic;
using System.Text;
using SomeCompany.Erp.Localization;
using Volo.Abp.Application.Services;

namespace SomeCompany.Erp
{
    /* Inherit your application services from this class.
     */
    public abstract class ErpAppService : ApplicationService
    {
        protected ErpAppService()
        {
            LocalizationResource = typeof(ErpResource);
        }
    }
}
