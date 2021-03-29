using AutoMapper;
using Parky.API.Models;
using Parky.API.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parky.API.Mapper
{
    public class ParkyMappings : Profile
    {
        public ParkyMappings()
        {
            CreateMap<NationalPark, NationalParkDto>().ReverseMap();
        }
    }
}
