using MediatR;

namespace CMSSERVICE.APPLICATION.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
