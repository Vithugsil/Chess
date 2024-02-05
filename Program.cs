using tabuleiro;

namespace Course
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Tabuleiro tab = new(8,8);
            Tela.imprimirTabuleiro(tab);
        }
    }
}