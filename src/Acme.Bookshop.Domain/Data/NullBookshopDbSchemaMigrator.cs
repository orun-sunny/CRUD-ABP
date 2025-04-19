using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.Bookshop.Data;

/* This is used if database provider does't define
 * IBookshopDbSchemaMigrator implementation.
 */
public class NullBookshopDbSchemaMigrator : IBookshopDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
