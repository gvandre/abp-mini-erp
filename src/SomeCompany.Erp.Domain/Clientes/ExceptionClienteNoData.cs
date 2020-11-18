using System;
using Volo.Abp;

namespace SomeCompany.Erp.Clientes
{
    public class ExceptionClienteNoData : BusinessException
    {
        public ExceptionClienteNoData() : base(ErpDomainErrorCodes.ClienteNodata)
        {
        }
    }
}
