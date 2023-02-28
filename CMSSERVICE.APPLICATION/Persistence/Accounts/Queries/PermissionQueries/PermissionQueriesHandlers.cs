using AutoMapper;
using CMSSERVICE.DOMAIN.Contracts.Responses.AppPermissions;
using CMSSERVICE.DOMAIN.Repositories;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts.Queries.PermissionQueries;

/// <summary>
/// Get list of all roles.
/// </summary>
internal sealed class GetAllRoleQueryHandler : IQueryHandler<GetAllRoleQuery, AllRoleResponse>
{
    private readonly IRoleRepository _roleRepository;
    private readonly IMapper _mapper;

    public GetAllRoleQueryHandler(IRoleRepository roleRepository, IMapper mapper)
    {
        _roleRepository = roleRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllRoleResponse>> Handle(GetAllRoleQuery request, CancellationToken cancellationToken)
    {
        var roles = await _roleRepository.GetAllAsync();

        var rtn = _mapper.Map<AllRoleResponse>(roles);

        return rtn;
    }
}

/// <summary>
/// Get list of all permissions.
/// </summary>
internal sealed class GetAllPermissionQueryHandler : IQueryHandler<GetAllPermissionQuery, AllPermissionResponse>
{
    private readonly IPermissionRepository _permissionRepository;
    private readonly IMapper _mapper;

    public GetAllPermissionQueryHandler(IPermissionRepository permissionRepository, IMapper mapper)
    {
        _permissionRepository = permissionRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllPermissionResponse>> Handle(GetAllPermissionQuery request, CancellationToken cancellationToken)
    {
        var permissions = await _permissionRepository.GetAllAsync();

        var rtn = _mapper.Map<AllPermissionResponse>(permissions);

        return rtn;
    }
}

/// <summary>
/// Get Role By Id Query Handler.
/// </summary>
internal sealed class GetRoleByIdQueryHandler : IQueryHandler<GetRoleByIdQuery, RoleResponse>
{
    private readonly IRoleRepository _roleRepository;
    private readonly IMapper _mapper;

    public GetRoleByIdQueryHandler(IRoleRepository roleRepository, IMapper mapper)
    {
        _roleRepository = roleRepository;
        _mapper = mapper;
    }

    public async Task<Result<RoleResponse>> Handle(GetRoleByIdQuery request, CancellationToken cancellationToken)
    {
        var role = await _roleRepository.GetByIdAsync(request.id);

        if (role is null)
        {
            return Result.Failure<RoleResponse>(new Error(
                "AppRole.Id",
                $"Role with Id {request.id} was not found"));
        }

        var rtn = _mapper.Map<RoleResponse>(role);

        return rtn;
    }
}

/// <summary>
/// Get Permission By Id Query Handler.
/// </summary>
internal sealed class GetPermissionByIdQueryHandler : IQueryHandler<GetPermissionByIdQuery, PermissionResponse>
{
    private readonly IPermissionRepository _permissionRepository;
    private readonly IMapper _mapper;

    public GetPermissionByIdQueryHandler(IPermissionRepository permissionRepository, IMapper mapper)
    {
        _permissionRepository = permissionRepository;
        _mapper = mapper;
    }

    public async Task<Result<PermissionResponse>> Handle(GetPermissionByIdQuery request, CancellationToken cancellationToken)
    {
        var permissions = await _permissionRepository.GetByIdAsync(request.id);

        if (permissions is null)
        {
            return Result.Failure<PermissionResponse>(new Error(
                "AppPermission.Id",
                $"Permission with Id {request.id} was not found"));
        }

        var rtn = _mapper.Map<PermissionResponse>(permissions);

        return rtn;
    }
}

/// <summary>
/// Get Role By Name Query Handler.
/// </summary>
internal sealed class GetRoleByNameQueryHandler : IQueryHandler<GetRoleByNameQuery, RoleResponse>
{
    private readonly IRoleRepository _roleRepository;
    private readonly IMapper _mapper;

    public GetRoleByNameQueryHandler(IRoleRepository roleRepository, IMapper mapper)
    {
        _roleRepository = roleRepository;
        _mapper = mapper;
    }

    public async Task<Result<RoleResponse>> Handle(GetRoleByNameQuery request, CancellationToken cancellationToken)
    {
        var role = await _roleRepository.GetByNameAsync(request.name);

        if (role is null)
        {
            return Result.Failure<RoleResponse>(new Error(
                "AppRole.Name",
                $"Role with Name {request.name} was not found"));
        }

        var rtn = _mapper.Map<RoleResponse>(role);

        return rtn;
    }
}

/// <summary>
/// Get Permission By Name Query Handler.
/// </summary>
internal sealed class GetPermissionByNameQueryHandler : IQueryHandler<GetPermissionByNameQuery, PermissionResponse>
{
    private readonly IPermissionRepository _permissionRepository;
    private readonly IMapper _mapper;

    public GetPermissionByNameQueryHandler(IPermissionRepository permissionRepository, IMapper mapper)
    {
        _permissionRepository = permissionRepository;
        _mapper = mapper;
    }

    public async Task<Result<PermissionResponse>> Handle(GetPermissionByNameQuery request, CancellationToken cancellationToken)
    {
        var permissions = await _permissionRepository.GetByNameAsync(request.name);

        if (permissions is null)
        {
            return Result.Failure<PermissionResponse>(new Error(
                "AppPermission.NotFound",
                $"Permission with Name {request.name} was not found"));
        }

        var rtn = _mapper.Map<PermissionResponse>(permissions);

        return rtn;
    }
}
