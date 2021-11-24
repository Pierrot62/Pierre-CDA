using APISurPlusieurTables.Data.Dtos;
using APISurPlusieurTables.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISurPlusieurTables.Data.Profiles
{
    public class VoitureProfiles : Profile
    {
        public VoitureProfiles()
        {
            CreateMap<Voiture, VoitureDTO>();
            CreateMap<VoitureDTO,Voiture>();
        }
    }
}
