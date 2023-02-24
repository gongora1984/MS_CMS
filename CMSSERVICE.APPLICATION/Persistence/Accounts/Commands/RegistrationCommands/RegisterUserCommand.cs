using CMSSERVICE.DOMAIN.Contracts.Requests;
using CMSSERVICE.DOMAIN.Contracts.Responses.Authentication;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts.Commands.RegistrationCommands;

public record RegisterAdminUserCommand(UserRequest newAdminUser) : ICommand<RegistrationResponse>;
public record RegisterClientUserCommand(UserRequest newClientUser) : ICommand<RegistrationResponse>;
public record RegisterLPUserCommand(UserRequest newLPUser) : ICommand<RegistrationResponse>;
public record RegisterLCUserCommand(UserRequest newLCUser) : ICommand<RegistrationResponse>;
