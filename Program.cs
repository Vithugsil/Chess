using tabuleiro;
using xadrez;

namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new();
                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.Tab);
                    Console.Write("\nOrigem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();

                    bool[,] posicoesPossiveis = partida.Tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.Tab, posicoesPossiveis);

                    Console.Write("\nDestino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().ToPosicao(); 
                    partida.ExecutaMovimento(origem, destino);
                }
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine($"Error!: {ex.Message}");
            }
        }
    }
}