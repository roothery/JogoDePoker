using App;
using Xunit;

namespace AppTeste
{
    public class JogoTeste
    {
        [Fact]
        public void Jogador1DeveVencerComAMaiorCarta()
        {
            var jogador1 = new[] { 4, 8, 7, 3, 2 };
            var jogador2 = new[] { 5, 2, 1, 4, 3 };

            var resultado = new Jogo().ValidarCartaAlta(jogador1, jogador2);

            Assert.Equal("Jogador 1 venceu!", resultado);
        }

        [Fact]
        public void Jogador2DeveVencerComAMaiorCarta()
        {
            var jogador1 = new[] { 4, 8, 7, 3, 2 };
            var jogador2 = new[] { 5, 9, 1, 4, 3 };

            var resultado = new Jogo().ValidarCartaAlta(jogador1, jogador2);

            Assert.Equal("Jogador 2 venceu!", resultado);
        }

        [Fact]
        public void Jogador1DeveVencerComParDeCartas()
        {
            //Arrange
            var jogador1 = new[] { 1, 4, 3, 5, 5 };
            var jogador2 = new[] { 3, 4, 6, 2, 7 };

            //Action
            var resultado = new Jogo().ValidarUmPar(jogador1, jogador2);

            //Assert
            Assert.Equal("Jogador 1 venceu!", resultado);
        }

        [Fact]
        public void Jogador2DeveVencerComParDeCartas()
        {
            var jogador1 = new[] { 1, 3, 7, 4, 8 };
            var jogador2 = new[] { 2, 6, 9, 6, 4 };

            var resultado = new Jogo().ValidarUmPar(jogador1, jogador2);

            Assert.Equal("Jogador 2 venceu!", resultado);
        }

        [Fact]
        public void Jogador1DeveVencerEmpateDeParDeCartasComMaiorCarta()
        {
            var jogador1 = new[] { 3, 6, 6, 9, 2 };
            var jogador2 = new[] { 3, 5, 2, 4, 2 };

            var resultado = new Jogo().ValidarUmPar(jogador1, jogador2);

            Assert.Equal("Jogador 1 venceu!", resultado);
        }

        [Fact]
        public void Jogador1DeveVencerComDoisParesDeCarta()
        {
            var jogador1 = new[] { 2, 4, 5, 2, 5 };
            var jogador2 = new[] { 4, 8, 3, 7, 2 };

            var resultado = new Jogo().ValidarDoisPares(jogador1, jogador2);

            Assert.Equal("Jogador 1 venceu!", resultado);
        }

        [Fact]
        public void Jogador2DeveVencerComDoisParesDeCarta()
        {
            var jogador1 = new[] { 5, 8, 3, 7, 4 };
            var jogador2 = new[] { 2, 4, 3, 7, 4 };

            var resultado = new Jogo().ValidarDoisPares(jogador1, jogador2);

            Assert.Equal("Jogador 2 venceu!", resultado);
        }

        [Fact]
        public void Jogador1DeveVencerComTrinca()
        {
            var jogador1 = new[] { 3, 3, 5, 4, 3 };
            var jogador2 = new[] { 4, 7, 6, 3, 2 };

            var resultado = new Jogo().ValidarTrinca(jogador1, jogador2);

            Assert.Equal("Jogador 1 venceu!", resultado);
        }

        [Fact]
        public void Jogador2DeveVencerComTrinca()
        {
            var jogador1 = new[] { 8, 3, 5, 4, 3 };
            var jogador2 = new[] { 4, 7, 7, 3, 7 };

            var resultado = new Jogo().ValidarTrinca(jogador1, jogador2);

            Assert.Equal("Jogador 2 venceu!", resultado);
        }
    }
}
