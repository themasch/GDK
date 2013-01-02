using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GDK
{
	/**
	 * Diese Klasse verwaltet die eingebetteten Ressourcen wie Bilder
	 */
	public class Ressourcen
	{
		/**
		 * gibt eine Liste aller Bilder zurück
		 */
		public static List<Image> getBilder ()
		{	
			List<Image> imglist = new List<Image>();
			System.Reflection.Assembly asmb = System.Reflection.Assembly.GetEntryAssembly();			
			foreach (string one in asmb.GetManifestResourceNames()) {
				if(one.StartsWith("GDK.Bilder")) {
					Bitmap bmp = new Bitmap (asmb.GetManifestResourceStream (one));
					imglist.Add(bmp);
				}
			}
			return imglist;
		}
	}
}

