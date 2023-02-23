using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.Authentication;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts.Commands.RegistrationCommands;

public record RegisterClientUserCommand(UserRequest newClientUser) : ICommand<LoginResponse>;
public record RegisterLPUserCommand(UserRequest newClientUser) : ICommand<LoginResponse>;
public record RegisterLCUserCommand(UserRequest newClientUser) : ICommand<LoginResponse>;
