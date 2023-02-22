using CMSSERVICE.DOMAIN.Contracts.Responses.LoginDetails;

namespace CMSSERVICE.DOMAIN.Contracts.Responses.Authentication;

public class LoginResponse
{
    public string ApiKey { get; set; }

    public bool LoginStatus { get; set; }

    public LoginDetailResponse UserInformation { get; set; }

    public string ErrorMessage { get; set; }
}
