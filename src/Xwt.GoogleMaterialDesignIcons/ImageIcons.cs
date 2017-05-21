using System;
using Xwt.Drawing;

namespace Xwt.GoogleMaterialDesignIcons
{
	public class ImageIcons
	{
		static Image GetIcon (string id)
		{
			string resourceId = typeof(ImageIcons).Assembly.FullName.Split (',') [0] + ".Resources.Image." + id + "32px.png";
			return Image.FromResource (typeof(ImageIcons), resourceId);
		}

		public static Image AddAPhoto { get { return GetIcon (ImageIconId.AddAPhoto); } }

		public static Image AddToPhotos { get { return GetIcon (ImageIconId.AddToPhotos); } }

		public static Image Adjust { get { return GetIcon (ImageIconId.Adjust); } }

		public static Image Assistant { get { return GetIcon (ImageIconId.Assistant); } }

		public static Image AssistantPhoto { get { return GetIcon (ImageIconId.AssistantPhoto); } }

		public static Image Audiotrack { get { return GetIcon (ImageIconId.Audiotrack); } }

		public static Image BlurCircular { get { return GetIcon (ImageIconId.BlurCircular); } }

		public static Image BlurLinear { get { return GetIcon (ImageIconId.BlurLinear); } }

		public static Image BlurOff { get { return GetIcon (ImageIconId.BlurOff); } }

		public static Image BlurOn { get { return GetIcon (ImageIconId.BlurOn); } }

		public static Image Brightness1 { get { return GetIcon (ImageIconId.Brightness1); } }

		public static Image Brightness2 { get { return GetIcon (ImageIconId.Brightness2); } }

		public static Image Brightness3 { get { return GetIcon (ImageIconId.Brightness3); } }

		public static Image Brightness4 { get { return GetIcon (ImageIconId.Brightness4); } }

		public static Image Brightness5 { get { return GetIcon (ImageIconId.Brightness5); } }

		public static Image Brightness6 { get { return GetIcon (ImageIconId.Brightness6); } }

		public static Image Brightness7 { get { return GetIcon (ImageIconId.Brightness7); } }

		public static Image BrokenImage { get { return GetIcon (ImageIconId.BrokenImage); } }

		public static Image Brush { get { return GetIcon (ImageIconId.Brush); } }

		public static Image BurstMode { get { return GetIcon (ImageIconId.BurstMode); } }

		public static Image Camera { get { return GetIcon (ImageIconId.Camera); } }

		public static Image CameraAlt { get { return GetIcon (ImageIconId.CameraAlt); } }

		public static Image CameraFront { get { return GetIcon (ImageIconId.CameraFront); } }

		public static Image CameraRear { get { return GetIcon (ImageIconId.CameraRear); } }

		public static Image CameraRoll { get { return GetIcon (ImageIconId.CameraRoll); } }

		public static Image CenterFocusStrong { get { return GetIcon (ImageIconId.CenterFocusStrong); } }

		public static Image CenterFocusWeak { get { return GetIcon (ImageIconId.CenterFocusWeak); } }

		public static Image Collections { get { return GetIcon (ImageIconId.Collections); } }

		public static Image Colorize { get { return GetIcon (ImageIconId.Colorize); } }

		public static Image ColorLens { get { return GetIcon (ImageIconId.ColorLens); } }

		public static Image Compare { get { return GetIcon (ImageIconId.Compare); } }

		public static Image ControlPoint { get { return GetIcon (ImageIconId.ControlPoint); } }

		public static Image ControlPointDuplicate { get { return GetIcon (ImageIconId.ControlPointDuplicate); } }

		public static Image Crop169 { get { return GetIcon (ImageIconId.Crop169); } }

		public static Image Crop32 { get { return GetIcon (ImageIconId.Crop32); } }

		public static Image Crop { get { return GetIcon (ImageIconId.Crop); } }

		public static Image Crop54 { get { return GetIcon (ImageIconId.Crop54); } }

		public static Image Crop75 { get { return GetIcon (ImageIconId.Crop75); } }

		public static Image CropDin { get { return GetIcon (ImageIconId.CropDin); } }

		public static Image CropFree { get { return GetIcon (ImageIconId.CropFree); } }

		public static Image CropLandscape { get { return GetIcon (ImageIconId.CropLandscape); } }

		public static Image CropOriginal { get { return GetIcon (ImageIconId.CropOriginal); } }

		public static Image CropPortrait { get { return GetIcon (ImageIconId.CropPortrait); } }

		public static Image CropRotate { get { return GetIcon (ImageIconId.CropRotate); } }

		public static Image CropSquare { get { return GetIcon (ImageIconId.CropSquare); } }

		public static Image Dehaze { get { return GetIcon (ImageIconId.Dehaze); } }

		public static Image Details { get { return GetIcon (ImageIconId.Details); } }

