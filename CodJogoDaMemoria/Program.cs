using System;

using System.Collections.Generic;
class Program
{
     static string[,] tabuleiro = new string[4,4];
    static bool[,] descobertas = new bool[4,4];
    static int jogadas = 0;
        static int pares = 0;
         static void Main()
      {
          CriarTabuleiro();
     while (pares < 8)
     {
        Console.Clear();
        MostrarTabuleiro();
         Console.WriteLine("\nJogadas: " + jogadas);
          Console.WriteLine("Pares encontrados: " + pares);
           Console.WriteLine("\nPrimeira carta");
           int l1 = Ler("Linha (1-4): ") - 1;
           int c1 = Ler("Coluna (1-4): ") - 1;
           if (!PosicaoValida(l1,c1)) continue;
           descobertas[l1,c1] = true;
            Console.Clear();
            MostrarTabuleiro();
             Console.WriteLine("\nSegunda carta");
              int l2 = Ler("Linha (1-4): ") - 1;
               int c2 = Ler("Coluna (1-4): ") - 1;
                if (!PosicaoValida(l2,c2)) continue;
                 descobertas[l2,c2] = true;
                  Console.Clear();
                  MostrarTabuleiro();
                    jogadas++;
                      if (tabuleiro[l1,c1] == tabuleiro[l2,c2] && !(l1 == l2 && c1 == c2))
                        {
                Console.WriteLine("Acertou o par!");
                pares++;
            }
             else
            {
                Console.WriteLine("Errou!");
                descobertas[l1,c1] = false;
                descobertas[l2,c2] = false;
            }


            







     }

    

}
