using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HammingTest
{
    using Hamming;

    [TestClass]
    public class HammingTest
    {

        #region TestConstructor

        [TestMethod]
        public void TestConstructorCopyMatrice()
        {
            int[,] matrice = { { 1, 0 }, { 2, 0 } };

            Hamming hamming = new Hamming(matrice);

            Assert.AreEqual(Program.Print2DArray(hamming.Matrice), Program.Print2DArray(matrice));
        }

        [TestMethod]
        public void TestConstructorBuildHammingTab2ValueHeight()
        {
            int[,] matrice = { { 1, 0, 0 }, { 2, 0, 0 } };

            Hamming hamming = new Hamming(matrice);

            Assert.AreEqual(hamming.HammingTab.GetLength(0),2);
        }

        [TestMethod]
        public void TestConstructorBuildHammingTab2ValueLenght()
        {
            int[,] matrice = { { 1, 0, 0 }, { 2, 0, 0 } };

            Hamming hamming = new Hamming(matrice);

            Assert.AreEqual(hamming.HammingTab.GetLength(1), 2);
        }

        [TestMethod]
        public void TestConstructorBuildHammingTab3Value()
        {
            int[,] matrice = { { 1, 0 }, { 2, 0 }, { 2, 0 } };

            Hamming hamming = new Hamming(matrice);

            Console.WriteLine(Program.Print2DArray(hamming.HammingTab));

            Assert.AreEqual(hamming.HammingTab.GetLength(0), 3);
        }


        #endregion TestConstructor


        #region TestCalculHamming

        [TestMethod]
        public void TestCalculHamming2ValueHamming0()
        {
            int[,] matrice = { { 1, 0, 0 }, { 2, 0, 0 } };

            Hamming hamming = new Hamming(matrice);

            Assert.AreEqual(hamming.CalculHamming(0, 1), 0);
        }

        [TestMethod]
        public void TestCalculHamming2ValueHamming1()
        {
            int[,] matrice = { { 1, 0, 0 }, { 2, 2, 0 } };

            Hamming hamming = new Hamming(matrice);

            Assert.AreEqual(hamming.CalculHamming(0, 1), 1);
        }

        [TestMethod]
        public void TestCalculHamming2ValueHamming2()
        {
            int[,] matrice = { { 1, 0, 0 }, { 2, 2, 2 } };

            Hamming hamming = new Hamming(matrice);

            Assert.AreEqual(hamming.CalculHamming(0, 1), 2);
        }

        [TestMethod]
        public void TestCalculHamming3Line2ValueHamming2()
        {
            int[,] matrice = { { 0, 0, 0 }, { 1, 0, 0 }, { 2, 2, 2 } };

            Hamming hamming = new Hamming(matrice);

            Assert.AreEqual(hamming.CalculHamming(0, 2), 2);
        }

        #endregion TestCalculHamming

        #region TestCreateHammingTab

        [TestMethod]
        public void TestCreateHammingTab2LineHamming0CheckLine1ToLine1()
        {
            int[,] matrice = { { 1, 0 }, { 2, 0 } };

            Hamming hamming = new Hamming(matrice);
            
            hamming.CreateHammingTab();

            Assert.AreEqual(hamming.HammingTab[0,0],0);
        }

        [TestMethod]
        public void TestCreateHammingTab2Line1Hamming0CheckLine2ToLine2()
        { 
            int[,] matrice = { { 1, 0 }, { 2, 0 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CreateHammingTab();

            Assert.AreEqual(hamming.HammingTab[1, 1], 0);
        }

        [TestMethod]
        public void TestCreateHammingTab2Line1Hamming0CheckLine1ToLine2()
        {
            int[,] matrice = { { 1, 0 }, { 2, 0 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CreateHammingTab();

            Assert.AreEqual(hamming.HammingTab[0,1], 0);
        }

        [TestMethod]
        public void TestCreateHammingTab2Line1Hamming0CheckMirrorLine()
        {
            int[,] matrice = { { 1, 0 }, { 2, 0 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CreateHammingTab();

            Assert.AreEqual(hamming.HammingTab[1, 0], 0);
        }

        [TestMethod]
        public void TestCreateHammingTab2LineHamming1CheckLine1ToLine1()
        {
            int[,] matrice = { { 1, 0 }, { 2, 1 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CreateHammingTab();

            Assert.AreEqual(hamming.HammingTab[0, 0], 0);
        }

        [TestMethod]
        public void TestCreateHammingTab2Line1Hamming1CheckLine2ToLine2()
        {
            int[,] matrice = { { 1, 0 }, { 2, 1 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CreateHammingTab();

            Assert.AreEqual(hamming.HammingTab[1, 1], 0);
        }

        [TestMethod]
        public void TestCreateHammingTab2Line1Hamming1CheckLine1ToLine2IntDif1()
        {
            int[,] matrice = { { 1, 0 }, { 2, 1 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CreateHammingTab();

            Assert.AreEqual(hamming.HammingTab[0, 1], 1);
        }

        [TestMethod]
        public void TestCreateHammingTab2Line1Hamming1CheckLine1ToLine2IntDif9()
        {
            int[,] matrice = { { 1, 0 }, { 2, 9 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CreateHammingTab();

            Assert.AreEqual(hamming.HammingTab[0, 1], 1);
        }

        [TestMethod]
        public void TestCreateHammingTab2Line1Hamming1CheckMirrorLine()
        {
            int[,] matrice = { { 1, 0 }, { 2, 1 } };

            Hamming hamming = new Hamming(matrice);

            hamming.CreateHammingTab();

            Assert.AreEqual(hamming.HammingTab[1, 0], 0);
        }

        #endregion TestCreateHammingTab


    }
}
