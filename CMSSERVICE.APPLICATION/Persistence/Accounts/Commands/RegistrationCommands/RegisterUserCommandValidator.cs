using FluentValidation;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts.Commands.RegistrationCommands;

/// <summary>
/// Register Client User Command Validator.
/// </summary>
internal class RegisterClientUserCommandValidator : AbstractValidator<RegisterClientUserCommand>
{
    public RegisterClientUserCommandValidator()
    {
        RuleFor(x => x.newClientUser.loginId).NotEmpty().WithMessage("Email address is required").EmailAddress().WithMessage("A valid email address is required.");

        RuleFor(x => x.newClientUser.loginPwd).NotEmpty().WithMessage("Password is required");

        RuleFor(x => x.newClientUser.address1).NotEmpty().WithMessage("User address 1 is required").MaximumLength(200).WithMessage("Maximum length for address 1 is 200 characters.");

        RuleFor(x => x.newClientUser.city).NotEmpty().WithMessage("User city is required is required").MaximumLength(150).WithMessage("Maximum length for city 1 is 150 characters.");

        RuleFor(x => x.newClientUser.state).NotEmpty().WithMessage("User state is required is required").MaximumLength(15).WithMessage("Maximum length for city 1 is 15 characters.");

        RuleFor(x => x.newClientUser.zip).NotEmpty().WithMessage("Company zip is required is required").MaximumLength(15).WithMessage("Maximum length for zip 1 is 15 characters.");
    }
}

/// <summary>
/// Register Law Practice User Command Validator.
/// </summary>
internal class RegisterLPUserCommandValidator : AbstractValidator<RegisterLPUserCommand>
{
    public RegisterLPUserCommandValidator()
    {
        RuleFor(x => x.newLPUser.loginId).NotEmpty().WithMessage("Email address is required").EmailAddress().WithMessage("A valid email address is required.");

        RuleFor(x => x.newLPUser.loginPwd).NotEmpty().WithMessage("Password is required");

        RuleFor(x => x.newLPUser.address1).NotEmpty().WithMessage("User address 1 is required").MaximumLength(200).WithMessage("Maximum length for address 1 is 200 characters.");

        RuleFor(x => x.newLPUser.city).NotEmpty().WithMessage("User city is required is required").MaximumLength(150).WithMessage("Maximum length for city 1 is 150 characters.");

        RuleFor(x => x.newLPUser.state).NotEmpty().WithMessage("User state is required is required").MaximumLength(15).WithMessage("Maximum length for city 1 is 15 characters.");

        RuleFor(x => x.newLPUser.zip).NotEmpty().WithMessage("Company zip is required is required").MaximumLength(15).WithMessage("Maximum length for zip 1 is 15 characters.");
    }
}

/// <summary>
/// Register Local Counsel User Command Validator.
/// </summary>
internal class RegisterLCUserCommandValidator : AbstractValidator<RegisterLCUserCommand>
{
    public RegisterLCUserCommandValidator()
    {
        RuleFor(x => x.newLCUser.loginId).NotEmpty().WithMessage("Email address is required").EmailAddress().WithMessage("A valid email address is required.");

        RuleFor(x => x.newLCUser.loginPwd).NotEmpty().WithMessage("Password is required");

        RuleFor(x => x.newLCUser.address1).NotEmpty().WithMessage("User address 1 is required").MaximumLength(200).WithMessage("Maximum length for address 1 is 200 characters.");

        RuleFor(x => x.newLCUser.city).NotEmpty().WithMessage("User city is required is required").MaximumLength(150).WithMessage("Maximum length for city 1 is 150 characters.");

        RuleFor(x => x.newLCUser.state).NotEmpty().WithMessage("User state is required is required").MaximumLength(15).WithMessage("Maximum length for city 1 is 15 characters.");

        RuleFor(x => x.newLCUser.zip).NotEmpty().WithMessage("Company zip is required is required").MaximumLength(15).WithMessage("Maximum length for zip 1 is 15 characters.");
    }
}
