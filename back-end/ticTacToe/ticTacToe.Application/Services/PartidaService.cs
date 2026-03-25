using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ticTacToe.Application.Dto;
using ticTacToe.Application.Services.interfaces;
using ticTacToe.Domain.Entities;
using ticTacToe.Domain.Interfaces;

namespace ticTacToe.Application.Services
{
    public class PartidaService : IPartidaService
    {
        private readonly IPartidaRepository _partidaRepository;
        private readonly IMapper _mapper;
        public PartidaService(IPartidaRepository partidaRepository, IMapper mapper) 
        {
            _partidaRepository = partidaRepository;
            _mapper = mapper;
        }
        public async Task AdicionarPartida(PartidaDto partida)
        {
            var partidaEntity = _mapper.Map<Partida>(partida);

            await _partidaRepository.AdicionarPartida(partidaEntity);
        }

        public async Task<PartidaDto> ObterPartidaPorId(int partidaId)
        {
            var partidaEntity = await _partidaRepository.ObterPartidaPorId(partidaId);


            var partidaMapper = _mapper.Map<PartidaDto>(partidaEntity);

            return partidaMapper;
        }

        public async Task<IEnumerable<PartidaDto>> ObterTodasPartidas()
        {
            var partidasEntity = await _partidaRepository.ObterTodasPartidas();
            var partidasMapper = _mapper.Map<IEnumerable<PartidaDto>>(partidasEntity);

            return partidasMapper;
        }
    }
}
