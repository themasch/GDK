using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;


namespace GDK
{
	public class Anwendung : Form
	{
		public static void Main (String[] argv)
		{
			Anwendung app = new Anwendung();
            Application.EnableVisualStyles();
            Application.Run(app);
			app.Start();
		}

		public Anwendung ()
		{
            Feld<Label> meinFeld = FeldErzeuger<Label>.erzeugeFeld(3, 5);
            Label[,] cont = meinFeld.Content;
            this.Size = new System.Drawing.Size(800, 600);
		}

        public void Init()
        {

        }

        public void Start()
		{
		}
	}
}