		public static Image Edit { get { return GetIcon (ImageIconId.Edit); } }

		public static Image Exposure { get { return GetIcon (ImageIconId.Exposure); } }

		public static Image ExposureNeg1 { get { return GetIcon (ImageIconId.ExposureNeg1); } }

		public static Image ExposureNeg2 { get { return GetIcon (ImageIconId.ExposureNeg2); } }

		public static Image ExposurePlus1 { get { return GetIcon (ImageIconId.ExposurePlus1); } }

		public static Image ExposurePlus2 { get { return GetIcon (ImageIconId.ExposurePlus2); } }

		public static Image ExposureZero { get { return GetIcon (ImageIconId.ExposureZero); } }

		public static Image Filter1 { get { return GetIcon (ImageIconId.Filter1); } }

		public static Image Filter2 { get { return GetIcon (ImageIconId.Filter2); } }

		public static Image Filter3 { get { return GetIcon (ImageIconId.Filter3); } }

		public static Image Filter4 { get { return GetIcon (ImageIconId.Filter4); } }

		public static Image Filter { get { return GetIcon (ImageIconId.Filter); } }

		public static Image Filter5 { get { return GetIcon (ImageIconId.Filter5); } }

		public static Image Filter6 { get { return GetIcon (ImageIconId.Filter6); } }

		public static Image Filter7 { get { return GetIcon (ImageIconId.Filter7); } }

		public static Image Filter8 { get { return GetIcon (ImageIconId.Filter8); } }

		public static Image Filter9 { get { return GetIcon (ImageIconId.Filter9); } }

		public static Image Filter9Plus { get { return GetIcon (ImageIconId.Filter9Plus); } }

		public static Image FilterBAndW { get { return GetIcon (ImageIconId.FilterBAndW); } }

		public static Image FilterCenterFocus { get { return GetIcon (ImageIconId.FilterCenterFocus); } }

		public static Image FilterDrama { get { return GetIcon (ImageIconId.FilterDrama); } }

		public static Image FilterFrames { get { return GetIcon (ImageIconId.FilterFrames); } }

		public static Image FilterHdr { get { return GetIcon (ImageIconId.FilterHdr); } }

		public static Image FilterNone { get { return GetIcon (ImageIconId.FilterNone); } }

		public static Image FilterTiltShift { get { return GetIcon (ImageIconId.FilterTiltShift); } }

		public static Image FilterVintage { get { return GetIcon (ImageIconId.FilterVintage); } }

		public static Image Flare { get { return GetIcon (ImageIconId.Flare); } }

		public static Image FlashAuto { get { return GetIcon (ImageIconId.FlashAuto); } }

		public static Image FlashOff { get { return GetIcon (ImageIconId.FlashOff); } }

		public static Image FlashOn { get { return GetIcon (ImageIconId.FlashOn); } }

		public static Image Flip { get { return GetIcon (ImageIconId.Flip); } }

		public static Image Gradient { get { return GetIcon (ImageIconId.Gradient); } }

		public static Image Grain { get { return GetIcon (ImageIconId.Grain); } }

		public static Image GridOff { get { return GetIcon (ImageIconId.GridOff); } }

		public static Image GridOn { get { return GetIcon (ImageIconId.GridOn); } }

		public static Image HdrOff { get { return GetIcon (ImageIconId.HdrOff); } }

		public static Image HdrOn { get { return GetIcon (ImageIconId.HdrOn); } }

		public static Image HdrStrong { get { return GetIcon (ImageIconId.HdrStrong); } }

		public static Image HdrWeak { get { return GetIcon (ImageIconId.HdrWeak); } }

		public static Image Healing { get { return GetIcon (ImageIconId.Healing); } }

		public static Image Image { get { return GetIcon (ImageIconId.Image); } }

		public static Image ImageAspectRatio { get { return GetIcon (ImageIconId.ImageAspectRatio); } }

		public static Image Iso { get { return GetIcon (ImageIconId.Iso); } }

		public static Image Landscape { get { return GetIcon (ImageIconId.Landscape); } }

		public static Image LeakAdd { get { return GetIcon (ImageIconId.LeakAdd); } }

		public static Image LeakRemove { get { return GetIcon (ImageIconId.LeakRemove); } }

		public static Image Lens { get { return GetIcon (ImageIconId.Lens); } }

		public static Image LinkedCamera { get { return GetIcon (ImageIconId.LinkedCamera); } }

		public static Image Looks3 { get { return GetIcon (ImageIconId.Looks3); } }

		public static Image Looks4 { get { return GetIcon (ImageIconId.Looks4); } }

		public static Image Looks { get { return GetIcon (ImageIconId.Looks); } }

		public static Image Looks5 { get { return GetIcon (ImageIconId.Looks5); } }

