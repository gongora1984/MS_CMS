using MAILSYSTEM.DOMAIN.Primitives;
using MediatR;

namespace CMSSERVICE.APPLICATION.Abstractions.Messaging;

public interface IDomainEventHandler<in TEvent> : INotificationHandler<TEvent>
where TEvent : IDomainEvent
{
}
