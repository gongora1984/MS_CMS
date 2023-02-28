using CMSSERVICE.DOMAIN.Contracts.Responses.AppPermissions;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts.Queries.PermissionQueries;

public record GetAllRoleQuery : IQuery<AllRoleResponse>;

public record GetRoleByIdQuery(int id) : IQuery<RoleResponse>;

public record GetRoleByNameQuery(string name) : IQuery<RoleResponse>;

public record GetAllPermissionQuery : IQuery<AllPermissionResponse>;

public record GetPermissionByIdQuery(int id) : IQuery<PermissionResponse>;

public record GetPermissionByNameQuery(string name) : IQuery<PermissionResponse>;
