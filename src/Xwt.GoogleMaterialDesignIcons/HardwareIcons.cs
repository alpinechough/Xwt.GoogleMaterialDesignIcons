using System;
using Xwt.Drawing;

namespace Xwt.GoogleMaterialDesignIcons
{
	public class HardwareIcons
	{
		static Image GetIcon (string id)
		{
			string resourceId = typeof(HardwareIcons).Assembly.FullName.Split (',') [0] + ".Resources.Hardware." + id + "32px.png";
			return Image.FromResource (typeof(HardwareIcons), resourceId);
		}

		public static Image Cast { get { return GetIcon (HardwareIconId.Cast); } }

		public static Image CastConnected { get { return GetIcon (HardwareIconId.CastConnected); } }

		public static Image Computer { get { return GetIcon (HardwareIconId.Computer); } }

		public static Image DesktopMac { get { return GetIcon (HardwareIconId.DesktopMac); } }

		public static Image DesktopWindows { get { return GetIcon (HardwareIconId.DesktopWindows); } }

		public static Image DeveloperBoard { get { return GetIcon (HardwareIconId.DeveloperBoard); } }

		public static Image DevicesOther { get { return GetIcon (HardwareIconId.DevicesOther); } }

		public static Image Dock { get { return GetIcon (HardwareIconId.Dock); } }

		public static Image Gamepad { get { return GetIcon (HardwareIconId.Gamepad); } }

		public static Image Headset { get { return GetIcon (HardwareIconId.Headset); } }

		public static Image HeadsetMic { get { return GetIcon (HardwareIconId.HeadsetMic); } }

		public static Image Keyboard { get { return GetIcon (HardwareIconId.Keyboard); } }

		public static Image KeyboardArrowDown { get { return GetIcon (HardwareIconId.KeyboardArrowDown); } }

		public static Image KeyboardArrowLeft { get { return GetIcon (HardwareIconId.KeyboardArrowLeft); } }

		public static Image KeyboardArrowRight { get { return GetIcon (HardwareIconId.KeyboardArrowRight); } }

		public static Image KeyboardArrowUp { get { return GetIcon (HardwareIconId.KeyboardArrowUp); } }

		public static Image KeyboardBackspace { get { return GetIcon (HardwareIconId.KeyboardBackspace); } }

		public static Image KeyboardCapslock { get { return GetIcon (HardwareIconId.KeyboardCapslock); } }

		public static Image KeyboardHide { get { return GetIcon (HardwareIconId.KeyboardHide); } }

		public static Image KeyboardReturn { get { return GetIcon (HardwareIconId.KeyboardReturn); } }

		public static Image KeyboardTab { get { return GetIcon (HardwareIconId.KeyboardTab); } }

		public static Image KeyboardVoice { get { return GetIcon (HardwareIconId.KeyboardVoice); } }

		public static Image Laptop { get { return GetIcon (HardwareIconId.Laptop); } }

		public static Image LaptopChromebook { get { return GetIcon (HardwareIconId.LaptopChromebook); } }

		public static Image LaptopMac { get { return GetIcon (HardwareIconId.LaptopMac); } }

		public static Image LaptopWindows { get { return GetIcon (HardwareIconId.LaptopWindows); } }

		public static Image Memory { get { return GetIcon (HardwareIconId.Memory); } }

		public static Image Mouse { get { return GetIcon (HardwareIconId.Mouse); } }

		public static Image PhoneAndroid { get { return GetIcon (HardwareIconId.PhoneAndroid); } }

		public static Image PhoneIphone { get { return GetIcon (HardwareIconId.PhoneIphone); } }

		public static Image Phonelink { get { return GetIcon (HardwareIconId.Phonelink); } }

		public static Image PhonelinkOff { get { return GetIcon (HardwareIconId.PhonelinkOff); } }

		public static Image PowerInput { get { return GetIcon (HardwareIconId.PowerInput); } }

		public static Image Router { get { return GetIcon (HardwareIconId.Router); } }

		public static Image Scanner { get { return GetIcon (HardwareIconId.Scanner); } }

		public static Image Security { get { return GetIcon (HardwareIconId.Security); } }

		public static Image SimCard { get { return GetIcon (HardwareIconId.SimCard); } }

		public static Image Smartphone { get { return GetIcon (HardwareIconId.Smartphone); } }

		public static Image Speaker { get { return GetIcon (HardwareIconId.Speaker); } }

		public static Image SpeakerGroup { get { return GetIcon (HardwareIconId.SpeakerGroup); } }

		public static Image Tablet { get { return GetIcon (HardwareIconId.Tablet); } }

		public static Image TabletAndroid { get { return GetIcon (HardwareIconId.TabletAndroid); } }

		public static Image TabletMac { get { return GetIcon (HardwareIconId.TabletMac); } }

		public static Image Toys { get { return GetIcon (HardwareIconId.Toys); } }

		public static Image Tv { get { return GetIcon (HardwareIconId.Tv); } }

		public static Image VideogameAsset { get { return GetIcon (HardwareIconId.VideogameAsset); } }

		public static Image Watch { get { return GetIcon (HardwareIconId.Watch); } }
	}
}
