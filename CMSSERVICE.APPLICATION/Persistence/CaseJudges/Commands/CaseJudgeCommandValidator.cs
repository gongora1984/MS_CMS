using FluentValidation;

namespace CMSSERVICE.APPLICATION.Persistence.CaseJudges.Commands;

internal class RegisterCaseJudgeCommandValidator : AbstractValidator<RegisterCaseJudgeCommand>
{
    public RegisterCaseJudgeCommandValidator()
    {
        RuleFor(x => x.caseJudge.JudgeName).NotEmpty().WithMessage("Judge Name is required").MaximumLength(150).WithMessage("Maximum length for Judge Name is 150 characters.");

        RuleFor(x => x.caseJudge.CaseCourtId).NotNull().WithMessage("Case Court id is required").GreaterThan(0).WithMessage("Case Court id should be greater than 0.");
    }
}
