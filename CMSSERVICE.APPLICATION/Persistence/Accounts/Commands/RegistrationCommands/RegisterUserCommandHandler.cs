using AutoMapper;
using CMSSERVICE.DOMAIN.Abstractions;
using CMSSERVICE.DOMAIN.Contracts.Responses.Authentication;
using CMSSERVICE.DOMAIN.Contracts.Responses.LoginDetails;
using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using static CMSSERVICE.DOMAIN.Errors.DomainErrors;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts.Commands.RegistrationCommands;

/// <summary>
/// Register Client User Command Handler.
/// </summary>
internal sealed class RegisterAdminUserCommandHandler : ICommandHandler<RegisterAdminUserCommand, RegistrationResponse>
{
    private readonly IAuthenticationRepository _authenticationRepository;
    private readonly IRoleRepository _roleRepository;
    private readonly IMapper _mapper;
    private readonly IApiProvider _apiProvider;
    private readonly ISecurityProvider _securityProvider;

    public RegisterAdminUserCommandHandler(
        IAuthenticationRepository authenticationRepository,
        IMapper mapper,
        IApiProvider apiProvider,
        ISecurityProvider securityProvider,
        IRoleRepository roleRepository)
    {
        _authenticationRepository = authenticationRepository;
        _mapper = mapper;
        _apiProvider = apiProvider;
        _securityProvider = securityProvider;
        _roleRepository = roleRepository;
    }

    public async Task<Result<RegistrationResponse>> Handle(RegisterAdminUserCommand request, CancellationToken cancellationToken)
    {
        if (!await _authenticationRepository.IsEmailUniqueAsync(request.newAdminUser.loginId, cancellationToken))
        {
            return Result.Failure<RegistrationResponse>(
                LoginError.UsernameInUse);
        }

        var newUser = _mapper.Map<LoginDetail>(request.newAdminUser);

        newUser.ClientId = null;
        newUser.LawPracticeId = null;
        newUser.LocalCounselId = null;
        newUser.IsAdmin = true;
        newUser.LoginPwd = _securityProvider.Hash(request.newAdminUser.loginPwd);

        var userRole = await _roleRepository.GetRoleFromEnum(DOMAIN.Enums.Roles.Admin.ToString());

        if (userRole == null)
        {
            return Result.Failure<RegistrationResponse>(RegistrationError.MissingRoleByName);
        }

        await _authenticationRepository.AddUserWithRoles(newUser, userRole);

        return new RegistrationResponse
        {
            RegistrationStatus = true,
            UserInformation = _mapper.Map<LoginDetailResponse>(newUser)
        };
    }
}

/// <summary>
/// Register Client User Command Handler.
/// </summary>
internal sealed class RegisterClientUserCommandHandler : ICommandHandler<RegisterClientUserCommand, RegistrationResponse>
{
    private readonly IAuthenticationRepository _authenticationRepository;
    private readonly IRoleRepository _roleRepository;
    private readonly IClientRepository _clientRepository;
    private readonly IMapper _mapper;
    private readonly IApiProvider _apiProvider;
    private readonly ISecurityProvider _securityProvider;

    public RegisterClientUserCommandHandler(
        IAuthenticationRepository authenticationRepository,
        IMapper mapper,
        IApiProvider apiProvider,
        ISecurityProvider securityProvider,
        IRoleRepository roleRepository,
        IClientRepository clientRepository)
    {
        _authenticationRepository = authenticationRepository;
        _mapper = mapper;
        _apiProvider = apiProvider;
        _securityProvider = securityProvider;
        _roleRepository = roleRepository;
        _clientRepository = clientRepository;
    }

    public async Task<Result<RegistrationResponse>> Handle(RegisterClientUserCommand request, CancellationToken cancellationToken)
    {
        try
        {
            if (!await _authenticationRepository.IsEmailUniqueAsync(request.newClientUser.loginId, cancellationToken))
            {
                return Result.Failure<RegistrationResponse>(
                    LoginError.UsernameInUse);
            }

            var newUser = _mapper.Map<LoginDetail>(request.newClientUser);

            newUser.LawPracticeId = null;
            newUser.LocalCounselId = null;
            newUser.LoginPwd = _securityProvider.Hash(request.newClientUser.loginPwd);

            var userRole = await _roleRepository.GetRoleFromEnum(DOMAIN.Enums.Roles.Client.ToString());

            if (userRole == null)
            {
                return Result.Failure<RegistrationResponse>(RegistrationError.MissingRoleByName);
            }

            var clientInfo = await _clientRepository.GetByIdAsync(request.newClientUser.clientId);

            if (clientInfo == null)
            {
                return Result.Failure<RegistrationResponse>(ClientError.InvalidClientId);
            }

            await _authenticationRepository.AddUserWithRoles(newUser, userRole);

            return new RegistrationResponse
            {
                RegistrationStatus = true,
                UserInformation = _mapper.Map<LoginDetailResponse>(newUser)
            };
        }
        catch (Exception ex)
        {
            return Result.Failure<RegistrationResponse>(new Error("500", ex.Message));
        }
    }
}

