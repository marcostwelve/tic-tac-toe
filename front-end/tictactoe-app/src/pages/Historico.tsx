import { useEffect, useState } from "react";
import { obterPartidas } from "../services/partidaService";
import type { Partida } from "../types/PartidaModel";

export default function History() {
  const [partidas, setPartidas] = useState<Partida[]>([]);

  useEffect(() => {
    obterPartidas().then(setPartidas);
  }, []);

  return (
   <div className="history">
      <h2>Histórico</h2>

      {partidas.length === 0 && <p>Nenhuma partida encontrada.</p>}

      {partidas.map((m) => (
        <div key={m.id} className="history-item">
          <span>{m.jogadorX} vs {m.jogadorO}</span>
          <span>|</span>
          <span>{m.nomeVencedor === "EMPATE" ? "Empate" : `Venceu o jogador:  ${m.nomeVencedor}`}</span>
          <span>|</span>
          <span>Data: {new Date(m.dataPartida).toLocaleString("pt-BR")}</span>
        </div>
      ))}
    </div>
  );
}