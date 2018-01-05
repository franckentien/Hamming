using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using  Hamming;

namespace HammingTest
{
    [TestClass]
    public class ClusterTest
    {

        [TestMethod]
        public void TestExtractLine2LineHamming0()
        {
            int[,] hammingTab = { { 0, 0 }, { 0, 0 } };

            int[] line = Cluster.ExtractLine(hammingTab);

            int[] result = { 0, 1 };
            Assert.AreEqual(string.Join(",", line), string.Join(",", result));
        }

        [TestMethod]
        public void TestExtractLine3LineHamming0()
        {
            int[,] hammingTab = { { 0, 0,0 }, { 0, 0, 0 }, { 0, 0, 0} };

            int[] line = Cluster.ExtractLine(hammingTab);

            int[] result = { 0, 1 };
            Assert.AreEqual(string.Join(",", line), string.Join(",", result));
        }




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
