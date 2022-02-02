using AutoMapper;
using ProjetAutomate.Data.Dtos;
using ProjetAutomate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Profiles
{
    public class Afpa_ErreursDTO : Profile
    {
        public Afpa_ErreursDTO()
        {
            CreateMap<Afpa_Erreur, Afpa_ErreursDTOIn>();
            CreateMap<Afpa_ErreursDTOIn, Afpa_Erreur>();
            CreateMap<Afpa_Erreur, Afpa_ErreursDTOOut>();
            CreateMap<Afpa_ErreursDTOOut, Afpa_Erreur>();
        }
        
    }
}
