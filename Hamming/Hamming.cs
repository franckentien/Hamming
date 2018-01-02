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
        public void CalculHamming()
        {

        } 



    }
}