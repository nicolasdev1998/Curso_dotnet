using GameTop.lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
           var jogoFoda = new JogoFoda(new Jogador2(), new JogadorA());
           jogoFoda.IniciarJogo();
        }
    }       
}
