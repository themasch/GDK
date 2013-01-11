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
            /*
            // Beispiele für den Felderzeuger
            Feld<Button> meinFeld = FeldErzeuger<Button>.createField(4, 3);
            Button[,] cont = meinFeld.Content; // Zugriff auf die Elemente
            cont[1, 2].Text = "Neu";
            meinFeld.Width = 50;    // Breite verändern
            meinFeld.Height = 50;   // Höhe verändern
            foreach (Button l in cont)
            {
                this.Controls.Add(l);
                l.MouseEnter += new EventHandler(mouseEnter);
                l.MouseLeave += new EventHandler(mouseLeave);
            }
            this.Size = new System.Drawing.Size(200, 200);
            */
		}

        /*
        public void mouseLeave(object sender, EventArgs e)
        {
            Label b;
            if (sender is Label)
                b = (Label)sender;
            else
                return;
            b.BackColor = Color.LightGray;
        }

        public void mouseEnter(object sender, EventArgs e)
        {
            Label b;
            if (sender is Label)
                b = (Label)sender;
            else
                return;
            b.BackColor = Color.Yellow;
        }
        */

        public void Init()
        {

        }

        public void Start()
		{
		}
	}
}

