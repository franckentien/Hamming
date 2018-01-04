using System;

namespace Hamming
{
    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            int[,] matrice = new int[10, 5] 
                                 {   { 1, 1, 2, 2, 1 }, 
                                     { 2, 1, 1, 2, 1 }, 
                                     { 3, 2, 2, 2, 1 }, 
                                     { 4, 1, 2, 1, 1 },
                                     { 5, 1, 2, 2, 2 },
                                     { 6, 1, 1, 1, 2 },
                                     { 7, 2, 2, 2, 2 },
                                     { 8, 2, 1, 1, 1 },
                                     { 9, 2, 1, 1, 2 }, 
                                     { 10, 2, 2, 1, 2 }
                                 };

            Hamming hamming = new Hamming(matrice);

            Console.WriteLine("==== Initial matrice ====\n");
            Print2DArray(hamming.Matrice);

            //Console.WriteLine("\n==== Initial HammingTab ====\n");
            //Print2DArray(hamming.HammingTab);

            Console.WriteLine("\n++++ Create Hamming Tab ++++");
            hamming.CreateHammingTab();

            Console.WriteLine("\n==== New HammingTab ====\n");
            Print2DArray(hamming.HammingTab);

        }

        /// <summary>
        /// The print 2 d array.
        /// </summary>
        /// <typeparam name="T">
        /// 2DArray
        /// </typeparam>
        /// <param name="matrix">
        /// The matrix.
        /// </param>
        public static void Print2DArray<T>(T[,] matrix)
        {
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


    }
}
