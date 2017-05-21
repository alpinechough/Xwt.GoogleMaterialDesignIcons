using System;
using Xwt.Drawing;

namespace Xwt.GoogleMaterialDesignIcons
{
	public class PlacesIcons
	{
		static Image GetIcon (string id)
		{
			string resourceId = typeof(PlacesIcons).Assembly.FullName.Split (',') [0] + ".Resources.Places." + id + "32px.png";
			return Image.FromResource (typeof(PlacesIcons), resourceId);
		}

		public static Image AcUnit { get { return GetIcon (PlacesIconId.AcUnit); } }

		public static Image AirportShuttle { get { return GetIcon (PlacesIconId.AirportShuttle); } }

		public static Image AllInclusive { get { return GetIcon (PlacesIconId.AllInclusive); } }

		public static Image BeachAccess { get { return GetIcon (PlacesIconId.BeachAccess); } }

		public static Image BusinessCenter { get { return GetIcon (PlacesIconId.BusinessCenter); } }

		public static Image Casino { get { return GetIcon (PlacesIconId.Casino); } }

		public static Image ChildCare { get { return GetIcon (PlacesIconId.ChildCare); } }

		public static Image ChildFriendly { get { return GetIcon (PlacesIconId.ChildFriendly); } }

		public static Image FitnessCenter { get { return GetIcon (PlacesIconId.FitnessCenter); } }

		public static Image FreeBreakfast { get { return GetIcon (PlacesIconId.FreeBreakfast); } }

		public static Image GolfCourse { get { return GetIcon (PlacesIconId.GolfCourse); } }

		public static Image HotTub { get { return GetIcon (PlacesIconId.HotTub); } }

		public static Image Kitchen { get { return GetIcon (PlacesIconId.Kitchen); } }

		public static Image Pool { get { return GetIcon (PlacesIconId.Pool); } }

		public static Image RoomService { get { return GetIcon (PlacesIconId.RoomService); } }

		public static Image RvHookup { get { return GetIcon (PlacesIconId.RvHookup); } }

		public static Image SmokeFree { get { return GetIcon (PlacesIconId.SmokeFree); } }

		public static Image SmokingRooms { get { return GetIcon (PlacesIconId.SmokingRooms); } }

		public static Image Spa { get { return GetIcon (PlacesIconId.Spa); } }
	}
}
