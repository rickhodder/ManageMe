using System.Threading.Tasks;
using ManageMe.SharedKernel;

namespace ManageMe.SharedKernel.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}