/// <summary>
/// Register Law Practice User Command Handler.
/// </summary>
internal sealed class RegisterLPUserCommandHandler : ICommandHandler<RegisterLPUserCommand, RegistrationResponse>
{
    private readonly IAuthenticationRepository _authenticationRepository;
    private readonly IRoleRepository _roleRepository;
    private readonly IMapper _mapper;
    private readonly IApiProvider _apiProvider;
    private readonly ISecurityProvider _securityProvider;

    public RegisterLPUserCommandHandler(
        IAuthenticationRepository authenticationRepository,
        IMapper mapper,
        IApiProvider apiProvider,
        ISecurityProvider securityProvider,
        IRoleRepository roleRepository)
    {
        _authenticationRepository = authenticationRepository;
        _mapper = mapper;
        _apiProvider = apiProvider;
        _securityProvider = securityProvider;
        _roleRepository = roleRepository;
    }

    public async Task<Result<RegistrationResponse>> Handle(RegisterLPUserCommand request, CancellationToken cancellationToken)
    {
        if (!await _authenticationRepository.IsEmailUniqueAsync(request.newLPUser.loginId, cancellationToken))
        {
            return Result.Failure<RegistrationResponse>(
                LoginError.UsernameInUse);
        }

        var newUser = _mapper.Map<LoginDetail>(request.newLPUser);

        newUser.ClientId = null;
        newUser.LocalCounselId = null;
        newUser.LoginPwd = _securityProvider.Hash(request.newLPUser.loginPwd);

        var userRole = await _roleRepository.GetRoleFromEnum(DOMAIN.Enums.Roles.LawPractice.ToString());

        if (userRole == null)
        {
            return Result.Failure<RegistrationResponse>(RegistrationError.MissingRoleByName);
        }

        await _authenticationRepository.AddUserWithRoles(newUser, userRole);

        return new RegistrationResponse
        {
            RegistrationStatus = true,
            UserInformation = _mapper.Map<LoginDetailResponse>(newUser)
        };
    }
}

/// <summary>
/// Register Local Counsel User Command Handler.
/// </summary>
internal sealed class RegisterLCUserCommandHandler : ICommandHandler<RegisterLCUserCommand, RegistrationResponse>
{
    private readonly IAuthenticationRepository _authenticationRepository;
    private readonly IRoleRepository _roleRepository;
    private readonly IMapper _mapper;
    private readonly IApiProvider _apiProvider;
    private readonly ISecurityProvider _securityProvider;

    public RegisterLCUserCommandHandler(
        IAuthenticationRepository authenticationRepository,
        IMapper mapper,
        IApiProvider apiProvider,
        ISecurityProvider securityProvider,
        IRoleRepository roleRepository)
    {
        _authenticationRepository = authenticationRepository;
        _mapper = mapper;
        _apiProvider = apiProvider;
        _securityProvider = securityProvider;
        _roleRepository = roleRepository;
    }

    public async Task<Result<RegistrationResponse>> Handle(RegisterLCUserCommand request, CancellationToken cancellationToken)
    {
        if (!await _authenticationRepository.IsEmailUniqueAsync(request.newLCUser.loginId, cancellationToken))
        {
            return Result.Failure<RegistrationResponse>(
                LoginError.UsernameInUse);
        }

        var newUser = _mapper.Map<LoginDetail>(request.newLCUser);

        newUser.ClientId = null;
        newUser.LawPracticeId = null;
        newUser.LoginPwd = _securityProvider.Hash(request.newLCUser.loginPwd);

        var userRole = await _roleRepository.GetRoleFromEnum(DOMAIN.Enums.Roles.LocalCounsel.ToString());

        if (userRole == null)
        {
            return Result.Failure<RegistrationResponse>(RegistrationError.MissingRoleByName);
        }

        await _authenticationRepository.AddUserWithRoles(newUser, userRole);

        return new RegistrationResponse
        {
            RegistrationStatus = true,
            UserInformation = _mapper.Map<LoginDetailResponse>(newUser)
        };
    }
}
