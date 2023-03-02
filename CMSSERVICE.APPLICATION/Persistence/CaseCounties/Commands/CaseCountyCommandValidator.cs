using FluentValidation;

namespace CMSSERVICE.APPLICATION.Persistence.CaseCounties.Commands;

internal class RegisterCaseCountyCommandValidator : AbstractValidator<RegisterCaseCountyCommand>
{
    public RegisterCaseCountyCommandValidator()
    {
        RuleFor(x => x.caseCounty.County).NotEmpty().WithMessage("County Name is required").MaximumLength(150).WithMessage("Maximum length for County Name is 150 characters.");

        RuleFor(x => x.caseCounty.CaseStateId).NotNull().WithMessage("Case State id is required").GreaterThan(0).WithMessage("Case State id should be greater than 0.");
    }
}
