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
    /// <summary>
    /// The hamming.
    /// </summary>
    public class Hamming
    {

        /// <summary>
        /// Gets or sets the matrice.
        /// </summary>
        public int[,] Matrice { get; }
        public int[,] HammingTab { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hamming"/> class.
        /// </summary>
        /// <param name="matrice">
        /// The matrice.
        /// </param>
        public Hamming(int[,] matrice)
        {
            this.Matrice = matrice;
            this.HammingTab = new int[Matrice.GetLength(0),Matrice.GetLength(0)];
        }

        /// <summary>
        /// The calcul hamming.
        /// </summary>
        public void CreateHammingTab()
        {
            for (int i = 0; i < Matrice.GetLength(0); i++)
            {
                for (int j = i; j < Matrice.GetLength(0); j++)
                {

                    HammingTab[i, j] = CalculHamming(i,j);
                }
            }
            
        }

        public int CalculHamming(int line1, int line2)
        {
            var hamming = 0;

            for (var i = 1; i < Matrice.GetLength(1); i++)
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