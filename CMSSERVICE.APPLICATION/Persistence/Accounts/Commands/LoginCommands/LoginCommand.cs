using CMSSERVICE.DOMAIN.Contracts.Responses.Authentication;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts.Commands.LoginCommands;

public record LoginCommand(string email, string password) : ICommand<LoginResponse>;
