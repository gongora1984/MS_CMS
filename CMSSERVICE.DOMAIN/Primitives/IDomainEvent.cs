using MediatR;

namespace CMSSERVICE.DOMAIN.Primitives;

public interface IDomainEvent : INotification
{
    public Guid Id { get; init; }
}
