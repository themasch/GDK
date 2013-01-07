using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace GDK
{
    class Feld<T> where T : Control, new()
    {
        private int rows;
        private int cols;
        private T[,] content;
        public int Rows
        {
            get { return rows; }
        }
        public int Cols
        {
            get { return cols; }
        }
        public T[,] Content
        {
            get { return content; }
        }

        public Feld(int rows, int cols) {
            this.rows = rows;
            this.cols = cols;
            this.createField();
        }
        private void createField()
        {
            content = new T[rows, cols];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {  
                    content[i, j] = new T();
                    //content[i, j].SetBounds(j * 100, i * 100, 100, 100);
                    //content[i, j].BackColor = Color.Red;
                }
            }
        }
    }
}
