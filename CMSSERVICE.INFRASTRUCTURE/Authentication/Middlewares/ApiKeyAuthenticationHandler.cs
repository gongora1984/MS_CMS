using CMSSERVICE.DOMAIN.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Encodings.Web;

namespace CMSSERVICE.INFRASTRUCTURE.Authentication.Middlewares;

public class ApiKeyAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
{
    private readonly ApiOptions _apiOptions;
    private readonly ApplicationDbContext _context;

    public ApiKeyAuthenticationHandler(
        IOptionsMonitor<AuthenticationSchemeOptions> options,
        ILoggerFactory logger,
        UrlEncoder encoder,
        ISystemClock clock,
        IOptions<ApiOptions> apiOptions,
        ApplicationDbContext context)
        : base(options, logger, encoder, clock)
    {
        _apiOptions = apiOptions.Value;
        _context = context;
    }

    public string ApiKeyHeaderHandler { get; set; }

    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        ApiKeyHeaderHandler = _apiOptions.ApiKeyHeaderName;

        if (!Request.Headers.ContainsKey(ApiKeyHeaderHandler))
        {
            return AuthenticateResult.Fail("Header Not Found.");
        }

        var apiKeyToValidate = Request.Headers[ApiKeyHeaderHandler];

        var userLogin = await _context.Set<LoginDetail>()
                .FirstOrDefaultAsync(uak => uak.AccessToken == apiKeyToValidate.ToString());

        if (userLogin == null)
        {
            return AuthenticateResult.Fail("Invalid key.");
        }

        if ((Convert.ToDateTime(userLogin.LastLogin).Date - DateTime.UtcNow.Date).Minutes > Convert.ToInt32(_apiOptions.ApiKeyExpirationMinutes))
        {
            return AuthenticateResult.Fail("Api key expired. Please re-authenticate");
        }

        return AuthenticateResult.Success(CreateTicket(userLogin));
    }

    private AuthenticationTicket CreateTicket(LoginDetail user)
    {
        var role = string.Empty;

        if (user.ClientId != null)
        {
            role = "Client";
        }

        if (user.LawPracticeId != null)
        {
            role = "LP";
        }

        if (user.LocalCounselId != null)
        {
            role = "LC";
        }

        var claims = new[]
        {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.LoginUserName),
                new Claim(ClaimTypes.Email, user.LoginId),
                new Claim(ClaimTypes.Role, role)
        };

        var identity = new ClaimsIdentity(claims, Scheme.Name);
        var principal = new ClaimsPrincipal(identity);
        var ticket = new AuthenticationTicket(principal, Scheme.Name);

        return ticket;
    }
}
