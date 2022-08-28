using System;

namespace Jogo_rato
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] jogo = new int[5, 10];

            Random Randonizador = new Random();
            int linebreaker = 0;


            for (int i = 0; i < jogo.GetLength(0); i++)
            {
                for(int j = 0; j < jogo.GetLength(0); j++)
                {
                    jogo[i, j] = Randonizador.Next(2);
                }      
            }


            jogo[0, 0] = 2;
            jogo[2, 3] = 3;

            foreach (int block in jogo)
            {
                if (linebreaker == 10)
                {
                    Console.WriteLine("\n");
                    linebreaker = 0;


                }



                switch (block)
                {
                    case 0:
                        Console.Write($"[   {block}  ]");
                        break;
                    case 1:
                        Console.Write($"[   {block}  ]");
                        break;
                    case 2:
                        Console.Write($"[ RATO ]");
                        break;
                    case 3:
                        Console.Write($"[QUEIJO]");
                        break;
                        Console.WriteLine("");

                }

                linebreaker++;

                
            }
            Console.WriteLine("");
            Console.WriteLine("\n-----------------------------------[SAIDA]------------------------------------------\n");

        }
    }

}
