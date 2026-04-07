using MediatR;
using Spotify.Contract.Abstractions.Shared;

namespace Spotify.Contract.Abstractions.Message;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{ }
