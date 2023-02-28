using FluentValidation;

namespace CMSSERVICE.APPLICATION.Persistence.LocalCounsels.Commands;

internal class LocalCounselCommandValidator : AbstractValidator<RegisterLocalCounselCommand>
{
    public LocalCounselCommandValidator()
    {
        RuleFor(x => x.lc.lcName).NotEmpty().WithMessage("Local Counsel name is required").MaximumLength(150).WithMessage("Maximum length for Local Counsel name 1 is 150 characters.");

        RuleFor(x => x.lc.lcCompanyName).NotEmpty().WithMessage("Local Counsel contact is required").MaximumLength(200).WithMessage("Maximum length for Local Counsel contact 1 is 200 characters.");

        RuleFor(x => x.lc.lcAddress1).NotEmpty().WithMessage("Local Counsel address 1 is required").MaximumLength(200).WithMessage("Maximum length for address 1 is 200 characters.");

        RuleFor(x => x.lc.lcCity).NotEmpty().WithMessage("Local Counsel city is required").MaximumLength(150).WithMessage("Maximum length for city is 150 characters.");

        RuleFor(x => x.lc.lcState).NotEmpty().WithMessage("Local Counsel state is required").MaximumLength(15).WithMessage("Maximum length for state is 15 characters.");

        RuleFor(x => x.lc.lcZip).NotEmpty().WithMessage("Local Counsel zip is required").MaximumLength(15).WithMessage("Maximum length for zip is 15 characters.");
    }
}
