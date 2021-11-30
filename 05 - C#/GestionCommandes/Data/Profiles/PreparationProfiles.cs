using AutoMapper;
using GestionCommandes.Data.Dtos;
using GestionCommandes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionCommandes.Data.Profiles
{
    public class PreparationProfiles : Profile
    {
        public PreparationProfiles()
        {
            CreateMap<PreparationDTO, Preparation>();
            CreateMap<Preparation, PreparationDTO>();
            CreateMap<PreparationDTOIn, Preparation>();
            CreateMap<Preparation, PreparationDTOIn>();
        }
    }
}
