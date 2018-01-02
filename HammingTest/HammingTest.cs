using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HammingTest
{
    using Hamming;

    [TestClass]
    public class HammingTest
    {
        [TestMethod]
        public void TestCalculHamming2LineHamming0CheckLine1ToLine1()
        {
            int[,] matrice = new int[2, 2] { { 1, 0 }, { 2, 0 } };

            Hamming hamming = new Hamming(matrice);
            
            hamming.CalculHamming();

            Assert.AreEqual(hamming.HammingTab[0,0],0);
        }

        [TestMethod]
        public void TestCalculHamming2Line1Hamming0CheckLine2ToLine2()
        { 
            int[,] matrice = new int[2, 2] { { 1, 0 }, { 2, 0 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CalculHamming();

            Assert.AreEqual(hamming.HammingTab[1, 1], 0);
        }

        [TestMethod]
        public void TestCalculHamming2Line1Hamming0CheckLine1ToLine2()
        {
            int[,] matrice = new int[2, 2] { { 1, 0 }, { 2, 0 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CalculHamming();

            Assert.AreEqual(hamming.HammingTab[0,1], 0);
        }

        [TestMethod]
        public void TestCalculHamming2Line1Hamming0CheckMirrorLine()
        {
            int[,] matrice = new int[2, 2] { { 1, 0 }, { 2, 0 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CalculHamming();

            Assert.AreEqual(hamming.HammingTab[1, 0], 0);
        }

        [TestMethod]
        public void TestCalculHamming2LineHamming1CheckLine1ToLine1()
        {
            int[,] matrice = new int[2, 2] { { 1, 0 }, { 2, 1 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CalculHamming();

            Assert.AreEqual(hamming.HammingTab[0, 0], 0);
        }

        [TestMethod]
        public void TestCalculHamming2Line1Hamming1CheckLine2ToLine2()
        {
            int[,] matrice = new int[2, 2] { { 1, 0 }, { 2, 1 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CalculHamming();

            Assert.AreEqual(hamming.HammingTab[1, 1], 0);
        }

        [TestMethod]
        public void TestCalculHamming2Line1Hamming1CheckLine1ToLine2IntDif1()
        {
            int[,] matrice = new int[2, 2] { { 1, 0 }, { 2, 1 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CalculHamming();

            Assert.AreEqual(hamming.HammingTab[0, 1], 1);
        }

        [TestMethod]
        public void TestCalculHamming2Line1Hamming1CheckLine1ToLine2IntDif9()
        {
            int[,] matrice = new int[2, 2] { { 1, 0 }, { 2, 9 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CalculHamming();

            Assert.AreEqual(hamming.HammingTab[0, 1], 1);
        }

        [TestMethod]
        public void TestCalculHamming2Line1Hamming1CheckMirrorLine()
        {
            int[,] matrice = new int[2, 2] { { 1, 0 }, { 2, 1 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CalculHamming();

            Assert.AreEqual(hamming.HammingTab[1, 0], 0);
        }

    }
}
