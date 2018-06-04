using System;
using System.Collections.Generic;

namespace Hamming
{
    public class Cluster
    {

        public int[,] HammingTab { get; }
        public List<int> AddedLine;
        public List<int> Cluster1;
        public List<int> Cluster2;

        public Cluster(int[,] hammingTab)
        {
            HammingTab = hammingTab;
            AddedLine = new List<int>();
            Cluster1 = new List<int>();
            Cluster2 = new List<int>();
        }

        //Return 2 line to split into cluster 
        
        public int[] ExtractLines()
        {

            //Return the lines with the higher value 
            int[] rst = GetHigherHamming();

            //If the element is not in a cluster
            if (!Cluster1.Contains(rst[0] + 1) && !Cluster2.Contains(rst[0] +1))
            {
                Cluster1.Add(rst[0] + 1);

                AddedLine.Add(rst[0] + 1);
            }

            if (!Cluster1.Contains(rst[1] + 1) && !Cluster2.Contains(rst[1] + 1))
            {
                Cluster2.Add(rst[1] + 1);

                AddedLine.Add(rst[1] + 1);
            }

            return rst;
        }

        //return the higest hamming to put into cluster 
        //in sample example i get the one of the higher number of the tab  
        public int[] GetHigherHamming()
        {

            int[] max = new[] {0, 1};


            for (int i = 0; i < HammingTab.GetLength(0); i++)
            for (int j = 0; j < HammingTab.GetLength(1); j++)
            {
                if (HammingTab[i, j] > HammingTab[max[0], max[1]])
                {
                    max[0] = i;
                    max[1] = j;
                }

            }

            int[] rst = {Math.Min(max[0], max[1]), Math.Max(max[0], max[1]) };
            HammingTab[max[0], max[1]] = 0;
            
            return rst;
        }

        public string  BuildCluster ()
        {
            int[,] cluster = null;
            while (HammingTab.GetLength(0) > AddedLine.Count)
            {
                ExtractLines();
            }


            string rst = "";

            rst += string.Join(",", Cluster1.ToArray());
            rst += "\n";
            rst += string.Join(",", Cluster2.ToArray());

            return rst;
        }


    }
}
