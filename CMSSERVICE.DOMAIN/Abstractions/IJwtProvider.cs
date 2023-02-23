using CMSSERVICE.DOMAIN.Entities;

namespace CMSSERVICE.DOMAIN.Abstractions;

public interface IJwtProvider
{
    string Generate(LoginDetail user);
}
