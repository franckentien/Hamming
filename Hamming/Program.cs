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
            int[,] matrice = {   { 1, 1, 2, 2, 1 }, 
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
            Console.WriteLine(Print2DArray(hamming.Matrice));
            

            //Console.WriteLine("\n==== Initial HammingTab ====\n");
            //Console.WriteLine(Print2DArray(hamming.HammingTab));

            Console.WriteLine("\n++++ Create Hamming Tab ++++");
            
            hamming.CreateHammingTab();

            Console.WriteLine("\n==== New HammingTab ====\n");
            Console.WriteLine(Print2DArray(hamming.HammingTab));

            Console.WriteLine("\n==== Clusters ====\n");
            
            Cluster cluster = new Cluster(hamming.HammingTab);

            Console.WriteLine(cluster.BuildCluster());

            Console.WriteLine("\n==== Clusters ====\n");

            cluster.Cluster1.Sort();
            cluster.Cluster2.Sort();

            Console.WriteLine(string.Join(",", cluster.Cluster1.ToArray()));
            Console.WriteLine(string.Join(",", cluster.Cluster2.ToArray()));


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
        public static String Print2DArray<T>(T[,] matrix)
        {
            String result="";
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    result += matrix[i, j] + "\t";
                }

                result = result.Remove(result.Length - 1);
                result += "\n";

            }

            result = result.Remove(result.Length - 1);



            return result;

        }


    }
}
