using CMSSERVICE.APPLICATION.Abstractions.Messaging;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts;

public record LoginCommand(string email, string password) : ICommand<string>;
