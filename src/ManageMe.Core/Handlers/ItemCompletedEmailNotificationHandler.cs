using System.Threading.Tasks;
using Ardalis.GuardClauses;
using ManageMe.Core.Events;
using ManageMe.SharedKernel.Interfaces;

namespace ManageMe.Core.Services
{
    public class ItemCompletedEmailNotificationHandler : IHandle<ToDoItemCompletedEvent>
    {
        public Task Handle(ToDoItemCompletedEvent domainEvent)
        {
            Guard.Against.Null(domainEvent, nameof(domainEvent));

            // Do Nothing
            return Task.CompletedTask;
        }
    }
}
