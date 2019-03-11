using App;
using Xunit;

namespace AppTeste
{
    public class CartaAltaTeste
    {
        [Fact]
        public void Deve_vencer_o_jogadorUm_com_a_maior_carta()
        {
            var jogadorDois = new[] { 1, 2, 5, 3, 7 };
            var jogadorUm = new[] { 5, 3, 2, 6, 8 };

            var cartaAlta = new CartaAlta(jogadorUm, jogadorDois);

            Assert.Equal(jogadorUm, cartaAlta.MaoVencedora);
        }

        [Fact]
        public void Deve_vencer_o_jogadorDois_com_a_maior_carta()
        {
            var jogadorDois = new[] { 1, 2, 5, 9, 7 };
            var jogadorUm = new[] { 5, 3, 2, 6, 8 };

            var cartaAlta = new CartaAlta(jogadorUm, jogadorDois);

            Assert.Equal(jogadorDois, cartaAlta.MaoVencedora);
        }
    }
}