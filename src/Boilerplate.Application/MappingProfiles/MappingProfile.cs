﻿using AutoMapper;
using Boilerplate.Application.DTOs;
using Boilerplate.Domain.Entities;

namespace Boilerplate.Application.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            /// Get Hero Map
            CreateMap<Hero, GetHeroDTO>().ReverseMap();
            CreateMap<Team, GetHeroTeamDTO>().ReverseMap();
            ///
        }
    }
}
