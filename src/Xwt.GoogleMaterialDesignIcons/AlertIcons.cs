using System;
using Xwt.Drawing;

namespace Xwt.GoogleMaterialDesignIcons
{
	public class AlertIcons
	{
		static Image GetIcon (string id)
		{
			string resourceId = typeof(AlertIcons).Assembly.FullName.Split (',') [0] + ".Resources.Alert." + id + "32px.png";
			return Image.FromResource (typeof(AlertIcons), resourceId);
		}

		public static Image AddAlert { get { return GetIcon (AlertIconId.AddAlert); } }

		public static Image Error { get { return GetIcon (AlertIconId.Error); } }

		public static Image ErrorOutline { get { return GetIcon (AlertIconId.ErrorOutline); } }

		public static Image Warning { get { return GetIcon (AlertIconId.Warning); } }
	}
}
