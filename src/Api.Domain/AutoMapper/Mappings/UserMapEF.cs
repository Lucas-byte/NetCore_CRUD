using AutoMapper.Configuration;
using Domain.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.AutoMapper.Mappings
{
    public class UserMapEF : MapperConfigurationExpression
    {
        public UserMapEF()
        {
            CreateMap<UserDto, UserEF>()
                .ReverseMap();
        }
    }
}
