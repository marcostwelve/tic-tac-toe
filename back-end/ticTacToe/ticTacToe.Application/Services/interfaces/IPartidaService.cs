using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ticTacToe.Application.Dto;

namespace ticTacToe.Application.Services.interfaces
{
    public interface IPartidaService
    {
            Task AdicionarPartida(PartidaDto partida);
            Task<PartidaDto> ObterPartidaPorId(int partidaId);
            Task<IEnumerable<PartidaDto>> ObterTodasPartidas();
    }
}
