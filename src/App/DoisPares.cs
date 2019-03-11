using System;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    public class DoisPares
    {
        public int[] MaoVencedora { get; set; }
        public DoisPares(int[] jogadorUm, int[] jogadorDois)
        {
            MaoVencedora = ObterVencedor(jogadorUm, jogadorDois);
        }

        private int[] ObterVencedor(int[] jogadorUm, int[] jogadorDois)
        {
            var erro = new[] { 0 };
            var jogadorUmPossuiDoisPares = ConfirmarDoisPares(jogadorUm);
            var jogadorDoisPossuiDoisPares = ConfirmarDoisPares(jogadorDois);

            if (jogadorUmPossuiDoisPares && jogadorDoisPossuiDoisPares)
            {
                if (SomarValores(jogadorUm).Equals(SomarValores(jogadorDois)))
                {
                    return ObterVencedorPorCartaMaisAlta(jogadorUm, jogadorDois);
                }
                return ObterVencedorQuandoParesForemIguais(jogadorUm, jogadorDois);
            }
            else if (jogadorUmPossuiDoisPares)
            {
                return jogadorUm;
            }
            else if (jogadorDoisPossuiDoisPares)
            {
                return jogadorDois;
            }
            else
            {
                return erro;
            }
        }

        public bool ConfirmarDoisPares(int[] jogador)
        {
            var valorRepetido = new List<int>();
            for (int i = 0; i < jogador.Length; i++)
            {
                for (int j = i + 1; j < jogador.Length; j++)
                {
                    if (jogador[i] == jogador[j])
                    {
                        valorRepetido.Add(jogador[i]);
                    }
                }
            }
            return valorRepetido.Count == 2;
        }

        public int SomarValores(int[] jogador)
        {
            var valoresDaLista = new List<int>();
            for (int i = 0; i < jogador.Length; i++)
            {
                for (int j = i + 1; j < jogador.Length; j++)
                {
                    if (jogador[i] == jogador[j])
                    {
                        valoresDaLista.Add(jogador[i]);
                    }
                }
            }
            return valoresDaLista.Sum();
        }

        private int[] ObterVencedorQuandoParesForemIguais(int[] jogadorUm, int[] jogadorDois)
        {
            var somaValorDoJogadorUm = SomarValores(jogadorUm);
            var somaValorDoJogadorDois = SomarValores(jogadorDois);

            return somaValorDoJogadorUm > somaValorDoJogadorDois ? jogadorUm : jogadorDois;
        }

        private int[] ObterVencedorPorCartaMaisAlta(int[] jogadorUm, int[] jogadorDois)
        {
            var desempatePorCartaAlta = new CartaAlta(jogadorUm, jogadorDois);
            return desempatePorCartaAlta.MaoVencedora;
        }
    }
}