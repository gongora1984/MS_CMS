using FluentValidation;

namespace CMSSERVICE.APPLICATION.Persistence.CaseStates.Commands;

internal class RegisterCaseStateCommandValidator : AbstractValidator<RegisterCaseStateCommand>
{
    public RegisterCaseStateCommandValidator()
    {
        RuleFor(x => x.caseState.StateAbbrev).NotEmpty().WithMessage("State Abbreviation is required").MaximumLength(2).WithMessage("Maximum length for State Abbreviation is 2 characters.");

        RuleFor(x => x.caseState.StateName).NotEmpty().WithMessage("State Name is required").MaximumLength(100).WithMessage("Maximum length for State Name is 100 characters.");
    }
}
