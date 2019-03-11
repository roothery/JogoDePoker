using App;
using Xunit;

namespace AppTeste
{
    public class UmParTeste
    {
        [Fact]
        public void Deve_vencer_a_mao_do_jogador_um()
        {
            var jogadorUm = new[] { 2, 3, 5, 7, 2 };
            var jogadorDois = new[] { 6, 4, 8, 3, 2 };

            var umPar = new UmPar(jogadorUm, jogadorDois);

            Assert.Equal(jogadorUm, umPar.MaoVencedora);
        }

        [Fact]
        public void Deve_vencer_a_mao_do_jogador_dois()
        {
            var jogadorUm = new[] { 2, 5, 7, 9, 3 };
            var jogadorDois = new[] { 2, 7, 8, 7, 5 };

            var umPar = new UmPar(jogadorUm, jogadorDois);

            Assert.Equal(jogadorDois, umPar.MaoVencedora);
        }

        [Fact]
        public void Deve_vencer_o_jogadorUm_com_maior_par_da_jogada()
        {
            var jogadorUm = new[] { 9, 5, 7, 9, 3 };
            var jogadorDois = new[] { 2, 7, 8, 7, 5 };

            var umPar = new UmPar(jogadorUm, jogadorDois);

            Assert.Equal(jogadorUm, umPar.MaoVencedora);
        }

        [Fact]
        public void Deve_vencer_o_jogadorDois_com_maior_par_da_jogada()
        {
            var jogadorUm = new[] { 9, 5, 7, 5, 3 };
            var jogadorDois = new[] { 8, 7, 8, 7, 5 };

            var umPar = new UmPar(jogadorUm, jogadorDois);

            Assert.Equal(jogadorDois, umPar.MaoVencedora);
        }

        [Fact]
        public void Deve_vencer_jogadorUm_com_carta_mais_alta_no_empate_de_par_do_mesmo_valor()
        {
            var jogadorUm = new[] { 8, 3, 5, 2, 3 };
            var jogadorDois = new[] { 3, 7, 6, 2, 3 };

            var umPar = new UmPar(jogadorUm, jogadorDois);

            Assert.Equal(jogadorUm, umPar.MaoVencedora);
        }

        [Fact]
        public void Deve_vencer_jogadorDois_com_carta_mais_alta_no_empate_de_par_do_mesmo_valor()
        {
            var jogadorUm = new[] { 6, 5, 3, 4, 5 };
            var jogadorDois = new[] { 8, 5, 3, 5, 6 };

            var umPar = new UmPar(jogadorUm, jogadorDois);

            Assert.Equal(jogadorDois, umPar.MaoVencedora);
        }
    }
}