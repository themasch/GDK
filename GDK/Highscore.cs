using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GDK
{
    class Highscore
    {
        private String filename;
        private String[,] data;

        public Highscore(String filename)
        {
            this.filename = filename;
            this.data = CSV.read(filename);
        }

        public void sortList()
        {
            int anzahlEintraege = this.data.GetLength(0);
            String[,] newData = new String[anzahlEintraege, 2];

            // Sortiert eintragen
            
            for (int i = 0; i < anzahlEintraege; i++)
            {
                int maxWert = 0;
                int chosenIdx = 0;
                // Wir picken den höchsten Wert
                for (int j = 0; j < anzahlEintraege; j++)
                {
                    if (Convert.ToInt32(this.data[j, 1]) > maxWert)
                    {
                        maxWert = Convert.ToInt32(this.data[j, 1]);
                        chosenIdx = j;
                    }
                }

                // Wert nullen                
                newData[i, 0] = this.data[chosenIdx, 0];
                newData[i, 1] = this.data[chosenIdx, 1];

                this.data[chosenIdx, 0] = "";
                this.data[chosenIdx, 1] = "0";

            }


            this.data = newData;
        }

        public void dumpList()
        {
            int anzahlEintraege = this.data.GetLength(0);

            // Sortiert eintragen

            for (int i = 0; i < anzahlEintraege; i++)
            {
                Console.WriteLine((i + 1) + " " + this.data[i,0] + " " + this.data[i,1]); 
            }
        }

        public String[,] getData()
        {
            return this.data;
        }

        public void eintragen(String name, int punkte)
        {
            // Array vergrößern
            int anzahlEintraege = this.data.GetLength(0);
            String[,] newData = new String[anzahlEintraege + 1, 2];

            int lastIdx = 0;
            for (int i = 0; i < anzahlEintraege; i++)
            {
                newData[i, 0] = this.data[i, 0];
                newData[i, 1] = this.data[i, 1];

                lastIdx = i;
            }

            newData[lastIdx + 1, 0] = name;
            newData[lastIdx + 1, 1] = punkte.ToString();

            this.data = newData;
        }

        public void save()
        {
            CSV.write(this.data, this.filename);
        }

    }
}
