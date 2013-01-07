using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GDK
{
    /// <summary>
    /// Diese Klasse liest eine CSV Datei aus oder schreibt sie.
    /// </summary>
    class CSV
    {
        /// <summary>
        /// Gibt ein 2Dimensionales Array der Einträge in der Datei "file" zurück
        /// </summary>
        /// <example>
        /// <code>
        /// String[,] matrix = CSV.read("test.csv");
        /// </code>
        /// </example>
        public static String[,] read(String file)
        {
            StreamReader sr = new StreamReader(@file);
            String content = sr.ReadToEnd();
            String[] lines = content.Split('\n');
            int rows = lines.Length;
            int cols = lines[0].Length;
            String[,] ret = new String[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                String[] tokens = lines[i].Split(';');
                for (int j = 0; j < tokens.Length; j++)
                    ret[i, j] = tokens[j];
            }
            return ret;
        }

        /// <summary>
        /// Schreibt die Daten in "data" in die Datei "file"
        /// </summary>
        /// <example>
        /// <code>
        /// 
        /// String[,] data = new String[2, 2];
        /// for (int i = 0; i < data.GetLength(0); i++)
        ///     for (int j = 0; j < data.GetLength(1); j++)
        ///         data[i, j] = i + "_" + j;
        /// CSV.write(data, "test.csv");
        /// 
        /// </code>
        /// Schreibt folgende Matrix in die Datei "test.csv"
        /// 
        /// 0_0 0_1
        /// 1_0 1_1
        /// </example>
        public static void write(String[,] data, String file)
        {
            StreamWriter sw = new StreamWriter(@file);
            for (int i = 0; i < data.GetLength(0); i++) {
                for (int j = 0; j < data.GetLength(1); j++) {
                    sw.Write(data[i, j] + ";");
                }
                sw.Write("\n");
            }
            sw.Close();
        }
    }
}
