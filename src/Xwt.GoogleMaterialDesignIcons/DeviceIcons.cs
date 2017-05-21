using System;
using Xwt.Drawing;

namespace Xwt.GoogleMaterialDesignIcons
{
	public class DeviceIcons
	{
		static Image GetIcon (string id)
		{
			string resourceId = typeof(DeviceIcons).Assembly.FullName.Split (',') [0] + ".Resources.Device." + id + "32px.png";
			return Image.FromResource (typeof(DeviceIcons), resourceId);
		}

		public static Image AccessAlarm { get { return GetIcon (DeviceIconId.AccessAlarm); } }

		public static Image AccessAlarms { get { return GetIcon (DeviceIconId.AccessAlarms); } }

		public static Image AccessTime { get { return GetIcon (DeviceIconId.AccessTime); } }

		public static Image AddAlarm { get { return GetIcon (DeviceIconId.AddAlarm); } }

		public static Image AirplanemodeActive { get { return GetIcon (DeviceIconId.AirplanemodeActive); } }

		public static Image AirplanemodeInactive { get { return GetIcon (DeviceIconId.AirplanemodeInactive); } }

		public static Image Battery20 { get { return GetIcon (DeviceIconId.Battery20); } }

		public static Image Battery30 { get { return GetIcon (DeviceIconId.Battery30); } }

		public static Image Battery50 { get { return GetIcon (DeviceIconId.Battery50); } }

		public static Image Battery60 { get { return GetIcon (DeviceIconId.Battery60); } }

		public static Image Battery80 { get { return GetIcon (DeviceIconId.Battery80); } }

		public static Image Battery90 { get { return GetIcon (DeviceIconId.Battery90); } }

		public static Image BatteryAlert { get { return GetIcon (DeviceIconId.BatteryAlert); } }

		public static Image BatteryCharging20 { get { return GetIcon (DeviceIconId.BatteryCharging20); } }

		public static Image BatteryCharging30 { get { return GetIcon (DeviceIconId.BatteryCharging30); } }

		public static Image BatteryCharging50 { get { return GetIcon (DeviceIconId.BatteryCharging50); } }

		public static Image BatteryCharging60 { get { return GetIcon (DeviceIconId.BatteryCharging60); } }

		public static Image BatteryCharging80 { get { return GetIcon (DeviceIconId.BatteryCharging80); } }

		public static Image BatteryCharging90 { get { return GetIcon (DeviceIconId.BatteryCharging90); } }

		public static Image BatteryChargingFull { get { return GetIcon (DeviceIconId.BatteryChargingFull); } }

		public static Image BatteryFull { get { return GetIcon (DeviceIconId.BatteryFull); } }

		public static Image BatteryStd { get { return GetIcon (DeviceIconId.BatteryStd); } }

		public static Image BatteryUnknown { get { return GetIcon (DeviceIconId.BatteryUnknown); } }

		public static Image Bluetooth { get { return GetIcon (DeviceIconId.Bluetooth); } }

		public static Image BluetoothConnected { get { return GetIcon (DeviceIconId.BluetoothConnected); } }

		public static Image BluetoothDisabled { get { return GetIcon (DeviceIconId.BluetoothDisabled); } }

		public static Image BluetoothSearching { get { return GetIcon (DeviceIconId.BluetoothSearching); } }

		public static Image BrightnessAuto { get { return GetIcon (DeviceIconId.BrightnessAuto); } }

		public static Image BrightnessHigh { get { return GetIcon (DeviceIconId.BrightnessHigh); } }

		public static Image BrightnessLow { get { return GetIcon (DeviceIconId.BrightnessLow); } }

		public static Image BrightnessMedium { get { return GetIcon (DeviceIconId.BrightnessMedium); } }

		public static Image DataUsage { get { return GetIcon (DeviceIconId.DataUsage); } }

		public static Image DeveloperMode { get { return GetIcon (DeviceIconId.DeveloperMode); } }

		public static Image Devices { get { return GetIcon (DeviceIconId.Devices); } }

		public static Image Dvr { get { return GetIcon (DeviceIconId.Dvr); } }

		public static Image GpsFixed { get { return GetIcon (DeviceIconId.GpsFixed); } }

		public static Image GpsNotFixed { get { return GetIcon (DeviceIconId.GpsNotFixed); } }

		public static Image GpsOff { get { return GetIcon (DeviceIconId.GpsOff); } }

		public static Image GraphicEq { get { return GetIcon (DeviceIconId.GraphicEq); } }

		public static Image LocationDisabled { get { return GetIcon (DeviceIconId.LocationDisabled); } }

