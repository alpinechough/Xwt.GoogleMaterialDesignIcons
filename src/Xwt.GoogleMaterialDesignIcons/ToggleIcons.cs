using System;
using Xwt.Drawing;

namespace Xwt.GoogleMaterialDesignIcons
{
	public class ToggleIcons
	{
		static Image GetIcon (string id)
		{
			string resourceId = typeof(ToggleIcons).Assembly.FullName.Split (',') [0] + ".Resources.Toggle." + id + "32px.png";
			return Image.FromResource (typeof(ToggleIcons), resourceId);
		}

		public static Image CheckBox { get { return GetIcon (ToggleIconId.CheckBox); } }

		public static Image CheckBoxOutlineBlank { get { return GetIcon (ToggleIconId.CheckBoxOutlineBlank); } }

		public static Image RadioButtonChecked { get { return GetIcon (ToggleIconId.RadioButtonChecked); } }

		public static Image RadioButtonUnchecked { get { return GetIcon (ToggleIconId.RadioButtonUnchecked); } }

		public static Image StarHalf { get { return GetIcon (ToggleIconId.StarHalf); } }
	}
}
