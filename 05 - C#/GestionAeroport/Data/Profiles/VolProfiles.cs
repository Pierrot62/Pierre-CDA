using AutoMapper;
using GestionAeroport.Data.Dtos;
using GestionAeroport.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionAeroport.Data.Profiles
{
    public class VolProfiles : Profile
    {
        public VolProfiles()
        {
            CreateMap<Vol, VolDTOIn>();
            CreateMap<VolDTOIn, Vol>();
            CreateMap<Vol, VolDTOOut>();
            CreateMap<VolDTOOut, Vol>();
        }
    }
}
