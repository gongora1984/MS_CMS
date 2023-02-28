using FluentValidation;

namespace CMSSERVICE.APPLICATION.Persistence.Clients.Commands;

internal class ClientCommandValidator : AbstractValidator<RegisterClientCommand>
{
    public ClientCommandValidator()
    {
        RuleFor(x => x.client.clientName).NotEmpty().WithMessage("Client name is required").MaximumLength(200).WithMessage("Maximum length for client name 1 is 200 characters.");

        RuleFor(x => x.client.clientAddress1).NotEmpty().WithMessage("Client address 1 is required").MaximumLength(200).WithMessage("Maximum length for address 1 is 200 characters.");

        RuleFor(x => x.client.clientCity).NotEmpty().WithMessage("Client city is required").MaximumLength(150).WithMessage("Maximum length for city is 150 characters.");

        RuleFor(x => x.client.clientState).NotEmpty().WithMessage("Client state is required").MaximumLength(15).WithMessage("Maximum length for state is 15 characters.");

        RuleFor(x => x.client.clientZip).NotEmpty().WithMessage("Client zip is required").MaximumLength(15).WithMessage("Maximum length for zip is 15 characters.");

        RuleFor(x => x.client.clientBillAddress1).NotEmpty().WithMessage("Client billing address 1 is required").MaximumLength(200).WithMessage("Maximum length for billing address 1 is 200 characters.");

        RuleFor(x => x.client.clientBillCity).NotEmpty().WithMessage("Client billing city is required").MaximumLength(150).WithMessage("Maximum length for billing city is 150 characters.");

        RuleFor(x => x.client.clientBillState).NotEmpty().WithMessage("Client billing state is required").MaximumLength(15).WithMessage("Maximum length for billing state is 15 characters.");

        RuleFor(x => x.client.clientBillZip).NotEmpty().WithMessage("Client billing zip is required").MaximumLength(15).WithMessage("Maximum length for billing zip is 15 characters.");
    }
}
