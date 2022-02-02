using AutoMapper;
using ProjetAutomate.Data.Dtos;
using ProjetAutomate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Profiles
{
    public class Afpa_AnomaliesProfile:Profile
    {
        public Afpa_AnomaliesProfile()
        {
            CreateMap<Afpa_Anomalie, Afpa_AnomaliesDTOIn>();
            CreateMap<Afpa_AnomaliesDTOIn, Afpa_Anomalie>();
            CreateMap<Afpa_Anomalie, Afpa_AnomaliesDTOOut>().ForMember(d=>d.Erreur,o=>o.MapFrom(s=>s.Erreur.MessageErreur));
            CreateMap<Afpa_AnomaliesDTOOut, Afpa_Anomalie>();
        }
    }
}
