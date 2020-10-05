using AutoMapper;
using SomeCompany.Erp.Clientes;

namespace SomeCompany.Erp
{
    public class ErpApplicationAutoMapperProfile : Profile
    {
        public ErpApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Cliente, ClienteDto>();
        }
    }
}
