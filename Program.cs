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

                    try
                    {
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.Tab);
                        Console.WriteLine();
                        Console.WriteLine($"Turno: {partida.Turno}");
                        Console.WriteLine($"Aguardando jogada: {partida.JogadorAtual}");

                        Console.Write("\nOrigem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();
                        partida.validarPosicaoDeOrigem(origem);
                        bool[,] posicoesPossiveis = partida.Tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.Tab, posicoesPossiveis);

                        Console.Write("\nDestino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException ex)
                    {
                        Console.WriteLine($"Error!: {ex.Message}");
                        Console.ReadLine();
                    }
                    catch (IndexOutOfRangeException ex)
                    {

                        Console.WriteLine("Erro inesperado: input vazio ou não correspondente com o tamanho do Array!");
                        Console.ReadLine();
                    }
                }
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine($"Error!: {ex.Message}");
            }

        }
    }
}