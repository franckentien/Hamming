using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using  Hamming;

namespace HammingTest
{
    [TestClass]
    public class ClusterTest
    {

        #region ExtractLines

        [TestMethod]
        public void TestExtractLine2LineHamming0()
        {
            int[,] hammingTab = { { 0, 0 }, { 0, 0 } };

            Cluster cluster = new Cluster(hammingTab);

            int[] line = cluster.ExtractLines();

            int[] result = { 0, 1 };
            Assert.AreEqual(string.Join(",", line), string.Join(",", result));
        }

        [TestMethod]
        public void TestExtractLine2LineHamming1()
        {
            int[,] hammingTab = {   { 0, 0 }, 
                                    { 0, 1 } };

            Cluster cluster = new Cluster(hammingTab);

            int[] line = cluster.ExtractLines();

            int[] result = { 1, 1 };
            Assert.AreEqual(string.Join(",", line), string.Join(",", result));
        }


        [TestMethod]
        public void TestExtractLine3LineHamming0()
        {
            int[,] hammingTab = { { 0, 0, 0 }, 
                                    { 0, 0, 0 }, 
                                    { 0, 0, 0} };

            Cluster cluster = new Cluster(hammingTab);

            int[] line = cluster.ExtractLines();

            int[] result = {0, 1};
            Assert.AreEqual(string.Join(",", line), string.Join(",", result));
        }

        [TestMethod]
        public void TestExtractLine3LineHamming1Default()
        {
            int[,] hammingTab = { { 0, 0, 0 }, 
                                { 0, 0, 0 }, 
                                { 0, 0, 0 } };

            Cluster cluster = new Cluster(hammingTab);

            int[] line = cluster.ExtractLines();

            int[] result = { 0, 1 };
            Assert.AreEqual(string.Join(",", line), string.Join(",", result));
        }

        [TestMethod]
        public void TestExtractLine3LineHamming2Rst0And1()
        {
            int[,] hammingTab = { 
                { 0, 2, 0 }, //2 of difference between the line 0 and le line 1
                { 0, 0, 0 }, 
                { 0, 0, 0 } };

            Cluster cluster = new Cluster(hammingTab);

            int[] line = cluster.ExtractLines();

            int[] result = { 0, 1 };
            Assert.AreEqual(string.Join(",", line), string.Join(",", result));
        }

        [TestMethod]
        public void TestExtractLine3LineHamming2Rst1And2()
        {
            int[,] hammingTab = { 
                { 0, 0, 0 }, 
                { 0, 0, 2 }, //2 of differerence between the line 1 and the line 2
                { 0, 0, 0 } };

            Cluster cluster = new Cluster(hammingTab);

            int[] line = cluster.ExtractLines();

            int[] result = { 1, 2 };
            Assert.AreEqual(string.Join(",", line), string.Join(",", result));
        }

        #endregion ExtractLines


        #region GetHigherHamming

        [TestMethod]
        public void TestGetHigherHamming3LineHamming2Rst1And2()
        {
            int[,] hammingTab = {
                { 0, 0, 0 },
                { 0, 0, 2 }, //2 of differerence between the line 1 and the line 2
                { 0, 0, 0 } };

            Cluster cluster = new Cluster(hammingTab);

            int[] line = cluster.GetHigherHamming();

            int[] result = { 1, 2 };
            Assert.AreEqual(string.Join(",", line), string.Join(",", result));

        }

        [TestMethod]
        public void TestGetHigher2LineHamming1()
        {
            int[,] hammingTab = { { 0, 0 }, 
                                  { 0, 1 } };

            Cluster cluster = new Cluster(hammingTab);

            int[] line = cluster.GetHigherHamming();

            int[] result = { 1, 1 };
            Assert.AreEqual(string.Join(",", line), string.Join(",", result));

        }

        #endregion


        #region BuildCluster

        [TestMethod]
        public void TestBuild2ClusterWith2ValueHamming0()
        {
            int[,] hammingTab = { { 1, 0 }, { 2, 0 } };

            Cluster cluster = new Cluster(hammingTab);

            int[,] rstCluster = cluster.BuildCluster();

            int[,] result = { { 1 }, { 2 } };
            Assert.AreEqual(Program.Print2DArray(rstCluster), Program.Print2DArray(result));
        }

        #endregion




    }
}
