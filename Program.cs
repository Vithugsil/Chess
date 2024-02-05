using tabuleiro;
using xadrez;

namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            PosicaoXadrez pos = new('c', 7);
            System.Console.WriteLine(pos.ToPosicao());
            
        }
    }
}