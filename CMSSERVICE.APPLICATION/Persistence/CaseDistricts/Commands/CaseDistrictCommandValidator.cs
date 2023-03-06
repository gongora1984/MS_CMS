using FluentValidation;

namespace CMSSERVICE.APPLICATION.Persistence.CaseDistricts.Commands;

internal class RegisterCaseDistrictCommandValidator : AbstractValidator<RegisterCaseDistrictCommand>
{
    public RegisterCaseDistrictCommandValidator()
    {
        RuleFor(x => x.caseDistrict.DistrictName).NotEmpty().WithMessage("District Name is required").MaximumLength(100).WithMessage("Maximum length for District Name is 100 characters.");

        RuleFor(x => x.caseDistrict.CaseStateId).NotNull().WithMessage("Case State id is required").GreaterThan(0).WithMessage("Case State id should be greater than 0.");
    }
}
