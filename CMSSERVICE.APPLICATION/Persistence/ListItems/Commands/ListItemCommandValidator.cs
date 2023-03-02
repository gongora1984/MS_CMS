using FluentValidation;

namespace CMSSERVICE.APPLICATION.Persistence.ListItems.Commands;

internal class ListItemCommandValidator : AbstractValidator<RegisterListItemCommand>
{
    public ListItemCommandValidator()
    {
        RuleFor(x => x.li.SystemCategory).NotEmpty().WithMessage("System Category is required").MaximumLength(50).WithMessage("Maximum length for SystemCategory 1 is 50 characters.");

        RuleFor(x => x.li.SystemTag).NotEmpty().WithMessage("System Tag is required").MaximumLength(50).WithMessage("Maximum length for System Tag 1 is 50 characters.");

        RuleFor(x => x.li.DisplayText).NotEmpty().WithMessage("Display Text is required").MaximumLength(150).WithMessage("Maximum length for Display Text 1 is 150 characters.");
    }
}
