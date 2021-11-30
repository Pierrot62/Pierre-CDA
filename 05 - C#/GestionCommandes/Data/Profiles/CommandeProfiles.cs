using AutoMapper;
using GestionCommandes.Data.Dtos;
using GestionCommandes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionCommandes.Data.Profiles
{
    public class CommandeProfiles : Profile
    {
        public CommandeProfiles()
        {
            CreateMap<CommandeDTO, Commande>();
            CreateMap<Commande, CommandeDTO>();
            CreateMap<CommandeDTOIn, Commande>();
            CreateMap<Commande, CommandeDTOIn>();
            CreateMap<CommandeDTOavecProduits, Commande>();
            CreateMap<Commande, CommandeDTOavecProduits>();
        }
    }
}
