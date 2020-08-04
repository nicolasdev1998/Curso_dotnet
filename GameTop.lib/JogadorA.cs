using GameTop.interfaces;

namespace GameTop.lib
{
    public class JogadorA : IJogador
    {
        public readonly string _Nome;

        public JogadorA(string nome = "Nicolas")
        {
            _Nome = nome;
        }

        public string Chutar()
        {
            return $"{_Nome} esta Chutando";
        }

        public string Passar()
        {
            return $"{_Nome} esta Passado";            
        }

        public string Correr()
        {
            return $"{_Nome} esta Correndo";            
        }
    }
}