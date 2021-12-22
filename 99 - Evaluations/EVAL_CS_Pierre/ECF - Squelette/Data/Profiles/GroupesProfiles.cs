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
    class GroupesProfiles : Profile
    {
        public GroupesProfiles()
        {
            CreateMap<GroupesDTOIn, Groupe>();
            CreateMap<Groupe, GroupesDTOIn>();        
            CreateMap<GroupesDTOOut, Groupe>();
            CreateMap<Groupe, GroupesDTOOut>();        
            CreateMap<GroupesDTOOutAvecMusiciens, Groupe>();
            CreateMap<Groupe, GroupesDTOOutAvecMusiciens>();
        }
    }
}
