using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.AppPermissions;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts.Commands.PermissionCommands;

/// <summary>
/// Register Permission Command Handler.
/// </summary>
internal sealed class RegisterPermissionCommandHandler : ICommandHandler<RegisterPermissionCommand, PermissionResponse>
{
    private readonly IPermissionRepository _permissionRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RegisterPermissionCommandHandler(IPermissionRepository permissionRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _permissionRepository = permissionRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<PermissionResponse>> Handle(RegisterPermissionCommand request, CancellationToken cancellationToken)
    {
        if (!await _permissionRepository.IsNameUniqueAsync(request.permission.name, cancellationToken))
        {
            return Result.Failure<PermissionResponse>(
                PermissionError.PermissionNameInUse);
        }

        try
        {
            var newPermission = _mapper.Map<AppPermission>(request.permission);

            _permissionRepository.AddPermission(newPermission);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<PermissionResponse>(newPermission);
        }
        catch (Exception ex)
        {
            return Result.Failure<PermissionResponse>(new Error("Internal Error", ex.Message));
        }
    }
}

/// <summary>
/// Register Role Command Handler.
/// </summary>
internal sealed class RegisterRoleCommandHandler : ICommandHandler<RegisterRoleCommand, RoleResponse>
{
    private readonly IRoleRepository _roleRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RegisterRoleCommandHandler(IRoleRepository roleRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _roleRepository = roleRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<RoleResponse>> Handle(RegisterRoleCommand request, CancellationToken cancellationToken)
    {
        if (!await _roleRepository.IsNameUniqueAsync(request.role.name, cancellationToken))
        {
            return Result.Failure<RoleResponse>(
                RoleError.RoleNameInUse);
        }

        try
        {
            var newPermission = _mapper.Map<AppRole>(request.role);

            _roleRepository.AddRole(newPermission);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<RoleResponse>(newPermission);
        }
        catch (Exception ex)
        {
            return Result.Failure<RoleResponse>(new Error("Internal Error", ex.Message));
        }
    }
}

/// <summary>
/// Register Role Permission Command Handler.
/// </summary>
internal sealed class RegisterRolePermissionCommandHandler : ICommandHandler<RegisterRolePermissionCommand, IEnumerable<RolePermissionResponse>>
{
    private readonly IPermissionRepository _permissionRepository;
    private readonly IRoleRepository _roleRepository;
    private readonly IRolePermissionRepository _rolePermissionRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RegisterRolePermissionCommandHandler(IPermissionRepository permissionRepository, IMapper mapper, IUnitOfWork unitOfWork, IRoleRepository roleRepository, IRolePermissionRepository rolePermissionRepository)
    {
        _permissionRepository = permissionRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _roleRepository = roleRepository;
        _rolePermissionRepository = rolePermissionRepository;
    }

    public async Task<Result<IEnumerable<RolePermissionResponse>>> Handle(RegisterRolePermissionCommand request, CancellationToken cancellationToken)
    {
        var rtn = new List<RolePermissionResponse>();

        var roleData = await _roleRepository.GetByIdAsync(request.rolepermission.appRoleId, cancellationToken);

        if (roleData is null)
        {
            return Result.Failure<IEnumerable<RolePermissionResponse>>(
                RoleError.NotFound(request.rolepermission.appRoleId));
        }

        var permissions = request.rolepermission.permissions;

        if (!permissions.Any())
        {
            return Result.Failure<IEnumerable<RolePermissionResponse>>(
                            PermissionError.PermissionMissing);
        }

        try
        {
            foreach (var permission in permissions)
            {
                var permissionData = await _permissionRepository.GetByNameAsync(permission.name);

                if (permissionData != null)
                {
                    var newPermission = new AppRolePermission
                    {
                        AppRoleId = roleData.Id,
                        AppPermissionId = permissionData.Id
                    };

                    _rolePermissionRepository.AddRolePermission(newPermission);

                    await _unitOfWork.SaveChangesAsync();

                    rtn.Add(_mapper.Map<RolePermissionResponse>(newPermission));
                }
            }

            return rtn;
        }
        catch (Exception ex)
        {
            return Result.Failure<IEnumerable<RolePermissionResponse>>(new Error("Internal Error", ex.Message));
        }
    }
}

/// <summary>
/// Register User-Role Command Handler.
/// </summary>
internal sealed class RegisterUserRoleCommandHandler : ICommandHandler<RegisterUserRoleCommand, IEnumerable<UserRoleResponse>>
{
    private readonly IAuthenticationRepository _authenticationRepository;
    private readonly IRoleRepository _roleRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RegisterUserRoleCommandHandler(IAuthenticationRepository authenticationRepository, IMapper mapper, IUnitOfWork unitOfWork, IRoleRepository roleRepository)
    {
        _authenticationRepository = authenticationRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _roleRepository = roleRepository;
    }

    public async Task<Result<IEnumerable<UserRoleResponse>>> Handle(RegisterUserRoleCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var rtn = new List<UserRoleResponse>();
            var userData = await _authenticationRepository.GetByIdAsync(request.userRoleRequest.loginDetailId, cancellationToken);
            if (userData is null)
            {
                return Result.Failure<IEnumerable<UserRoleResponse>>(
                    LoginError.NotFound);
            }

            var roles = request.userRoleRequest.roles;

            if (!roles.Any())
            {
                return Result.Failure<IEnumerable<UserRoleResponse>>(
                                RoleError.RoleMissing);
            }

            foreach (var role in roles)
            {
                var roleData = await _roleRepository.GetByNameAsync(role.name, cancellationToken);

                if (roleData != null)
                {
                    var newUserRole = new AppRoleLoginDetail
                    {
                        LoginDetailId = userData.Id,
                        AppRoleId = roleData.Id
                    };

                    _roleRepository.AddUserRole(newUserRole);
                    await _unitOfWork.SaveChangesAsync();
                    rtn.Add(_mapper.Map<UserRoleResponse>(newUserRole));
                }
            }

            return rtn;
        }
        catch (Exception ex)
        {
            return Result.Failure<IEnumerable<UserRoleResponse>>(new Error("Internal Error", ex.Message));
        }
    }
}
