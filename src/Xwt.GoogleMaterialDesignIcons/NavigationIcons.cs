using System;
using Xwt.Drawing;

namespace Xwt.GoogleMaterialDesignIcons
{
	public class NavigationIcons
	{
		static Image GetIcon (string id)
		{
			string resourceId = typeof(NavigationIcons).Assembly.FullName.Split (',') [0] + ".Resources.Navigation." + id + "32px.png";
			return Image.FromResource (typeof(NavigationIcons), resourceId);
		}

		public static Image Apps { get { return GetIcon (NavigationIconId.Apps); } }

		public static Image ArrowBack { get { return GetIcon (NavigationIconId.ArrowBack); } }

		public static Image ArrowDownward { get { return GetIcon (NavigationIconId.ArrowDownward); } }

		public static Image ArrowDropDown { get { return GetIcon (NavigationIconId.ArrowDropDown); } }

		public static Image ArrowDropDownCircle { get { return GetIcon (NavigationIconId.ArrowDropDownCircle); } }

		public static Image ArrowDropUp { get { return GetIcon (NavigationIconId.ArrowDropUp); } }

		public static Image ArrowForward { get { return GetIcon (NavigationIconId.ArrowForward); } }

		public static Image ArrowUpward { get { return GetIcon (NavigationIconId.ArrowUpward); } }

		public static Image Cancel { get { return GetIcon (NavigationIconId.Cancel); } }

		public static Image Check { get { return GetIcon (NavigationIconId.Check); } }

		public static Image ChevronLeft { get { return GetIcon (NavigationIconId.ChevronLeft); } }

		public static Image ChevronRight { get { return GetIcon (NavigationIconId.ChevronRight); } }

		public static Image Close { get { return GetIcon (NavigationIconId.Close); } }

		public static Image ExpandLess { get { return GetIcon (NavigationIconId.ExpandLess); } }

		public static Image ExpandMore { get { return GetIcon (NavigationIconId.ExpandMore); } }

		public static Image FirstPage { get { return GetIcon (NavigationIconId.FirstPage); } }

		public static Image Fullscreen { get { return GetIcon (NavigationIconId.Fullscreen); } }

		public static Image FullscreenExit { get { return GetIcon (NavigationIconId.FullscreenExit); } }

		public static Image LastPage { get { return GetIcon (NavigationIconId.LastPage); } }

		public static Image Menu { get { return GetIcon (NavigationIconId.Menu); } }

		public static Image MoreHoriz { get { return GetIcon (NavigationIconId.MoreHoriz); } }

		public static Image MoreVert { get { return GetIcon (NavigationIconId.MoreVert); } }

		public static Image Refresh { get { return GetIcon (NavigationIconId.Refresh); } }

		public static Image SubdirectoryArrowLeft { get { return GetIcon (NavigationIconId.SubdirectoryArrowLeft); } }

		public static Image SubdirectoryArrowRight { get { return GetIcon (NavigationIconId.SubdirectoryArrowRight); } }

		public static Image UnfoldLess { get { return GetIcon (NavigationIconId.UnfoldLess); } }

		public static Image UnfoldMore { get { return GetIcon (NavigationIconId.UnfoldMore); } }
	}
}
