using AutoMapper;
using GestionAeroport.Data.Dtos;
using GestionAeroport.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionAeroport.Data.Profiles
{
    public class AvionProfiles : Profile
    {
        public AvionProfiles()
        {
            CreateMap<Avion, AvionDTOIn>();
            CreateMap<AvionDTOIn, Avion>();
            CreateMap<Avion, AvionDTOOut>();
            CreateMap<AvionDTOOut, Avion>();
        }
    }
}
