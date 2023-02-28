using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.LawPratices;

namespace CMSSERVICE.APPLICATION.Persistence.LawPractices.Commands;

public record RegisterLawPracticeCommand(LawPracticeRequest lp) : ICommand<LawPracticeResponse>;
