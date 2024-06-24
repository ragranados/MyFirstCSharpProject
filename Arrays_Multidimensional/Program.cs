using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Multidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[3, 3];
            board[0, 0] = 5;

            int[,] board2 = new int[3, 3]
            {
                { 1,2,3},
                { 4,5,6},
                { 7,8,9 }
            };

            int[,,] chessBoard = new int[3, 3, 3]
                {
                    {
                { 1,2,3},
                { 4,5,6},
                { 7,8,9 }
            },
                    {
                { 1,2,3},
                { 4,5,6},
                { 7,8,9 }
            },
                    {
                { 1,2,3},
                { 4,5,6},
                { 7,8,9 }
            }
                };

            //en el caso de los arreglos multidimensionales, el usar Length, te devuele el numero total de elementos que hay en el arreglo

            //for (int i = 0; i < board2.GetLength(0); i++)//0 1 2
            //{
            //    for (int j = 0; j < board2.GetLength(1); j++) 
            //    {
            //        Console.Write(board2[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            foreach (var item in board2)
            {
                Console.Write(item);
            }

            Console.ReadLine();

        }
    }
}
