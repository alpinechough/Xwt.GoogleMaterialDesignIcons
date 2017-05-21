using System;
using Xwt.Drawing;

namespace Xwt.GoogleMaterialDesignIcons
{
	public class SocialIcons
	{
		static Image GetIcon (string id)
		{
			string resourceId = typeof(SocialIcons).Assembly.FullName.Split (',') [0] + ".Resources.Social." + id + "32px.png";
			return Image.FromResource (typeof(SocialIcons), resourceId);
		}

		public static Image Cake { get { return GetIcon (SocialIconId.Cake); } }

		public static Image Domain { get { return GetIcon (SocialIconId.Domain); } }

		public static Image Group { get { return GetIcon (SocialIconId.Group); } }

		public static Image GroupAdd { get { return GetIcon (SocialIconId.GroupAdd); } }

		public static Image LocationCity { get { return GetIcon (SocialIconId.LocationCity); } }

		public static Image Mood { get { return GetIcon (SocialIconId.Mood); } }

		public static Image MoodBad { get { return GetIcon (SocialIconId.MoodBad); } }

		public static Image Notifications { get { return GetIcon (SocialIconId.Notifications); } }

		public static Image NotificationsActive { get { return GetIcon (SocialIconId.NotificationsActive); } }

		public static Image NotificationsNone { get { return GetIcon (SocialIconId.NotificationsNone); } }

		public static Image NotificationsOff { get { return GetIcon (SocialIconId.NotificationsOff); } }

		public static Image NotificationsPaused { get { return GetIcon (SocialIconId.NotificationsPaused); } }

		public static Image Pages { get { return GetIcon (SocialIconId.Pages); } }

		public static Image PartyMode { get { return GetIcon (SocialIconId.PartyMode); } }

		public static Image People { get { return GetIcon (SocialIconId.People); } }

		public static Image PeopleOutline { get { return GetIcon (SocialIconId.PeopleOutline); } }

		public static Image Person { get { return GetIcon (SocialIconId.Person); } }

		public static Image PersonAdd { get { return GetIcon (SocialIconId.PersonAdd); } }

		public static Image PersonOutline { get { return GetIcon (SocialIconId.PersonOutline); } }

		public static Image PlusOne { get { return GetIcon (SocialIconId.PlusOne); } }

		public static Image Poll { get { return GetIcon (SocialIconId.Poll); } }

		public static Image Public { get { return GetIcon (SocialIconId.Public); } }

		public static Image School { get { return GetIcon (SocialIconId.School); } }

		public static Image SentimentDissatisfied { get { return GetIcon (SocialIconId.SentimentDissatisfied); } }

		public static Image SentimentNeutral { get { return GetIcon (SocialIconId.SentimentNeutral); } }

		public static Image SentimentSatisfied { get { return GetIcon (SocialIconId.SentimentSatisfied); } }

		public static Image SentimentVeryDissatisfied { get { return GetIcon (SocialIconId.SentimentVeryDissatisfied); } }

		public static Image SentimentVerySatisfied { get { return GetIcon (SocialIconId.SentimentVerySatisfied); } }

		public static Image Share { get { return GetIcon (SocialIconId.Share); } }

		public static Image Whatshot { get { return GetIcon (SocialIconId.Whatshot); } }
	}
}
