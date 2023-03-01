namespace CMSSERVICE.DOMAIN.Contracts.Requests;

public record UserRoleRequest(int loginDetailId, List<RoleRequest> roles);
