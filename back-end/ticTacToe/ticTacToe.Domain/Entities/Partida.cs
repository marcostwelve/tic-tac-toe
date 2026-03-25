using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToe.Domain.Entities
{
    public class Partida
    {
        public int Id { get; set; }
        public string NomeVencedor { get; set; }
        public string JogadorX { get; set; }
        public string JogadorO { get; set; }
        public string Resultado { get; set; }
        public DateTime DataPartida { get; set; } = DateTime.UtcNow;
    }
}
