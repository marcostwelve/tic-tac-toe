using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToe.Application.Dto
{
    public class PartidaDto
    {
        public string NomeVencedor { get; set; }
        public string JogadorX { get; set; }
        public string JogadorO { get; set; }
        public string Resultado { get; set; }
        public DateTime DataPartida { get; set; }
    }
}
