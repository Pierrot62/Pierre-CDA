using AutoMapper;
using ProjetAutomate.Data.Dtos;
using ProjetAutomate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Profiles
{
    public class Afpa_CadencesProfile : Profile
    {
        public Afpa_CadencesProfile() 
        {
            CreateMap<Afpa_Cadence, Afpa_CadencesDTOOut>();
            CreateMap<Afpa_CadencesDTOOut,  Afpa_Cadence>();

            CreateMap<Afpa_Cadence, Afpa_CadencesDTOIn>();
            CreateMap<Afpa_CadencesDTOIn, Afpa_Cadence>();
        }
    }
}
