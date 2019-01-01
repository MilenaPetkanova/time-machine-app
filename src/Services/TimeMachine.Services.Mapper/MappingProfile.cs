using AutoMapper;
using System;
using TimeMachine.Services.Models.TimeMachineUsers;
using TimeMachine.Web.Areas.Identity.Data;

namespace TimeMachine.Services.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TimeMachineUser, UserProfileViewModel>();
            CreateMap<UserProfileViewModel, TimeMachineUser>();
        }
    }
}
