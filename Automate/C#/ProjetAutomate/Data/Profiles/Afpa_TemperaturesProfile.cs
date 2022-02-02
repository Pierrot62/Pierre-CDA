using AutoMapper;
using ProjetAutomate.Data.Dtos;
using ProjetAutomate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Profiles
{
    public class Afpa_TemperaturesProfile : Profile
    {
        public Afpa_TemperaturesProfile()
        {
            CreateMap<Afpa_Temperature, Afpa_TemperaturesDTOIn>();
            CreateMap<Afpa_TemperaturesDTOIn, Afpa_Temperature> ();

            CreateMap<Afpa_Temperature, Afpa_TemperaturesDTOOut>();
            CreateMap<Afpa_TemperaturesDTOOut, Afpa_Temperature>();
        }
    }
}
