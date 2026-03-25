using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ticTacToe.Domain.Entities;

namespace ticTacToe.Domain.Interfaces
{
    public interface IPartidaRepository
    {
        Task AdicionarPartida(Partida partida, CancellationToken cancellationToken = default);
        Task<Partida> ObterPartidaPorId(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<Partida>> ObterTodasPartidas(CancellationToken cancellationToken = default);
    }
}
