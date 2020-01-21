using System.Threading.Tasks;
using ManageMe.SharedKernel.Interfaces;
using ManageMe.SharedKernel;

namespace ManageMe.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}
