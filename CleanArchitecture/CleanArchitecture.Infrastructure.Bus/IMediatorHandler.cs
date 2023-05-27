using CleanArchitecture.Domain.Core.Commands;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommandAsync<T>(T Command) where T : Command;
    }
}
