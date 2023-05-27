using CleanArchitecture.Domain.Core.Commands;
using MediatR;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommandAsync<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}
