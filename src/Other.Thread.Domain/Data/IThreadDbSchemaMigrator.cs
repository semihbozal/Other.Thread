using System.Threading.Tasks;

namespace Other.Thread.Data;

public interface IThreadDbSchemaMigrator
{
    Task MigrateAsync();
}
