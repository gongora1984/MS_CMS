using AutoMapper;

namespace CMSSERVICE.APPLICATION.Persistence.Mapper.CaseDistricts;

public static class CaseDistrictMapper
{
    private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
            cfg.AddProfile<CaseDistrictMapperProfile>();
        });

        var mapper = config.CreateMapper();

        return mapper;
    });

    public static IMapper Mapper => Lazy.Value;
}
