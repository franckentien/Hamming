using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HammingTest
{
    using Hamming;

    [TestClass]
    public class HammingTest
    {
        [TestMethod]
        public void TestCalculHamming2LigneHamming0CheckLine1ToLine1()
        {
            int[,] matrice = new int[2, 2] { { 1, 0 }, { 2, 0 } };

            Hamming hamming = new Hamming(matrice);
            
            hamming.CalculHamming();

            Assert.AreEqual(hamming.HammingTab[0,0],0);
        }

        [TestMethod]
        public void TestCalculHamming2Ligne1Hamming0CheckLine2ToLine2()
        { 
            int[,] matrice = new int[2, 2] { { 1, 0 }, { 2, 0 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CalculHamming();

            Assert.AreEqual(hamming.HammingTab[1, 1], 0);
        }

        [TestMethod]
        public void TestCalculHamming2Ligne1Hamming0CheckLine1ToLine2()
        {
            int[,] matrice = new int[2, 2] { { 1, 0 }, { 2, 0 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CalculHamming();

            Assert.AreEqual(hamming.HammingTab[0,1], 0);
        }




    }
}
