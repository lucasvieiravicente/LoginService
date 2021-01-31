using AutoMapper;
using LoginService.Domain.Models;
using LoginService.Domain.Models.Request;

namespace LoginService.Utils
{
    public class ConfigMapper : Profile
    {
        public ConfigMapper()
        {
            CreateMap<SignUpRequest, User>()
                 .ForMember(dest => dest.Password, opts => opts.MapFrom(src => src.Password));
        }
    }
}
