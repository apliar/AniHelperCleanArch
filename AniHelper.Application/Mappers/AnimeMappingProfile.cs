using AniHelper.Application.Commands;
using AniHelper.Application.Responses;
using AniHelper.Core.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniHelper.Application.Mappers
{
    public class AnimeMappingProfile: Profile
    {
        public AnimeMappingProfile()
        {
            CreateMap<Anime, AnimeResponse>().ReverseMap();
            CreateMap<Anime, CreateAnimeCommand>().ReverseMap();
        }
    }
}
