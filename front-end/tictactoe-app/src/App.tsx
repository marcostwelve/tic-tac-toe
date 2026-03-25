import './App.css'
import { BrowserRouter, Link, Route, Routes } from 'react-router-dom'
import Jogo from './pages/Jogo'
import Historico from './pages/Historico'

export default function App() {
  return (
    <BrowserRouter>
      <div>

        <div className="navbar">
          <h1>Jogo da Velha</h1>

          <div>
            <Link to="/">Jogo</Link>
            <Link to="/historico">Histórico</Link>
          </div>
        </div>

        <div className="container">
          <Routes>
            <Route path="/" element={<Jogo />} />
            <Route path="/historico" element={<Historico />} />
          </Routes>
        </div>

      </div>
    </BrowserRouter>
  );
}
