import type { Partida } from "../types/PartidaModel";
import { api } from "./api";

const API_URL = '';

export async function criarPartida(data: any): Promise<void> {
    await api.post("/", data);
}

export async function obterPartidas(): Promise<Partida[]> {
    try {
        const response = await api.get("/");
        return response.data;
    } catch (error) {
        console.error("Erro ao obter partidas:", error);
        return [];
    }
    
}