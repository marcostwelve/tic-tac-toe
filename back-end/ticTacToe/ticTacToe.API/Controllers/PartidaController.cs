using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ticTacToe.Application.Dto;
using ticTacToe.Application.Services.interfaces;

namespace ticTacToe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartidaController : ControllerBase
    {
        private readonly IPartidaService _partidaService;

        public PartidaController(IPartidaService partidaService)
        {
            _partidaService = partidaService;
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarPartida([FromBody] PartidaDto partida)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _partidaService.AdicionarPartida(partida);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodasPartidas()
        {
            var partidas = await _partidaService.ObterTodasPartidas();

            if (partidas == null || !partidas.Any())
            {
                return NotFound();
            }
            return Ok(partidas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPartidaPorId(int id)
        {
            var partida = await _partidaService.ObterPartidaPorId(id);
            if (partida == null)
            {
                return NotFound();
            }
            return Ok(partida);
        }
    }
}
