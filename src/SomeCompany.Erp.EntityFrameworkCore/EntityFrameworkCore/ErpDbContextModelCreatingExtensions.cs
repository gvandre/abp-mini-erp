using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace SomeCompany.Erp.EntityFrameworkCore
{
    public static class ErpDbContextModelCreatingExtensions
    {
        public static void ConfigureErp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ErpConsts.DbTablePrefix + "YourEntities", ErpConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}