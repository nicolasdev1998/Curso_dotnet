using GameTop.interfaces;

namespace GameTop.lib
{
    public class Jogador2 : IJogador
    {
        public string Chutar()
        {
            return "Maradona esta chutando";
        }

        public string Correr()
        {
            return "Maradona esta correndo";
        }

        public string Passar()
        {
           return "Maradona esta passando";
        }
    }
}