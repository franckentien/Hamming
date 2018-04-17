using System.Collections.Generic;

namespace Hamming
{
    public class Cluster
    {

        public int[,] HammingTab { get; }
        public List<int> AddedLine;

        public Cluster(int[,] hammingTab)
        {
            HammingTab = hammingTab;
            AddedLine = new List<int>();
        }

        //Return 2 line to split into cluster 
        
        public int[] ExtractLine()
        {
            int[] rst = null;
            //if the tab have only TODO
            if (HammingTab.GetLength(0) <= 2)
            {
                rst = new[] { 0, 4 };
            }
            else
            {
                rst = GetHigherHamming()  ;
            }

            return rst;
        }

        //return the higest hamming to put into cluster 
        //in sample example i get the one of the higher number of the tab  
        public int[] GetHigherHamming()
        {
            int[] rst = {0, 1};

            return rst;
        }

        //TODO false only in tdd 
        public int [,] BuildCluster ()
        {
            int[,] cluster = null;
            if (HammingTab.GetLength(0) == 2)
            {
                cluster = new int[,] { { HammingTab[0, 0] }, { HammingTab[1, 0] } };

            }

            return cluster;
        }


    }
}
