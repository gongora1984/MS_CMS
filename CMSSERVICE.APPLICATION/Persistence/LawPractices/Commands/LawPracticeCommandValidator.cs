using FluentValidation;

namespace CMSSERVICE.APPLICATION.Persistence.LawPractices.Commands;

internal class LawPracticeCommandValidator : AbstractValidator<RegisterLawPracticeCommand>
{
    public LawPracticeCommandValidator()
    {
        RuleFor(x => x.lp.practiceName).NotEmpty().WithMessage("Law Practice name is required").MaximumLength(250).WithMessage("Maximum length for Law Practice name 1 is 250 characters.");

        RuleFor(x => x.lp.practiceContact).NotEmpty().WithMessage("Law Practice contact is required").MaximumLength(200).WithMessage("Maximum length for Law Practice contact 1 is 200 characters.");

        RuleFor(x => x.lp.address1).NotEmpty().WithMessage("Law Practice address 1 is required").MaximumLength(200).WithMessage("Maximum length for address 1 is 200 characters.");

        RuleFor(x => x.lp.city).NotEmpty().WithMessage("Law Practice city is required").MaximumLength(150).WithMessage("Maximum length for city is 150 characters.");

        RuleFor(x => x.lp.state).NotEmpty().WithMessage("Law Practice state is required").MaximumLength(15).WithMessage("Maximum length for state is 15 characters.");

        RuleFor(x => x.lp.zip).NotEmpty().WithMessage("Law Practice zip is required").MaximumLength(15).WithMessage("Maximum length for zip is 15 characters.");

        RuleFor(x => x.lp.practiceTypeLid).NotNull().WithMessage("Law Practice type id is required").GreaterThan(0).WithMessage("Law Practice type id should be greater than 0.");
    }
}
