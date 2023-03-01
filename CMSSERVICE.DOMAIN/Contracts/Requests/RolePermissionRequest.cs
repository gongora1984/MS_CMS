namespace CMSSERVICE.DOMAIN.Contracts.Requests;

public record RolePermissionRequest(IEnumerable<PermissionRequest> permissions, int appRoleId);
