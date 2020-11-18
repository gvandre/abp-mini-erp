using AutoMapper;
using SomeCompany.Erp.Clientes;

namespace SomeCompany.Erp.Web
{
    public class ErpWebAutoMapperProfile : Profile
    {
        public ErpWebAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Web project.
            CreateMap<ClienteDto, CreateUpdateClienteDto>();
        }
    }
}
