using MediatR;

namespace Spotify.Contract.Abstractions.Message;

public interface IDomainEvent : INotification
{
   Guid Id { get; init; }
}
