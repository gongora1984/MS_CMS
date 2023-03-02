﻿using AutoMapper;

namespace CMSSERVICE.APPLICATION.Persistence.Mapper.ListItemMappers;

public static class ListItemMapper
{
    private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
            cfg.AddProfile<ListItemMapperProfile>();
        });

        var mapper = config.CreateMapper();

        return mapper;
    });

    public static IMapper Mapper => Lazy.Value;
}
