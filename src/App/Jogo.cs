using System;
using System.Linq;

namespace App
{
    public class Jogo
    {
        public string ValidarCartaAlta(int[] jogador1, int[] jogador2)
        {
        var maiorCartaJogador1 = jogador1.Max();
        var maiorCartaJogador2 = jogador2.Max();

            return Resultado(maiorCartaJogador1, maiorCartaJogador2);
        }

        public string ValidarUmPar(int[] jogador1, int[] jogador2)
        {
            var parJogador1 = ValorDoNumeroPar(jogador1);
            var parJogador2 = ValorDoNumeroPar(jogador2);

            return Resultado(parJogador1, parJogador2);
        }

        private static int ValorDoNumeroPar(int[] jogador)
        {
            var valorDoPar = 0;
            for (int i = 0; i < jogador.Length; i++)
            {
                for (int j = i + 1; j < jogador.Length; j++)
                {
                    if (jogador[i] == jogador[j])
                    {
                        valorDoPar = jogador[i];
                    }
                }

            }

            return (jogador.Distinct().Count() == 4) ? valorDoPar : 0;
        }

        public string ValidarDoisPares(int[] jogador1, int[] jogador2)
        {
            var doisParesJogador1 = VerificaDoisPares(jogador1);
            var doisParesJogador2 = VerificaDoisPares(jogador2);

            return Resultado(doisParesJogador1, doisParesJogador2);
        }

        private static int VerificaDoisPares(int[] jogador)
        {
            var contador = jogador.Distinct().Count();

            return (jogador.Distinct().Count() == 3) ? contador : 0;
        }

        public string ValidarTrinca(int[] jogador1, int[] jogador2)
        {
            var trincaJogador1 = VerificaTrinca(jogador1);
            var trincaJogador2 = VerificaTrinca(jogador2);

        return Resultado(trincaJogador1, trincaJogador2);
        }

        private static int VerificaTrinca(int[] jogador)
        {
            var contador = jogador.Distinct().Count();

            return (jogador.Distinct().Count() == 3) ? contador : 0;
        }


        private static string Resultado(int jogador1, int jogador2)
        {
            return (jogador1 > jogador2 || jogador1 == 3) ? "Jogador 1 venceu!" : "Jogador 2 venceu!";
        }
    }
}
