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
        private int width = 100;
        private int height = 100;
        private int rows;
        private int cols;
        private T[,] content;
        private int x = 0;
        private int y = 0;

        public int Width { set { width = value; resizeField(); } }
        public int Height { set { height = value; resizeField(); } }

        public int X { set { x = value; resizeField(); } }
        public int Y { set { y = value; resizeField(); } }

        public int Rows { get { return rows; } }
        public int Cols { get { return cols; } }
        public T[,] Content { get { return content; } }

        public Feld(int rows, int cols) {
            this.rows = rows;
            this.cols = cols;
            this.createField();
        }

        private void resizeField()
        {
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                    content[i, j].SetBounds((j * width)+x, (i * height)+y, width, height);
        }

        private void createField()
        {
            content = new T[rows, cols];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    content[i, j] = new T();
                    content[i, j].SetBounds((j * width)+x, (i * height)+y, width, height);
                    //content[i, j].Text = i + ", " + j;
                }
            }
        }
    }
}
