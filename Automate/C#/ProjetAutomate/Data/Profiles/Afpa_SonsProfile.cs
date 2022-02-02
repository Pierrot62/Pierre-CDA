using AutoMapper;
using ProjetAutomate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProjetAutomate.Data.Dtos.Afpa_SonsDTO;

namespace ProjetAutomate.Data.Profiles
{
    public class Afpa_SonsProfile : Profile
    {
        public Afpa_SonsProfile() 
        {
            CreateMap<Afpa_Son, Afpa_SonsDTOIn>();
            CreateMap<Afpa_SonsDTOIn, Afpa_Son>();

            CreateMap<Afpa_Son, Afpa_SonsDTOOut>();
            CreateMap<Afpa_SonsDTOOut, Afpa_Son>();
        }
    }
}
