using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.LocalCounsels;

namespace CMSSERVICE.APPLICATION.Persistence.LocalCounsels.Commands;

public record RegisterLocalCounselCommand(LocalCounselRequest lc) : ICommand<LocalCounselResponse>;
