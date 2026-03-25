using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ticTacToe.Domain.Entities;
using ticTacToe.Domain.Interfaces;
using ticTacToe.Infrastructure.Persistence;

namespace ticTacToe.Infrastructure.Repository
{
    public class PartidaRepository : IPartidaRepository
    {
        private readonly AppDbContext _context;

        public PartidaRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AdicionarPartida(Partida partida, CancellationToken cancellationToken)
        {
            await _context.Partidas.AddAsync(partida, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<Partida> ObterPartidaPorId(int id, CancellationToken cancellationToken)
        {
            var partida = await _context.Partidas.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

            return  partida;

        }

        public async Task<IEnumerable<Partida>> ObterTodasPartidas(CancellationToken cancellationToken)
        {
            var partidas = await _context.Partidas.ToListAsync(cancellationToken);

            return partidas;
        }
    }
}
