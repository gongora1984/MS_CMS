using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Abstractions;

public interface IJwtProvider
{
    Task<string> Generate(LoginDetail user);
}