		public static Image LocationSearching { get { return GetIcon (DeviceIconId.LocationSearching); } }

		public static Image NetworkCell { get { return GetIcon (DeviceIconId.NetworkCell); } }

		public static Image NetworkWifi { get { return GetIcon (DeviceIconId.NetworkWifi); } }

		public static Image Nfc { get { return GetIcon (DeviceIconId.Nfc); } }

		public static Image ScreenLockLandscape { get { return GetIcon (DeviceIconId.ScreenLockLandscape); } }

		public static Image ScreenLockPortrait { get { return GetIcon (DeviceIconId.ScreenLockPortrait); } }

		public static Image ScreenLockRotation { get { return GetIcon (DeviceIconId.ScreenLockRotation); } }

		public static Image ScreenRotation { get { return GetIcon (DeviceIconId.ScreenRotation); } }

		public static Image SdStorage { get { return GetIcon (DeviceIconId.SdStorage); } }

		public static Image SettingsSystemDaydream { get { return GetIcon (DeviceIconId.SettingsSystemDaydream); } }

		public static Image SignalCellular0Bar { get { return GetIcon (DeviceIconId.SignalCellular0Bar); } }

		public static Image SignalCellular1Bar { get { return GetIcon (DeviceIconId.SignalCellular1Bar); } }

		public static Image SignalCellular2Bar { get { return GetIcon (DeviceIconId.SignalCellular2Bar); } }

		public static Image SignalCellular3Bar { get { return GetIcon (DeviceIconId.SignalCellular3Bar); } }

		public static Image SignalCellular4Bar { get { return GetIcon (DeviceIconId.SignalCellular4Bar); } }

		public static Image SignalCellularConnectedNoInternet0Bar { get { return GetIcon (DeviceIconId.SignalCellularConnectedNoInternet0Bar); } }

		public static Image SignalCellularConnectedNoInternet1Bar { get { return GetIcon (DeviceIconId.SignalCellularConnectedNoInternet1Bar); } }

		public static Image SignalCellularConnectedNoInternet2Bar { get { return GetIcon (DeviceIconId.SignalCellularConnectedNoInternet2Bar); } }

		public static Image SignalCellularConnectedNoInternet3Bar { get { return GetIcon (DeviceIconId.SignalCellularConnectedNoInternet3Bar); } }

		public static Image SignalCellularConnectedNoInternet4Bar { get { return GetIcon (DeviceIconId.SignalCellularConnectedNoInternet4Bar); } }

		public static Image SignalCellularNoSim { get { return GetIcon (DeviceIconId.SignalCellularNoSim); } }

		public static Image SignalCellularNull { get { return GetIcon (DeviceIconId.SignalCellularNull); } }

		public static Image SignalCellularOff { get { return GetIcon (DeviceIconId.SignalCellularOff); } }

		public static Image SignalWifi0Bar { get { return GetIcon (DeviceIconId.SignalWifi0Bar); } }

		public static Image SignalWifi1Bar { get { return GetIcon (DeviceIconId.SignalWifi1Bar); } }

		public static Image SignalWifi1BarLock { get { return GetIcon (DeviceIconId.SignalWifi1BarLock); } }

		public static Image SignalWifi2Bar { get { return GetIcon (DeviceIconId.SignalWifi2Bar); } }

		public static Image SignalWifi2BarLock { get { return GetIcon (DeviceIconId.SignalWifi2BarLock); } }

		public static Image SignalWifi3Bar { get { return GetIcon (DeviceIconId.SignalWifi3Bar); } }

		public static Image SignalWifi3BarLock { get { return GetIcon (DeviceIconId.SignalWifi3BarLock); } }

		public static Image SignalWifi4Bar { get { return GetIcon (DeviceIconId.SignalWifi4Bar); } }

		public static Image SignalWifi4BarLock { get { return GetIcon (DeviceIconId.SignalWifi4BarLock); } }

		public static Image SignalWifiOff { get { return GetIcon (DeviceIconId.SignalWifiOff); } }

		public static Image Storage { get { return GetIcon (DeviceIconId.Storage); } }

		public static Image Usb { get { return GetIcon (DeviceIconId.Usb); } }

		public static Image Wallpaper { get { return GetIcon (DeviceIconId.Wallpaper); } }

		public static Image Widgets { get { return GetIcon (DeviceIconId.Widgets); } }

		public static Image WifiLock { get { return GetIcon (DeviceIconId.WifiLock); } }

		public static Image WifiTethering { get { return GetIcon (DeviceIconId.WifiTethering); } }
	}
}
