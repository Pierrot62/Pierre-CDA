using AutoMapper;
using GestionGroupeDeMusique.Data.Dtos;
using GestionGroupeDeMusique.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGroupeDeMusique.Data.Profiles
{
    class MusiciensProfiles : Profile
    {
        public MusiciensProfiles()
        {
            CreateMap<MusiciensDTOIn, Musicien>();
            CreateMap<Musicien, MusiciensDTOIn>();
            CreateMap<MusiciensDTOOut, Musicien>();
            CreateMap<Musicien, MusiciensDTOOut>();
            CreateMap<MusiciensDTOOutAvecGroupe, Musicien>();
            CreateMap<Musicien, MusiciensDTOOutAvecGroupe>()
                .ForMember(d => d.NomDuGroupe, o => o.MapFrom(s => s.Groupe.NomDuGroupe));
            }
    }
}
