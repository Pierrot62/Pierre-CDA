using APISurPlusieurTables.Data.Dtos;
using APISurPlusieurTables.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISurPlusieurTables.Data.Profiles
{
    public class EmployerProfiles_IN : Profile
    {
        public EmployerProfiles_IN()
        {
            CreateMap<Employer, EmployerDTO_IN>();
            CreateMap<EmployerDTO_IN,Employer>();
        }
    }
}
