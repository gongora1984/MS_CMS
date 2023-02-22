using AutoMapper;
using CMSSERVICE.DOMAIN.Abstractions;
using CMSSERVICE.DOMAIN.Contracts.Responses.Authentication;
using CMSSERVICE.DOMAIN.Contracts.Responses.LoginDetails;
using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using static CMSSERVICE.DOMAIN.Errors.DomainErrors;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts.Commands.LoginCommands;

internal sealed class LoginCommandHandler : ICommandHandler<LoginCommand, LoginResponse>
{
    private readonly IApiProvider _apiProvider;
    private readonly IAuthenticationRepository _authenticationRepository;
    private readonly IMapper _mapper;

    public LoginCommandHandler(IApiProvider apiProvider, IAuthenticationRepository authenticationRepository, IMapper mapper)
    {
        _apiProvider = apiProvider;
        _authenticationRepository = authenticationRepository;
        _mapper = mapper;
    }

    public async Task<Result<LoginResponse>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        LoginDetail? user = await _authenticationRepository.GetByEmailAsync(
            request.email,
            cancellationToken);

        if (user is null)
        {
            return Result.Failure<LoginResponse>(
                LoginError.InvalidUsername);
        }

        if (user.LoginPwd != request.password)
        {
            return Result.Failure<LoginResponse>(
                LoginError.InvalidCredentials);
        }

        string token = _apiProvider.GenerateApiKey(user);

        return new LoginResponse
        {
            ApiKey = token,
            UserInformation = _mapper.Map<LoginDetailResponse>(user)
        };
    }
}
