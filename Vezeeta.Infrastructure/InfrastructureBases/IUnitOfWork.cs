
namespace Vezeeta.Infrastructure.InfrastructureBases
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        Task<int> SaveChangesAsync();
    }
}
