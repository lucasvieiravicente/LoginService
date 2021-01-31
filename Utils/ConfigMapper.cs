using AutoMapper;
using LoginService.Domain.Models;
using LoginService.Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginService.Utils
{
    public class ConfigMapper : Profile
    {
        public ConfigMapper()
        {
            CreateMap<SignUpRequest, User>()
                 .ForMember(dest => dest.Password, opts => opts.MapFrom(src => HashUtil.HashPassword(src.Password)));
        }
    }
}
