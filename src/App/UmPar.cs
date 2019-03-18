namespace App
{
    public class UmPar
    {
        public int[] MaoVencedora { get; set; }

        public NivelDaJogada NivelDaJogada;
        public UmPar(int[] jogadorUm, int[] jogadorDois)
        {
            MaoVencedora = ObterVencedor(jogadorUm, jogadorDois);
            NivelDaJogada = NivelDaJogada.UmPar;
        }

        private int[] ObterVencedor(int[] jogadorUm, int[] jogadorDois)
        {
            var valorDoParJogador1 = ObterValorDoPar(jogadorUm);
            var valorDoParJogador2 = ObterValorDoPar(jogadorDois);

            if (valorDoParJogador1 == valorDoParJogador2)
            {
                var desempatePorCartaAlta = new CartaAlta(jogadorUm, jogadorDois);
                return desempatePorCartaAlta.MaoVencedora;
            }
            else
            {
                return valorDoParJogador1 > valorDoParJogador2 ? jogadorUm : jogadorDois;
            }
        }

        private int ObterValorDoPar(int[] jogador)
        {
            var cartaDoPar = 0;
            for (int i = 0; i < jogador.Length; i++)
            {
                for (int j = i + 1; j < jogador.Length; j++)
                {
                    if (jogador[i] == jogador[j])
                    {
                        cartaDoPar = jogador[i];
                    }
                }
            }
            return cartaDoPar;
        }
    }
}