using AutoMapper;
using Domain.AutoMapper.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings(IMapperConfigurationExpression cfg)
        {
            cfg.AllowNullCollections = true;
            cfg.AddProfile<UserMapEF>();
        }
    }
}
