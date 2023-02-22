﻿using CMSSERVICE.APPLICATION.Abstractions.Messaging;
using CMSSERVICE.DOMAIN.Abstractions;
using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using static CMSSERVICE.DOMAIN.Errors.DomainErrors;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts;

internal sealed class LoginCommandHandler : ICommandHandler<LoginCommand, string>
{
    private readonly IApiProvider _apiProvider;
    private readonly IAuthenticationRepository _authenticationRepository;

    public LoginCommandHandler(IApiProvider apiProvider, IAuthenticationRepository authenticationRepository)
    {
        _apiProvider = apiProvider;
        _authenticationRepository = authenticationRepository;
    }

    public async Task<Result<string>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        LoginDetail? user = await _authenticationRepository.GetByEmailAsync(
            request.email,
            cancellationToken);

        if (user is null)
        {
            return Result.Failure<string>(
                LoginError.InvalidUsername);
        }

        if (user.LoginPwd != request.password)
        {
            return Result.Failure<string>(
                LoginError.InvalidCredentials);
        }

        string token = _apiProvider.GenerateApiKey(user);

        return token;
    }
}