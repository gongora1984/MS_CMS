using AutoMapper;
using CMSSERVICE.DOMAIN.Abstractions;
using CMSSERVICE.DOMAIN.Contracts.Responses.AppPermissions;
using CMSSERVICE.DOMAIN.Entities;
using CMSSERVICE.DOMAIN.Repositories;
using static CMSSERVICE.DOMAIN.Errors.DomainErrors;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts.Commands.PermissionCommands;

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

            await _permissionRepository.AddPermission(newPermission);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<PermissionResponse>(newPermission);
        }
        catch (Exception ex)
        {
            return Result.Failure<PermissionResponse>(new Error("Internal Error", ex.Message));
        }
    }
}

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

            await _roleRepository.AddRole(newPermission);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<RoleResponse>(newPermission);
        }
        catch (Exception ex)
        {
            return Result.Failure<RoleResponse>(new Error("Internal Error", ex.Message));
        }
    }
}

internal sealed class RegisterRolePermissionCommandHandler : ICommandHandler<RegisterRolePermissionCommand, RolePermissionResponse>
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

    public async Task<Result<RolePermissionResponse>> Handle(RegisterRolePermissionCommand request, CancellationToken cancellationToken)
    {
        if (await _permissionRepository.GetByIdAsync(request.rolepermission.appPermissionId, cancellationToken) is null)
        {
            return Result.Failure<RolePermissionResponse>(
                PermissionError.PermissionNotFound);
        }

        if (await _roleRepository.GetByIdAsync(request.rolepermission.appRoleId, cancellationToken) is null)
        {
            return Result.Failure<RolePermissionResponse>(
                RoleError.RoleNotFound);
        }

        try
        {
            var newPermission = _mapper.Map<AppRolePermission>(request.rolepermission);

            await _rolePermissionRepository.AddRolePermission(newPermission);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<RolePermissionResponse>(newPermission);
        }
        catch (Exception ex)
        {
            return Result.Failure<RolePermissionResponse>(new Error("Internal Error", ex.Message));
        }
    }
}
