using AutoMapper;
using GestionCommandes.Data.Dtos;
using GestionCommandes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionCommandes.Data.Profiles
{
    public class ProduitProfiles : Profile
    {
        public ProduitProfiles()
        {
            CreateMap<ProduitDTO, Produit>();
            CreateMap<Produit, ProduitDTO>();
            CreateMap<ProduitDTOIn, Produit>();
            CreateMap<Produit, ProduitDTOIn>();
        }
    }
}
