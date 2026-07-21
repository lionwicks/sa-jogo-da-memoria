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


     }

    

}