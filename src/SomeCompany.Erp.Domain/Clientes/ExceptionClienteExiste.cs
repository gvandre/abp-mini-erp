using System;
using Volo.Abp;

namespace SomeCompany.Erp.Clientes
{
    public class ExceptionClienteExiste : BusinessException
    {
        public ExceptionClienteExiste(string tipoDoc, string numDoc) : base(ErpDomainErrorCodes.ClienteExiste)
        {
            WithData("typeDoc", tipoDoc);

            WithData("doc", numDoc);
        }
    }
}
