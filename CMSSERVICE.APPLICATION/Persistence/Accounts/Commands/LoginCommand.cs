using CMSSERVICE.DOMAIN.Contracts.Responses.Authentication;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts.Commands;

public record LoginCommand(string email, string password) : ICommand<LoginResponse>;
