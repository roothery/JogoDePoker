using System.Linq;

namespace App
{
    public class CartaAlta
    {
        public int[] MaoVencedora { get; set; }
        public CartaAlta(int[] jogadorUm, int[] jogadorDois)
        {
            MaoVencedora = jogadorUm.Max() > jogadorDois.Max() ? jogadorUm : jogadorDois;
        }
    }
}