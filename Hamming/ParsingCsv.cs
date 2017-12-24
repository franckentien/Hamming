// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParsingCsv.cs" company="Franck CAYZAC">
//   MIT
// </copyright>
// <summary>
//   The parsing csv.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace Hamming
{
    using System.Diagnostics;
    using System.IO;

    /// <summary>
    /// The parsing csv.
    /// </summary>
    public static class ParsingCsv
    {
        /// <summary>
        /// The path.
        /// </summary>
        private static readonly string Path = Directory.GetCurrentDirectory();

        private static int _nbLine;
        private static int _nbValueLine;
        private static string[,] _matrice;

        /// <summary>
        /// The read csv.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        private static void ReadCsv(string fileName)
        {
            // get file content
            var lines = File.ReadAllLines(Path + "/" + fileName, System.Text.Encoding.GetEncoding("iso-8859-1"));
            _nbLine = lines.Length;

            if (Checkfile(lines))
            {
                Debug.WriteLine("OK");
            }
            else
            {
                Debug.WriteLine("KO");
                throw new InvalidDataException("Bad file structure");
            }

            _matrice = new string[_nbLine, _nbValueLine];

            for (var i = 0; i < _nbLine; i++)
            {
                //Console.WriteLine(lines[i]);
                var values = lines[i].Split(';');
                for (var j = 0; j < _nbValueLine; j++)
                {
                    _matrice[i, j] = values[j];
                }
            }
        }

        /// <summary>
        /// check if all line have the same number of value
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private static bool Checkfile(IReadOnlyList<string> lines)
        {
            var splitedLine = lines[0].Split(';');
            _nbValueLine = splitedLine.Length;

            return lines.Select(line => line.Split(';')).All(values => _nbValueLine == values.Length);
        }

        /// <summary>
        /// The write csv.
        /// </summary>
        private static void WriteCsv()
        {
            File.WriteAllText("output.csv", "");

            for (var i = 0; i < _nbLine; i++)
            {

                for (var j = 0; j < _nbValueLine; j++)
                {
                    if (_matrice[i, j] == null) continue;
                    if (_matrice[i, j] != "")
                    {
                        File.AppendAllText("output.csv", _matrice[i, j]);
                        if (j != _nbValueLine - 1)
                        {
                            File.AppendAllText("output.csv", ";");
                        }
                    }
                }
                File.AppendAllText("output.csv", "\n");
            }
        }
    }
}