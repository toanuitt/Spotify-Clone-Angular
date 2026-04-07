using MediatR;

namespace Spotify.Contract.Abstractions.Message;

public interface IDomainEventHandler<TDomainEvent> : INotificationHandler<TDomainEvent>
    where TDomainEvent : IDomainEvent
{
}
