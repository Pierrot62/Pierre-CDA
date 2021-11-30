using AutoMapper;
using GestionAeroport.Data.Dtos;
using GestionAeroport.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionAeroport.Data.Profiles
{
    public class PiloteProfiles : Profile
    {
        public PiloteProfiles()
        {
            CreateMap<Pilote, PiloteDTOIn>();
            CreateMap<PiloteDTOIn, Pilote>();
            CreateMap<Pilote, PiloteDTOOut>();
            CreateMap<PiloteDTOOut, Pilote>();
        }
    }
}
