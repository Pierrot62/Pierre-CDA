using AutoMapper;
using GestionAeroport.Data.Dtos;
using GestionAeroport.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionAeroport.Data.Profiles
{
    public class TrajetProfiles : Profile
    {
        public TrajetProfiles()
        {
            CreateMap<Trajet, TrajetDTOIn>();
            CreateMap<TrajetDTOIn, Trajet>();
            CreateMap<Trajet, TrajetDTOOut>();
            CreateMap<TrajetDTOOut, Trajet>();
        }
    }
}
