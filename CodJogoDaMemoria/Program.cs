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
              Console.WriteLine("Pressione ENTER...");
            Console.ReadLine();
              }
        Console.Clear();
        MostrarTabuleiro();
        Console.WriteLine("\nPARABÉNS!");
        Console.WriteLine("Você encontrou todos os pares.");
        Console.WriteLine("Total de jogadas: " + jogadas);
    }

    static void CriarTabuleiro()
    {
        List<string> cartas = new List<string> { "A","A", "B","B", "C","C", "D","D", "E","E", "F","F", "G","G", "H","H" };
        Random r = new Random();
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                int pos = r.Next(cartas.Count);
                tabuleiro[i,j] = cartas[pos];
                cartas.RemoveAt(pos);
            }
        }
    }

    static void MostrarTabuleiro()
    {
        Console.WriteLine("  1  2  3  4");
        for(int i = 0; i < 4; i++)
        {
            Console.Write((i+1)+" ");
            for(int j = 0; j < 4; j++)
            {
                if(descobertas[i,j])
                    Console.Write(" "+tabuleiro[i,j]+" ");
                else
                    Console.Write(" * ");
            }
            Console.WriteLine();
        }
    }

    static int Ler(string texto)
    {
        Console.Write(texto);
        return int.Parse(Console.ReadLine());
    }

    static bool PosicaoValida(int l, int c)
    {
        if(l < 0 || l > 3 || c < 0 || c > 3) return false;
        if(descobertas[l,c]) return false;
        return true;
    }
}



            







     

    


