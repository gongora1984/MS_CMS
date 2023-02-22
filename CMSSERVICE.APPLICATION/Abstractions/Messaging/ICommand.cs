﻿using MediatR;

namespace CMSSERVICE.APPLICATION.Abstractions.Messaging;

public interface ICommand : IRequest<Result>
{
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
}
