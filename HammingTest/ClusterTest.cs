using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using  Hamming;

namespace HammingTest
{
    [TestClass]
    public class ClusterTest
    {

        #region ExtractLine

        [TestMethod]
        public void TestExtractLine2LineHamming0()
        {
            int[,] hammingTab = { { 0, 0 }, { 0, 0 } };

            Cluster cluster = new Cluster(hammingTab);

            int[] line = cluster.ExtractLine();

            int[] result = { 0, 1 };
            Assert.AreEqual(string.Join(",", line), string.Join(",", result));
        }

        [TestMethod]
        public void TestExtractLine2LineHamming1()
        {
            int[,] hammingTab = { { 0, 0 }, { 0, 1 } };

            Cluster cluster = new Cluster(hammingTab);

            int[] line = cluster.ExtractLine();

            int[] result = { 0, 1 };
            Assert.AreEqual(string.Join(",", line), string.Join(",", result));
        }


        [TestMethod]
        public void TestExtractLine3LineHamming0()
        {
            int[,] hammingTab = { { 0, 0,0 }, { 0, 0, 0 }, { 0, 0, 0} };

            Cluster cluster = new Cluster(hammingTab);

            int[] line = cluster.ExtractLine();

            int[] result = { 0, 1 };
            Assert.AreEqual(string.Join(",", line), string.Join(",", result));
        }

        #endregion ExtractLine



        [TestMethod]
        public void TestBuild2ClusterWith2ValueHamming0()
        {
            int [,] hammingTab = {{1,0},{2,0}};

            int[,] cluster = Cluster.BuildCluster(hammingTab);

            int[,] result = {{1}, {2}};
            Assert.AreEqual(Program.Print2DArray(cluster),Program.Print2DArray(result));
        }


    }
}
