using AutoMapper;
using ProjetAutomate.Data.Dtos;
using ProjetAutomate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Profiles
{
    public class Afpa_LumieresProfile:Profile
    {
        public Afpa_LumieresProfile()
        {
            CreateMap<Afpa_Lumiere,Afpa_LumieresDTOIn>();
            CreateMap<Afpa_LumieresDTOIn, Afpa_Lumiere>();
            CreateMap<Afpa_Lumiere, Afpa_LumieresDTOOut>();
            CreateMap<Afpa_LumieresDTOOut, Afpa_Lumiere>();
        }
    }
}
