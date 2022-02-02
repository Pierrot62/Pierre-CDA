using AutoMapper;
using ProjetAutomate.Data.Dtos;
using ProjetAutomate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Profiles
{
    public class Afpa_CouleursProfile:Profile
    {
        public Afpa_CouleursProfile()
        {
            CreateMap<Afpa_Couleur, Afpa_CouleursDTOIn>();
            CreateMap<Afpa_CouleursDTOIn, Afpa_Couleur>();
            CreateMap<Afpa_Couleur, Afpa_CouleursDTOOut>();
            CreateMap<Afpa_CouleursDTOOut, Afpa_Couleur>();
        }
    }
}
