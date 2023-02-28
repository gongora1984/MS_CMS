using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.AppPermissions;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts.Commands.PermissionCommands;

public record RegisterPermissionCommand(PermissionRequest permission) : ICommand<PermissionResponse>;
public record RegisterRoleCommand(RoleRequest role) : ICommand<RoleResponse>;
public record RegisterRolePermissionCommand(RolePermissionRequest rolepermission) : ICommand<RolePermissionResponse>;
