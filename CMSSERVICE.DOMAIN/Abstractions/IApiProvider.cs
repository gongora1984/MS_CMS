using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Abstractions;

public interface IApiProvider
{
    string GenerateApiKey(LoginDetail user);
}
