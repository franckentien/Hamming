namespace Hamming
{
    public class Cluster
    {


        public static int[] ExtractLine(int[,] hammingTab)
        {
            int[] rst = null;
            if (hammingTab.GetLength(0) <= 2)
            {
                rst = new[] { 0, 1 };
            }
            else
            {
                rst = GetHigherHamming(hammingTab)  ;
            }

            return rst;
        }

        public static int[] GetHigherHamming(int[,] hammingTab)
        {
            int[] rst = {0, 1};

            return rst;
        }

        public static int [,] BuildCluster (int[,] hammingTab)
        {
            int[,] cluster = null;
            if (hammingTab.GetLength(0) == 2)
            {
                cluster = new int[,] { { hammingTab[0, 0] }, { hammingTab[1, 0] } };

            }

            return cluster;
        }


    }
}
