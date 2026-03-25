using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ticTacToe.Application.Dto;
using ticTacToe.Domain.Entities;

namespace ticTacToe.Application.Mapping
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Partida, PartidaDto>().ReverseMap();
        }
    }
}
