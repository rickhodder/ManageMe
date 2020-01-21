using System.Threading.Tasks;
using ManageMe.SharedKernel;

namespace ManageMe.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}