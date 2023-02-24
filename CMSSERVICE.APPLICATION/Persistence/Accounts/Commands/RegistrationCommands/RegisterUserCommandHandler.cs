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
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IApiProvider _apiProvider;

    public RegisterAdminUserCommandHandler(IAuthenticationRepository authenticationRepository, IMapper mapper, IUnitOfWork unitOfWork, IApiProvider apiProvider)
    {
        _authenticationRepository = authenticationRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _apiProvider = apiProvider;
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

        _authenticationRepository.Add(newUser);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        ////string token = _apiProvider.GenerateApiKey(newUser);

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
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IApiProvider _apiProvider;

    public RegisterClientUserCommandHandler(IAuthenticationRepository authenticationRepository, IMapper mapper, IUnitOfWork unitOfWork, IApiProvider apiProvider)
    {
        _authenticationRepository = authenticationRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _apiProvider = apiProvider;
    }

    public async Task<Result<RegistrationResponse>> Handle(RegisterClientUserCommand request, CancellationToken cancellationToken)
    {
        if (!await _authenticationRepository.IsEmailUniqueAsync(request.newClientUser.loginId, cancellationToken))
        {
            return Result.Failure<RegistrationResponse>(
                LoginError.UsernameInUse);
        }

        var newUser = _mapper.Map<LoginDetail>(request.newClientUser);

        newUser.LawPracticeId = null;
        newUser.LocalCounselId = null;

        _authenticationRepository.Add(newUser);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        ////string token = _apiProvider.GenerateApiKey(newUser);

        return new RegistrationResponse
        {
            RegistrationStatus = true,
            UserInformation = _mapper.Map<LoginDetailResponse>(newUser)
        };
    }
}

/// <summary>
/// Register Law Practice User Command Handler.
/// </summary>
internal sealed class RegisterLPUserCommandHandler : ICommandHandler<RegisterLPUserCommand, RegistrationResponse>
{
    private readonly IAuthenticationRepository _authenticationRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IApiProvider _apiProvider;

    public RegisterLPUserCommandHandler(IAuthenticationRepository authenticationRepository, IMapper mapper, IUnitOfWork unitOfWork, IApiProvider apiProvider)
    {
        _authenticationRepository = authenticationRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _apiProvider = apiProvider;
    }

    public async Task<Result<RegistrationResponse>> Handle(RegisterLPUserCommand request, CancellationToken cancellationToken)
    {
        if (!await _authenticationRepository.IsEmailUniqueAsync(request.newClientUser.loginId, cancellationToken))
        {
            return Result.Failure<RegistrationResponse>(
                LoginError.UsernameInUse);
        }

        var newUser = _mapper.Map<LoginDetail>(request.newClientUser);

        newUser.ClientId = null;
        newUser.LocalCounselId = null;

        _authenticationRepository.Add(newUser);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        ////string token = _apiProvider.GenerateApiKey(newUser);

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
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IApiProvider _apiProvider;

    public RegisterLCUserCommandHandler(IAuthenticationRepository authenticationRepository, IMapper mapper, IUnitOfWork unitOfWork, IApiProvider apiProvider)
    {
        _authenticationRepository = authenticationRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _apiProvider = apiProvider;
    }

    public async Task<Result<RegistrationResponse>> Handle(RegisterLCUserCommand request, CancellationToken cancellationToken)
    {
        if (!await _authenticationRepository.IsEmailUniqueAsync(request.newClientUser.loginId, cancellationToken))
        {
            return Result.Failure<RegistrationResponse>(
                LoginError.UsernameInUse);
        }

        var newUser = _mapper.Map<LoginDetail>(request.newClientUser);

        newUser.ClientId = null;
        newUser.LawPracticeId = null;

        _authenticationRepository.Add(newUser);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        ////string token = _apiProvider.GenerateApiKey(newUser);

        return new RegistrationResponse
        {
            RegistrationStatus = true,
            UserInformation = _mapper.Map<LoginDetailResponse>(newUser)
        };
    }
}
