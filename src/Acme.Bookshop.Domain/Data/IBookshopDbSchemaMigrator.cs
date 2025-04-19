using System.Threading.Tasks;

namespace Acme.Bookshop.Data;

public interface IBookshopDbSchemaMigrator
{
    Task MigrateAsync();
}
