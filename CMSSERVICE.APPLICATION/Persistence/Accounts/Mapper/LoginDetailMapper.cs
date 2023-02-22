using AutoMapper;

namespace CMSSERVICE.APPLICATION.Persistence.Accounts.Mapper;

public static class LoginDetailMapper
{
    private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
            cfg.AddProfile<LoginDetailMapperProfile>();
        });

        var mapper = config.CreateMapper();

        return mapper;
    });

    public static IMapper Mapper => Lazy.Value;
}
