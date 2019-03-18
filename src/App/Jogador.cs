namespace App

{
    public class Jogador
    {

        public int[] Mao { get; set; }
        public NivelDaJogada NivelDaJogada { get; set; }

        public Jogador(int[] mao)
        {
            Mao = mao;
            NivelDaJogada = NivelDaJogada.SemJogada;
        }
    }
}