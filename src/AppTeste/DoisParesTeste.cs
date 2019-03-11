using App;
using Xunit;

namespace AppTeste
{
    public class DoisParesTeste
    {
        [Fact]
        public void Deve_vencer_a_mao_do_jogador_um()
        {
            var jogadorUm = new[] { 6, 2, 4, 4, 2 };
            var jogadorDois = new[] { 7, 3, 6, 2, 9 };

            var doisPares = new DoisPares(jogadorUm, jogadorDois);

            Assert.Equal(jogadorUm, doisPares.MaoVencedora);
        }

        [Fact]
        public void Deve_vencer_a_mao_do_jogador_dois()
        {
            var jogadorUm = new[] { 4, 8, 5, 2, 7 };
            var jogadorDois = new[] { 2, 6, 2, 5, 6 };

            var doisPares = new DoisPares(jogadorUm, jogadorDois);

            Assert.Equal(jogadorDois, doisPares.MaoVencedora);
        }

        [Fact]
        public void Deve_vencer_jogadorUm_no_desempate_com_pares_de_maior_valor()
        {
            var jogadorUm = new[] { 2, 5, 5, 7, 7 };
            var jogadorDois = new[] { 2, 5, 5, 2, 7 };

            var doisPares = new DoisPares(jogadorUm, jogadorDois);

            Assert.Equal(jogadorUm, doisPares.MaoVencedora);
        }

        [Fact]
        public void Deve_vencer_jogadorDois_no_desempate_com_pares_de_maior_valor()
        {
            var jogadorUm = new[] { 2, 5, 5, 7, 7 };
            var jogadorDois = new[] { 8, 5, 5, 2, 8 };

            var doisPares = new DoisPares(jogadorUm, jogadorDois);

            Assert.Equal(jogadorDois, doisPares.MaoVencedora);
        }

        //Tá falhando esse teste (primeira condição do ObterVencedor) || Não tá falhando mais!!
        [Fact]
        public void Deve_vencer_jogadorUm_com_carta_alta_no_desempate_dos_pares_iguais()
        {
            var jogadorUm = new[] { 2, 5, 5, 2, 7 };
            var jogadorDois = new[] { 2, 5, 5, 2, 4 };

            var doisPares = new DoisPares(jogadorUm, jogadorDois);

            Assert.Equal(jogadorUm, doisPares.MaoVencedora);
        }

        [Fact]
        public void Deve_vencer_jogadorDois_com_carta_alta_no_desempate_dos_pares_iguais()
        {
            var jogadorUm = new[] { 2, 5, 5, 2, 7 };
            var jogadorDois = new[] { 2, 5, 5, 2, 8 };

            var doisPares = new DoisPares(jogadorUm, jogadorDois);

            Assert.Equal(jogadorDois, doisPares.MaoVencedora);
        }
    }
}