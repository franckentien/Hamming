// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hamming.cs" company="Franck CAYZAC">
//   Franck CAYZAC EPSI 
// </copyright>
// <summary>
//   The hamming.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Hamming
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// The hamming.
    /// </summary>
    public class Hamming
    {

        /// <summary>
        /// Gets or sets the matrice.
        /// </summary>
        public int[,] Matrice { get; private set; }
        public int[,] HammingTab { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hamming"/> class.
        /// </summary>
        /// <param name="matrice">
        /// The matrice.
        /// </param>
        public Hamming(int[,] matrice)
        {
            this.Matrice = matrice;
            this.HammingTab = new int[Matrice.GetLength(0),Matrice.GetLength(1)];
        }

        /// <summary>
        /// The calcul hamming.
        /// </summary>
        public void CreateHammingTab()
        {
            for (int i = 0; i < Matrice.GetLength(0); i++)
            {
                for (int j = 0; j < Matrice.GetLength(1); j++)
                {
                    HammingTab[i, j] = calculHamming(i,j);
                }
            }

         
        }

        public void DisplayHammingTab()
        {
            for (int i = 0; i < Matrice.GetLength(0); i++)
            {
                for (int j = 0; j < Matrice.GetLength(1); j++)
                {
                    Console.Write("[" + HammingTab[i,j] + "]");
                }
            }
        }

        private int calculHamming(int line1, int line2)
        {
            var hamming = 0;

            for ( var i = 1; i < Matrice.GetLength(1); i++)
            {
                if (Matrice[line1, i] != Matrice[line2, i])
                {
                    hamming++;
                }
            }

            return hamming;
        } 



    }
}