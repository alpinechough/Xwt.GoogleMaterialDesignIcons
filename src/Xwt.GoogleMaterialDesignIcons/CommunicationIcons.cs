using System;
using Xwt.Drawing;

namespace Xwt.GoogleMaterialDesignIcons
{
	public class CommunicationIcons
	{
		static Image GetIcon (string id)
		{
			string resourceId = typeof(CommunicationIcons).Assembly.FullName.Split (',') [0] + ".Resources.Communication." + id + "32px.png";
			return Image.FromResource (typeof(CommunicationIcons), resourceId);
		}

		public static Image Business { get { return GetIcon (CommunicationIconId.Business); } }

		public static Image Call { get { return GetIcon (CommunicationIconId.Call); } }

		public static Image CallEnd { get { return GetIcon (CommunicationIconId.CallEnd); } }

		public static Image CallMade { get { return GetIcon (CommunicationIconId.CallMade); } }

		public static Image CallMerge { get { return GetIcon (CommunicationIconId.CallMerge); } }

		public static Image CallMissed { get { return GetIcon (CommunicationIconId.CallMissed); } }

		public static Image CallMissedOutgoing { get { return GetIcon (CommunicationIconId.CallMissedOutgoing); } }

		public static Image CallReceived { get { return GetIcon (CommunicationIconId.CallReceived); } }

		public static Image CallSplit { get { return GetIcon (CommunicationIconId.CallSplit); } }

		public static Image Chat { get { return GetIcon (CommunicationIconId.Chat); } }

		public static Image ChatBubble { get { return GetIcon (CommunicationIconId.ChatBubble); } }

		public static Image ChatBubbleOutline { get { return GetIcon (CommunicationIconId.ChatBubbleOutline); } }

		public static Image ClearAll { get { return GetIcon (CommunicationIconId.ClearAll); } }

		public static Image Comment { get { return GetIcon (CommunicationIconId.Comment); } }

		public static Image ContactMail { get { return GetIcon (CommunicationIconId.ContactMail); } }

		public static Image ContactPhone { get { return GetIcon (CommunicationIconId.ContactPhone); } }

		public static Image Contacts { get { return GetIcon (CommunicationIconId.Contacts); } }

		public static Image DialerSip { get { return GetIcon (CommunicationIconId.DialerSip); } }

		public static Image Dialpad { get { return GetIcon (CommunicationIconId.Dialpad); } }

		public static Image Email { get { return GetIcon (CommunicationIconId.Email); } }

		public static Image Forum { get { return GetIcon (CommunicationIconId.Forum); } }

		public static Image ImportContacts { get { return GetIcon (CommunicationIconId.ImportContacts); } }

		public static Image ImportExport { get { return GetIcon (CommunicationIconId.ImportExport); } }

		public static Image InvertColorsOff { get { return GetIcon (CommunicationIconId.InvertColorsOff); } }

		public static Image LiveHelp { get { return GetIcon (CommunicationIconId.LiveHelp); } }

		public static Image LocationOff { get { return GetIcon (CommunicationIconId.LocationOff); } }

		public static Image LocationOn { get { return GetIcon (CommunicationIconId.LocationOn); } }

		public static Image MailOutline { get { return GetIcon (CommunicationIconId.MailOutline); } }

		public static Image Message { get { return GetIcon (CommunicationIconId.Message); } }

		public static Image NoSim { get { return GetIcon (CommunicationIconId.NoSim); } }

		public static Image Phone { get { return GetIcon (CommunicationIconId.Phone); } }

		public static Image PortableWifiOff { get { return GetIcon (CommunicationIconId.PortableWifiOff); } }

		public static Image PresentToAll { get { return GetIcon (CommunicationIconId.PresentToAll); } }

		public static Image RingVolume { get { return GetIcon (CommunicationIconId.RingVolume); } }

		public static Image RssFeed { get { return GetIcon (CommunicationIconId.RssFeed); } }

		public static Image ScreenShare { get { return GetIcon (CommunicationIconId.ScreenShare); } }

		public static Image SpeakerPhone { get { return GetIcon (CommunicationIconId.SpeakerPhone); } }

		public static Image StayCurrentLandscape { get { return GetIcon (CommunicationIconId.StayCurrentLandscape); } }

		public static Image StayCurrentPortrait { get { return GetIcon (CommunicationIconId.StayCurrentPortrait); } }

		public static Image StayPrimaryLandscape { get { return GetIcon (CommunicationIconId.StayPrimaryLandscape); } }

		public static Image StayPrimaryPortrait { get { return GetIcon (CommunicationIconId.StayPrimaryPortrait); } }

		public static Image StopScreenShare { get { return GetIcon (CommunicationIconId.StopScreenShare); } }

		public static Image SwapCalls { get { return GetIcon (CommunicationIconId.SwapCalls); } }

		public static Image Textsms { get { return GetIcon (CommunicationIconId.Textsms); } }

		public static Image Voicemail { get { return GetIcon (CommunicationIconId.Voicemail); } }

		public static Image VpnKey { get { return GetIcon (CommunicationIconId.VpnKey); } }
	}
}
