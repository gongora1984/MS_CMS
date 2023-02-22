using CMSSERVICE.APPLICATION.Abstractions.Messaging;
using CMSSERVICE.DOMAIN.Contracts.Responses;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts;

public record LoginCommand(string email, string password) : ICommand<LoginResponse>;
