using System.Collections.Generic;

namespace Hamming
{
    public class Cluster
    {

        /*
         *
         *
         * for (int i = 0; i < T.length; i++) {
            if(Haming(T[0],T[i])>=3){
                Cluster2.add(i+1);
            }
            else {
                Cluster1.add(i+1);
            }

        }

         */



        public int[,] HammingTab { get; }
        public List<int> AddedLine;

        public Cluster(int[,] hammingTab)
        {
            HammingTab = hammingTab;
            AddedLine = new List<int>();
        }

        //Return 2 line to split into cluster 
        
        public int[] ExtractLines()
        {

            //Return the lines with the higher value 
            int[] rst = GetHigherHamming()  ;

            return rst;
        }

        //return the higest hamming to put into cluster 
        //in sample example i get the one of the higher number of the tab  
        public int[] GetHigherHamming()
        {

            int[] max = new[] {0, 0};
            int i, j;

            for (i = 0; i < HammingTab.GetLength(0); i++)
            for (j = 0; j < HammingTab.GetLength(1); j++)
            {
                if (HammingTab[i, j] > HammingTab[max[0], max[1]])
                {
                    max[0] = i;
                    max[1] = j;
                }

            }

            int[] rst = {max[0], max[1]};

            return rst;
        }

        //TODO false only in tdd 
        public int [,] BuildCluster ()
        {
            int[,] cluster = null;
            if (HammingTab.GetLength(0) == 2)
            {
                //TODO a verifier 
                cluster = new int[,] { { HammingTab[0, 0] }, { HammingTab[1, 0] } };

            }

            return cluster;
        }


    }
}
