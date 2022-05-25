using AutoMapper;
using DemoEF.Data.Dtos;
using DemoEF.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEF.Data.Profiles
{
    public class MatchsProfile : Profile
    {
        public MatchsProfile()
        {
            CreateMap<Matchs, MatchsDTO>();
            CreateMap<MatchsDTO, Matchs>();

        }
    }
}
