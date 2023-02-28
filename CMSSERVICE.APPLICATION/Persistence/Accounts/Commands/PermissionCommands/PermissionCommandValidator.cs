using FluentValidation;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts.Commands.PermissionCommands;

internal class RegisterPermissionCommandValidator : AbstractValidator<RegisterPermissionCommand>
{
    public RegisterPermissionCommandValidator()
    {
        RuleFor(x => x.permission.name).NotEmpty().WithMessage("Permission name is required").MaximumLength(250).WithMessage("Maximum length for address 1 is 250 characters.");
    }
}

internal class RegisterRoleCommandValidator : AbstractValidator<RegisterRoleCommand>
{
    public RegisterRoleCommandValidator()
    {
        RuleFor(x => x.role.name).NotEmpty().WithMessage("Role name is required").MaximumLength(250).WithMessage("Maximum length for address 1 is 250 characters.");
    }
}

internal class RegisterRolePermissionCommandValidator : AbstractValidator<RegisterRolePermissionCommand>
{
    public RegisterRolePermissionCommandValidator()
    {
        RuleFor(x => x.rolepermission.appPermissionId).NotNull().WithMessage("Permission Id is required").GreaterThan(0).WithMessage("Permission Id should be greater than 0.");
        RuleFor(x => x.rolepermission.appRoleId).NotNull().WithMessage("Role Id is required").GreaterThan(0).WithMessage("Permission Id should be greater than 0.");
    }
}
