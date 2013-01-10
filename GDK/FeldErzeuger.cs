using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDK
{
    class FeldErzeuger<T> where T : Control, new()
    {
        public static Feld<T> createField(int rows, int cols)
        {
            return new Feld<T>(rows, cols);
        }
    }
}
