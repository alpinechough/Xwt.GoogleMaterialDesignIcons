using System;
using Xwt.Drawing;

namespace Xwt.GoogleMaterialDesignIcons
{
	public class NotificationIcons
	{
		static Image GetIcon (string id)
		{
			string resourceId = typeof(NotificationIcons).Assembly.FullName.Split (',') [0] + ".Resources.Notification." + id + "32px.png";
			return Image.FromResource (typeof(NotificationIcons), resourceId);
		}

		public static Image Adb { get { return GetIcon (NotificationIconId.Adb); } }

		public static Image AirlineSeatFlat { get { return GetIcon (NotificationIconId.AirlineSeatFlat); } }

		public static Image AirlineSeatFlatAngled { get { return GetIcon (NotificationIconId.AirlineSeatFlatAngled); } }

		public static Image AirlineSeatIndividualSuite { get { return GetIcon (NotificationIconId.AirlineSeatIndividualSuite); } }

		public static Image AirlineSeatLegroomExtra { get { return GetIcon (NotificationIconId.AirlineSeatLegroomExtra); } }

		public static Image AirlineSeatLegroomNormal { get { return GetIcon (NotificationIconId.AirlineSeatLegroomNormal); } }

		public static Image AirlineSeatLegroomReduced { get { return GetIcon (NotificationIconId.AirlineSeatLegroomReduced); } }

		public static Image AirlineSeatReclineExtra { get { return GetIcon (NotificationIconId.AirlineSeatReclineExtra); } }

		public static Image AirlineSeatReclineNormal { get { return GetIcon (NotificationIconId.AirlineSeatReclineNormal); } }

		public static Image BluetoothAudio { get { return GetIcon (NotificationIconId.BluetoothAudio); } }

		public static Image ConfirmationNumber { get { return GetIcon (NotificationIconId.ConfirmationNumber); } }

		public static Image DiscFull { get { return GetIcon (NotificationIconId.DiscFull); } }

		public static Image DoNotDisturb { get { return GetIcon (NotificationIconId.DoNotDisturb); } }

		public static Image DoNotDisturbAlt { get { return GetIcon (NotificationIconId.DoNotDisturbAlt); } }

		public static Image DoNotDisturbOff { get { return GetIcon (NotificationIconId.DoNotDisturbOff); } }

		public static Image DoNotDisturbOn { get { return GetIcon (NotificationIconId.DoNotDisturbOn); } }

		public static Image DriveEta { get { return GetIcon (NotificationIconId.DriveEta); } }

		public static Image EnhancedEncryption { get { return GetIcon (NotificationIconId.EnhancedEncryption); } }

		public static Image EventAvailable { get { return GetIcon (NotificationIconId.EventAvailable); } }

		public static Image EventBusy { get { return GetIcon (NotificationIconId.EventBusy); } }

		public static Image EventNote { get { return GetIcon (NotificationIconId.EventNote); } }

		public static Image FolderSpecial { get { return GetIcon (NotificationIconId.FolderSpecial); } }

		public static Image LiveTv { get { return GetIcon (NotificationIconId.LiveTv); } }

		public static Image Mms { get { return GetIcon (NotificationIconId.Mms); } }

		public static Image More { get { return GetIcon (NotificationIconId.More); } }

		public static Image NetworkCheck { get { return GetIcon (NotificationIconId.NetworkCheck); } }

		public static Image NetworkLocked { get { return GetIcon (NotificationIconId.NetworkLocked); } }

		public static Image NoEncryption { get { return GetIcon (NotificationIconId.NoEncryption); } }

		public static Image OndemandVideo { get { return GetIcon (NotificationIconId.OndemandVideo); } }

		public static Image PersonalVideo { get { return GetIcon (NotificationIconId.PersonalVideo); } }

		public static Image PhoneBluetoothSpeaker { get { return GetIcon (NotificationIconId.PhoneBluetoothSpeaker); } }

		public static Image PhoneForwarded { get { return GetIcon (NotificationIconId.PhoneForwarded); } }

		public static Image PhoneInTalk { get { return GetIcon (NotificationIconId.PhoneInTalk); } }

		public static Image PhoneLocked { get { return GetIcon (NotificationIconId.PhoneLocked); } }

		public static Image PhoneMissed { get { return GetIcon (NotificationIconId.PhoneMissed); } }

		public static Image PhonePaused { get { return GetIcon (NotificationIconId.PhonePaused); } }

		public static Image Power { get { return GetIcon (NotificationIconId.Power); } }

		public static Image PriorityHigh { get { return GetIcon (NotificationIconId.PriorityHigh); } }

		public static Image RvHookup { get { return GetIcon (NotificationIconId.RvHookup); } }

		public static Image SdCard { get { return GetIcon (NotificationIconId.SdCard); } }

		public static Image SimCardAlert { get { return GetIcon (NotificationIconId.SimCardAlert); } }

		public static Image Sms { get { return GetIcon (NotificationIconId.Sms); } }

		public static Image SmsFailed { get { return GetIcon (NotificationIconId.SmsFailed); } }

		public static Image Sync { get { return GetIcon (NotificationIconId.Sync); } }

		public static Image SyncDisabled { get { return GetIcon (NotificationIconId.SyncDisabled); } }

		public static Image SyncProblem { get { return GetIcon (NotificationIconId.SyncProblem); } }

		public static Image SystemUpdate { get { return GetIcon (NotificationIconId.SystemUpdate); } }

		public static Image TapAndPlay { get { return GetIcon (NotificationIconId.TapAndPlay); } }

		public static Image TimeToLeave { get { return GetIcon (NotificationIconId.TimeToLeave); } }

		public static Image Vibration { get { return GetIcon (NotificationIconId.Vibration); } }

		public static Image VoiceChat { get { return GetIcon (NotificationIconId.VoiceChat); } }

		public static Image VpnLock { get { return GetIcon (NotificationIconId.VpnLock); } }

		public static Image Wc { get { return GetIcon (NotificationIconId.Wc); } }

		public static Image Wifi { get { return GetIcon (NotificationIconId.Wifi); } }
	}
}
