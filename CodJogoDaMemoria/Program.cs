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
              


            







     }

    

}
