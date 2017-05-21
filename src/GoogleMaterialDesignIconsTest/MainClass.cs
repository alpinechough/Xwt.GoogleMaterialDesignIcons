using System;
using Xwt;

namespace GoogleMaterialDesignIconsTest
{
	public class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Initialize ();

			try {
				using (MainWindow w = new MainWindow ()) {
					w.Show ();

					Application.Run ();
				}
			} finally {
				Application.Dispose ();
			}
		}
	}
}

