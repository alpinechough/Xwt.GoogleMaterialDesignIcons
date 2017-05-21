using System;
using Xwt.Drawing;

namespace Xwt.GoogleMaterialDesignIcons
{
	public class AvIcons
	{
		static Image GetIcon (string id)
		{
			string resourceId = typeof(AvIcons).Assembly.FullName.Split (',') [0] + ".Resources.Av." + id + "32px.png";
			return Image.FromResource (typeof(AvIcons), resourceId);
		}

		public static Image AddToQueue { get { return GetIcon (AvIconId.AddToQueue); } }

		public static Image Airplay { get { return GetIcon (AvIconId.Airplay); } }

		public static Image Album { get { return GetIcon (AvIconId.Album); } }

		public static Image ArtTrack { get { return GetIcon (AvIconId.ArtTrack); } }

		public static Image AvTimer { get { return GetIcon (AvIconId.AvTimer); } }

		public static Image BrandingWatermark { get { return GetIcon (AvIconId.BrandingWatermark); } }

		public static Image CallToAction { get { return GetIcon (AvIconId.CallToAction); } }

		public static Image ClosedCaption { get { return GetIcon (AvIconId.ClosedCaption); } }

		public static Image Equalizer { get { return GetIcon (AvIconId.Equalizer); } }

		public static Image Explicit { get { return GetIcon (AvIconId.Explicit); } }

		public static Image FastForward { get { return GetIcon (AvIconId.FastForward); } }

		public static Image FastRewind { get { return GetIcon (AvIconId.FastRewind); } }

		public static Image FeaturedPlayList { get { return GetIcon (AvIconId.FeaturedPlayList); } }

		public static Image FeaturedVideo { get { return GetIcon (AvIconId.FeaturedVideo); } }

		public static Image FiberDvr { get { return GetIcon (AvIconId.FiberDvr); } }

		public static Image FiberManualRecord { get { return GetIcon (AvIconId.FiberManualRecord); } }

		public static Image FiberNew { get { return GetIcon (AvIconId.FiberNew); } }

		public static Image FiberPin { get { return GetIcon (AvIconId.FiberPin); } }

		public static Image FiberSmartRecord { get { return GetIcon (AvIconId.FiberSmartRecord); } }

		public static Image Forward10 { get { return GetIcon (AvIconId.Forward10); } }

		public static Image Forward30 { get { return GetIcon (AvIconId.Forward30); } }

		public static Image Forward5 { get { return GetIcon (AvIconId.Forward5); } }

		public static Image Games { get { return GetIcon (AvIconId.Games); } }

		public static Image Hearing { get { return GetIcon (AvIconId.Hearing); } }

		public static Image HighQuality { get { return GetIcon (AvIconId.HighQuality); } }

		public static Image LibraryAdd { get { return GetIcon (AvIconId.LibraryAdd); } }

		public static Image LibraryBooks { get { return GetIcon (AvIconId.LibraryBooks); } }

		public static Image LibraryMusic { get { return GetIcon (AvIconId.LibraryMusic); } }

		public static Image Loop { get { return GetIcon (AvIconId.Loop); } }

		public static Image Mic { get { return GetIcon (AvIconId.Mic); } }

		public static Image MicNone { get { return GetIcon (AvIconId.MicNone); } }

		public static Image MicOff { get { return GetIcon (AvIconId.MicOff); } }

		public static Image Movie { get { return GetIcon (AvIconId.Movie); } }

		public static Image MusicVideo { get { return GetIcon (AvIconId.MusicVideo); } }

		public static Image NewReleases { get { return GetIcon (AvIconId.NewReleases); } }

		public static Image Note { get { return GetIcon (AvIconId.Note); } }

		public static Image NotInterested { get { return GetIcon (AvIconId.NotInterested); } }

		public static Image Pause { get { return GetIcon (AvIconId.Pause); } }

		public static Image PauseCircleFilled { get { return GetIcon (AvIconId.PauseCircleFilled); } }

		public static Image PauseCircleOutline { get { return GetIcon (AvIconId.PauseCircleOutline); } }

		public static Image PlayArrow { get { return GetIcon (AvIconId.PlayArrow); } }

		public static Image PlayCircleFilled { get { return GetIcon (AvIconId.PlayCircleFilled); } }

		public static Image PlayCircleFilledWhite { get { return GetIcon (AvIconId.PlayCircleFilledWhite); } }

		public static Image PlayCircleOutline { get { return GetIcon (AvIconId.PlayCircleOutline); } }

		public static Image PlaylistAdd { get { return GetIcon (AvIconId.PlaylistAdd); } }

		public static Image PlaylistAddCheck { get { return GetIcon (AvIconId.PlaylistAddCheck); } }

		public static Image PlaylistPlay { get { return GetIcon (AvIconId.PlaylistPlay); } }

		public static Image Queue { get { return GetIcon (AvIconId.Queue); } }

		public static Image QueueMusic { get { return GetIcon (AvIconId.QueueMusic); } }

		public static Image QueuePlayNext { get { return GetIcon (AvIconId.QueuePlayNext); } }

		public static Image Radio { get { return GetIcon (AvIconId.Radio); } }

		public static Image RecentActors { get { return GetIcon (AvIconId.RecentActors); } }

		public static Image RemoveFromQueue { get { return GetIcon (AvIconId.RemoveFromQueue); } }

		public static Image Repeat { get { return GetIcon (AvIconId.Repeat); } }

		public static Image RepeatOne { get { return GetIcon (AvIconId.RepeatOne); } }

		public static Image Replay10 { get { return GetIcon (AvIconId.Replay10); } }

		public static Image Replay30 { get { return GetIcon (AvIconId.Replay30); } }

		public static Image Replay { get { return GetIcon (AvIconId.Replay); } }

		public static Image Replay5 { get { return GetIcon (AvIconId.Replay5); } }

		public static Image Shuffle { get { return GetIcon (AvIconId.Shuffle); } }

		public static Image SkipNext { get { return GetIcon (AvIconId.SkipNext); } }

		public static Image SkipPrevious { get { return GetIcon (AvIconId.SkipPrevious); } }

		public static Image SlowMotionVideo { get { return GetIcon (AvIconId.SlowMotionVideo); } }

		public static Image Snooze { get { return GetIcon (AvIconId.Snooze); } }

		public static Image Stop { get { return GetIcon (AvIconId.Stop); } }

		public static Image Subscriptions { get { return GetIcon (AvIconId.Subscriptions); } }

		public static Image Subtitles { get { return GetIcon (AvIconId.Subtitles); } }

		public static Image SurroundSound { get { return GetIcon (AvIconId.SurroundSound); } }

		public static Image VideoCall { get { return GetIcon (AvIconId.VideoCall); } }

		public static Image Videocam { get { return GetIcon (AvIconId.Videocam); } }

		public static Image VideocamOff { get { return GetIcon (AvIconId.VideocamOff); } }

		public static Image VideoLabel { get { return GetIcon (AvIconId.VideoLabel); } }

		public static Image VideoLibrary { get { return GetIcon (AvIconId.VideoLibrary); } }

		public static Image VolumeDown { get { return GetIcon (AvIconId.VolumeDown); } }

		public static Image VolumeMute { get { return GetIcon (AvIconId.VolumeMute); } }

		public static Image VolumeOff { get { return GetIcon (AvIconId.VolumeOff); } }

		public static Image VolumeUp { get { return GetIcon (AvIconId.VolumeUp); } }

		public static Image Web { get { return GetIcon (AvIconId.Web); } }

		public static Image WebAsset { get { return GetIcon (AvIconId.WebAsset); } }
	}
}
