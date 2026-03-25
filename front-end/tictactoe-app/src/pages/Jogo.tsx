import { useState, useEffect } from "react";
import { criarPartida } from "../services/partidaService";

export default function Game() {
  
  const [board, setBoard] = useState<(string | null)[]>(Array(9).fill(null));
  const [isXTurn, setIsXTurn] = useState(true);
  const [vencedor, setVencedor] = useState<string | null>(null);

  const [jogadorX, setJogadorX] = useState("");
  const [jogadorO, setJogadorO] = useState("");

  function calculateWinner(board: (string | null)[]) {
    const lines = [
      [0,1,2],[3,4,5],[6,7,8],
      [0,3,6],[1,4,7],[2,5,8],
      [0,4,8],[2,4,6],
    ];

    for (let [a, b, c] of lines) {
      if (board[a] && board[a] === board[b] && board[a] === board[c]) {
        return board[a];
      }
    }

    return null;
  }

  function handleClick(index: number) {

    if (board[index] || vencedor) return;

    if (!jogadorX || !jogadorO) return;

    const newBoard = [...board];
    newBoard[index] = isXTurn ? "X" : "O";

    setBoard(newBoard);
    setIsXTurn(!isXTurn);
  }

  async function saveResult(resultado: string | null) {
    await criarPartida({
      jogadorX,
      jogadorO,
      resultado: resultado ?? "EMPATE",
      nomeVencedor: resultado === "X" ? jogadorX : resultado === "O" ? jogadorO : "EMPATE",
    });
  }

  useEffect(() => {
    const vence = calculateWinner(board);

    if (vence) {
      setVencedor(vence);
      saveResult(vence);
    } else if (!board.includes(null)) {
      setVencedor("EMPATE");
      saveResult(null);
    }
  }, [board]);

  function reset() {
    setBoard(Array(9).fill(null));
    setIsXTurn(true);
    setVencedor(null);
  }

  return (
    <div className="game">
      <h1>Tic Tac Toe</h1>

      
      <div style={{ marginBottom: 20 }}>
        <input
          type="text"
          placeholder="Jogador X"
          value={jogadorX}
          onChange={(e) => setJogadorX(e.target.value)}
          style={{ marginRight: 10, padding: 8 }}
        />

        <input
          type="text"
          placeholder="Jogador O"
          value={jogadorO}
          onChange={(e) => setJogadorO(e.target.value)}
          style={{ padding: 8 }}
        />
      </div>

      {!vencedor && (
        <p className="status">
          Vez:{" "}
          <span>
            {isXTurn
              ? `${jogadorX || "X"} (X)`
              : `${jogadorO || "O"} (O)`}
          </span>
        </p>
      )}

      {vencedor && (
        <p className="status">
          {vencedor === "EMPATE"
            ? "Empate!"
            : `Vencedor: ${
                vencedor === "X" ? jogadorX : jogadorO
              } (${vencedor})`}
        </p>
      )}

      <div className="board">
        {board.map((value, index) => (
          <button
            key={index}
            className="square"
            onClick={() => handleClick(index)}
          >
            {value}
          </button>
        ))}
      </div>

      <button className="button" onClick={reset}>
        Reiniciar
      </button>
    </div>
  );
}