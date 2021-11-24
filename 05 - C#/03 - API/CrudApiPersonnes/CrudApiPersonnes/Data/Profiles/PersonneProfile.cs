using AutoMapper;
using CrudApiPersonnes.Data.Dtos;
using CrudApiPersonnes.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApiPersonnes.Data.Profiles
{
    public class PersonneProfile : Profile
    {
        public PersonneProfile()
        {
            CreateMap<Personne, PersonneDTO>();
            CreateMap<PersonneDTO, Personne>();
        }
    }
}
