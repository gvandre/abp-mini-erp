using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using SomeCompany.Erp.Clientes;
using SomeCompany.Erp.Productos;

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
            builder.Entity<Cliente>(b =>
            {
                b.ToTable(ErpConsts.DbTablePrefix + "Clientes",
                          ErpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Nombre).IsRequired().HasMaxLength(50);
                b.Property(x => x.Ruc).IsFixedLength(true).HasMaxLength(11); // char(11)
                b.Property(x => x.Dni).IsFixedLength(true).HasMaxLength(8); // char(8)
                b.Property(x => x.Ce).IsFixedLength(true).HasMaxLength(12); // char(12)
            });

            builder.Entity<Producto>(b =>
            {
                b.ToTable(ErpConsts.DbTablePrefix + "Productos",
                          ErpConsts.DbSchema);
               
                b.ConfigureByConvention(); //auto configure for the base class props
                
                b.Property(x => x.Nombre).IsRequired().HasMaxLength(50);
                b.Property(x => x.CodigoProducto).IsRequired(true).HasMaxLength(10);
            });
        }
    }
}