using MediatR;
using Spotify.Contract.Abstractions.Shared;

namespace Spotify.Contract.Abstractions.Message;

public interface ICommand : IRequest<Result>
{
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
}
