using Acme.Bookshop.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.Bookshop.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookshopEntityFrameworkCoreModule),
    typeof(BookshopApplicationContractsModule)
)]
public class BookshopDbMigratorModule : AbpModule
{
}
