using AutoMapper;
using Magasin.Data.Dtos;
using Magasin.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magasin.Data.Profiles
{
    public class ProduitProfile :Profile
    {
        public ProduitProfile()
        {
            CreateMap<ProduitDTO, Produit>();
            CreateMap<Produit, ProduitDTO>();
            CreateMap<ProduitDTOIn, Produit>();
            CreateMap<Produit, ProduitDTOIn>();
        }
    }
}