		public static Image Looks6 { get { return GetIcon (ImageIconId.Looks6); } }

		public static Image LooksOne { get { return GetIcon (ImageIconId.LooksOne); } }

		public static Image LooksTwo { get { return GetIcon (ImageIconId.LooksTwo); } }

		public static Image Loupe { get { return GetIcon (ImageIconId.Loupe); } }

		public static Image MonochromePhotos { get { return GetIcon (ImageIconId.MonochromePhotos); } }

		public static Image MovieCreation { get { return GetIcon (ImageIconId.MovieCreation); } }

		public static Image MovieFilter { get { return GetIcon (ImageIconId.MovieFilter); } }

		public static Image MusicNote { get { return GetIcon (ImageIconId.MusicNote); } }

		public static Image Nature { get { return GetIcon (ImageIconId.Nature); } }

		public static Image NaturePeople { get { return GetIcon (ImageIconId.NaturePeople); } }

		public static Image NavigateBefore { get { return GetIcon (ImageIconId.NavigateBefore); } }

		public static Image NavigateNext { get { return GetIcon (ImageIconId.NavigateNext); } }

		public static Image Palette { get { return GetIcon (ImageIconId.Palette); } }

		public static Image Panorama { get { return GetIcon (ImageIconId.Panorama); } }

		public static Image PanoramaFishEye { get { return GetIcon (ImageIconId.PanoramaFishEye); } }

		public static Image PanoramaHorizontal { get { return GetIcon (ImageIconId.PanoramaHorizontal); } }

		public static Image PanoramaVertical { get { return GetIcon (ImageIconId.PanoramaVertical); } }

		public static Image PanoramaWideAngle { get { return GetIcon (ImageIconId.PanoramaWideAngle); } }

		public static Image Photo { get { return GetIcon (ImageIconId.Photo); } }

		public static Image PhotoAlbum { get { return GetIcon (ImageIconId.PhotoAlbum); } }

		public static Image PhotoCamera { get { return GetIcon (ImageIconId.PhotoCamera); } }

		public static Image PhotoFilter { get { return GetIcon (ImageIconId.PhotoFilter); } }

		public static Image PhotoLibrary { get { return GetIcon (ImageIconId.PhotoLibrary); } }

		public static Image PictureAsPdf { get { return GetIcon (ImageIconId.PictureAsPdf); } }

		public static Image Portrait { get { return GetIcon (ImageIconId.Portrait); } }

		public static Image RemoveRedEye { get { return GetIcon (ImageIconId.RemoveRedEye); } }

		public static Image Rotate90DegreesCcw { get { return GetIcon (ImageIconId.Rotate90DegreesCcw); } }

		public static Image RotateLeft { get { return GetIcon (ImageIconId.RotateLeft); } }

		public static Image RotateRight { get { return GetIcon (ImageIconId.RotateRight); } }

		public static Image Slideshow { get { return GetIcon (ImageIconId.Slideshow); } }

		public static Image Straighten { get { return GetIcon (ImageIconId.Straighten); } }

		public static Image Style { get { return GetIcon (ImageIconId.Style); } }

		public static Image SwitchCamera { get { return GetIcon (ImageIconId.SwitchCamera); } }

		public static Image SwitchVideo { get { return GetIcon (ImageIconId.SwitchVideo); } }

		public static Image TagFaces { get { return GetIcon (ImageIconId.TagFaces); } }

		public static Image Texture { get { return GetIcon (ImageIconId.Texture); } }

		public static Image Timelapse { get { return GetIcon (ImageIconId.Timelapse); } }

		public static Image Timer10 { get { return GetIcon (ImageIconId.Timer10); } }

		public static Image Timer3 { get { return GetIcon (ImageIconId.Timer3); } }

		public static Image Timer { get { return GetIcon (ImageIconId.Timer); } }

		public static Image TimerOff { get { return GetIcon (ImageIconId.TimerOff); } }

		public static Image Tonality { get { return GetIcon (ImageIconId.Tonality); } }

		public static Image Transform { get { return GetIcon (ImageIconId.Transform); } }

		public static Image Tune { get { return GetIcon (ImageIconId.Tune); } }

		public static Image ViewComfy { get { return GetIcon (ImageIconId.ViewComfy); } }

		public static Image ViewCompact { get { return GetIcon (ImageIconId.ViewCompact); } }

		public static Image WbAuto { get { return GetIcon (ImageIconId.WbAuto); } }

		public static Image WbCloudy { get { return GetIcon (ImageIconId.WbCloudy); } }

		public static Image WbIncandescent { get { return GetIcon (ImageIconId.WbIncandescent); } }

		public static Image WbIridescent { get { return GetIcon (ImageIconId.WbIridescent); } }

		public static Image WbSunny { get { return GetIcon (ImageIconId.WbSunny); } }
	}
}
