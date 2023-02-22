using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Contracts.Responses;

public class LoginResponse
{
    public string ApiKey { get; set; }

    public bool LoginStatus { get; set; }

    public LoginDetail UserInformation { get; set; }

    public string ErrorMessage { get; set; }
}
