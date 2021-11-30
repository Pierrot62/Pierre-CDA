using AutoMapper;
using Magasin.Data.Dtos;
using Magasin.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magasin.Data.Profiles
{
    public class CategorieProfile : Profile
    {
        public CategorieProfile()
        {
            CreateMap<CategorieDTO, Categorie>();
            CreateMap<Categorie, CategorieDTO>();
            CreateMap<CategorieDTOIn, Categorie>();
            CreateMap<Categorie, CategorieDTOIn>();
        }

  
    }
}
