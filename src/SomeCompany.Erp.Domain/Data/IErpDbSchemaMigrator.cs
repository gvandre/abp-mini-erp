using System.Threading.Tasks;

namespace SomeCompany.Erp.Data
{
    public interface IErpDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
