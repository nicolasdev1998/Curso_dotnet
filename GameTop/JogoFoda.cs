using System;
using GameTop.interfaces;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;

        public JogoFoda(IJogador jogadorA, IJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        
        public void IniciarJogo()
        {
            Console.WriteLine(_jogadorA.Chutar());
            Console.WriteLine(_jogadorA.Passar());
            Console.WriteLine(_jogadorA.Correr());

            Console.WriteLine("PROXIMO JOGADOR");

            Console.WriteLine(_jogadorB.Chutar());
            Console.WriteLine(_jogadorB.Passar());
            Console.WriteLine(_jogadorB.Correr());
        }
    }
}