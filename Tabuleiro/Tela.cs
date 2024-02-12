using xadrez;

namespace tabuleiro
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    imprimirPeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {

            ConsoleColor fundoOG = Console.BackgroundColor;
            ConsoleColor fundoAlt = ConsoleColor.Gray;


            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if(posicoesPossiveis[i, j] )
                    {
                        Console.BackgroundColor = fundoAlt;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOG;
                    }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOG;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOG;
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                System.Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                System.Console.Write(" ");
            }
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
    }

}