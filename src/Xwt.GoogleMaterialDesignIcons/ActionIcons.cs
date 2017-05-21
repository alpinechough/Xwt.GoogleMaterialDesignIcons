using System;
using Xwt.Drawing;

namespace Xwt.GoogleMaterialDesignIcons
{
	public class ActionIcons
	{
		static Image GetIcon (string id)
		{
			string resourceId = typeof(ActionIcons).Assembly.FullName.Split (',') [0] + ".Resources.Action." + id + "32px.png";
			return Image.FromResource (typeof(ActionIcons), resourceId);
		}

		public static Image Rotation3d { get { return GetIcon (ActionIconId.Rotation3d); } }

		public static Image Accessibility { get { return GetIcon (ActionIconId.Accessibility); } }

		public static Image Accessible { get { return GetIcon (ActionIconId.Accessible); } }

		public static Image AccountBalance { get { return GetIcon (ActionIconId.AccountBalance); } }

		public static Image AccountBalanceWallet { get { return GetIcon (ActionIconId.AccountBalanceWallet); } }

		public static Image AccountBox { get { return GetIcon (ActionIconId.AccountBox); } }

		public static Image AccountCircle { get { return GetIcon (ActionIconId.AccountCircle); } }

		public static Image AddShoppingCart { get { return GetIcon (ActionIconId.AddShoppingCart); } }

		public static Image Alarm { get { return GetIcon (ActionIconId.Alarm); } }

		public static Image AlarmAdd { get { return GetIcon (ActionIconId.AlarmAdd); } }

		public static Image AlarmOff { get { return GetIcon (ActionIconId.AlarmOff); } }

		public static Image AlarmOn { get { return GetIcon (ActionIconId.AlarmOn); } }

		public static Image AllOut { get { return GetIcon (ActionIconId.AllOut); } }

		public static Image Android { get { return GetIcon (ActionIconId.Android); } }

		public static Image Announcement { get { return GetIcon (ActionIconId.Announcement); } }

		public static Image AspectRatio { get { return GetIcon (ActionIconId.AspectRatio); } }

		public static Image Assessment { get { return GetIcon (ActionIconId.Assessment); } }

		public static Image Assignment { get { return GetIcon (ActionIconId.Assignment); } }

		public static Image AssignmentInd { get { return GetIcon (ActionIconId.AssignmentInd); } }

		public static Image AssignmentLate { get { return GetIcon (ActionIconId.AssignmentLate); } }

		public static Image AssignmentReturn { get { return GetIcon (ActionIconId.AssignmentReturn); } }

		public static Image AssignmentReturned { get { return GetIcon (ActionIconId.AssignmentReturned); } }

		public static Image AssignmentTurnedIn { get { return GetIcon (ActionIconId.AssignmentTurnedIn); } }

		public static Image Autorenew { get { return GetIcon (ActionIconId.Autorenew); } }

		public static Image Backup { get { return GetIcon (ActionIconId.Backup); } }

		public static Image Book { get { return GetIcon (ActionIconId.Book); } }

		public static Image Bookmark { get { return GetIcon (ActionIconId.Bookmark); } }

		public static Image BookmarkBorder { get { return GetIcon (ActionIconId.BookmarkBorder); } }

		public static Image BugReport { get { return GetIcon (ActionIconId.BugReport); } }

		public static Image Build { get { return GetIcon (ActionIconId.Build); } }

		public static Image Cached { get { return GetIcon (ActionIconId.Cached); } }

		public static Image CardGiftcard { get { return GetIcon (ActionIconId.CardGiftcard); } }

		public static Image CardMembership { get { return GetIcon (ActionIconId.CardMembership); } }

		public static Image CardTravel { get { return GetIcon (ActionIconId.CardTravel); } }

		public static Image ChangeHistory { get { return GetIcon (ActionIconId.ChangeHistory); } }

		public static Image CheckCircle { get { return GetIcon (ActionIconId.CheckCircle); } }

		public static Image ChromeReaderMode { get { return GetIcon (ActionIconId.ChromeReaderMode); } }

		public static Image Class { get { return GetIcon (ActionIconId.Class); } }

		public static Image Code { get { return GetIcon (ActionIconId.Code); } }

		public static Image CompareArrows { get { return GetIcon (ActionIconId.CompareArrows); } }

		public static Image Copyright { get { return GetIcon (ActionIconId.Copyright); } }

		public static Image CreditCard { get { return GetIcon (ActionIconId.CreditCard); } }

		public static Image Dashboard { get { return GetIcon (ActionIconId.Dashboard); } }

		public static Image DateRange { get { return GetIcon (ActionIconId.DateRange); } }

		public static Image Delete { get { return GetIcon (ActionIconId.Delete); } }

		public static Image DeleteForever { get { return GetIcon (ActionIconId.DeleteForever); } }

		public static Image Description { get { return GetIcon (ActionIconId.Description); } }

		public static Image Dns { get { return GetIcon (ActionIconId.Dns); } }

		public static Image Done { get { return GetIcon (ActionIconId.Done); } }

		public static Image DoneAll { get { return GetIcon (ActionIconId.DoneAll); } }

		public static Image DonutLarge { get { return GetIcon (ActionIconId.DonutLarge); } }

		public static Image DonutSmall { get { return GetIcon (ActionIconId.DonutSmall); } }

		public static Image EuroSymbol { get { return GetIcon (ActionIconId.EuroSymbol); } }

		public static Image Event { get { return GetIcon (ActionIconId.Event); } }

		public static Image EventSeat { get { return GetIcon (ActionIconId.EventSeat); } }

		public static Image ExitToApp { get { return GetIcon (ActionIconId.ExitToApp); } }

		public static Image Explore { get { return GetIcon (ActionIconId.Explore); } }

		public static Image Extension { get { return GetIcon (ActionIconId.Extension); } }

		public static Image Face { get { return GetIcon (ActionIconId.Face); } }

		public static Image Favorite { get { return GetIcon (ActionIconId.Favorite); } }

		public static Image FavoriteBorder { get { return GetIcon (ActionIconId.FavoriteBorder); } }

		public static Image Feedback { get { return GetIcon (ActionIconId.Feedback); } }

		public static Image FindInPage { get { return GetIcon (ActionIconId.FindInPage); } }

		public static Image FindReplace { get { return GetIcon (ActionIconId.FindReplace); } }

		public static Image Fingerprint { get { return GetIcon (ActionIconId.Fingerprint); } }

		public static Image FlightLand { get { return GetIcon (ActionIconId.FlightLand); } }

		public static Image FlightTakeoff { get { return GetIcon (ActionIconId.FlightTakeoff); } }

		public static Image FlipToBack { get { return GetIcon (ActionIconId.FlipToBack); } }

		public static Image FlipToFront { get { return GetIcon (ActionIconId.FlipToFront); } }

		public static Image Gavel { get { return GetIcon (ActionIconId.Gavel); } }

		public static Image GetApp { get { return GetIcon (ActionIconId.GetApp); } }

		public static Image Grade { get { return GetIcon (ActionIconId.Grade); } }

		public static Image GroupWork { get { return GetIcon (ActionIconId.GroupWork); } }

		public static Image GTranslate { get { return GetIcon (ActionIconId.GTranslate); } }

		public static Image Help { get { return GetIcon (ActionIconId.Help); } }

		public static Image HighlightOff { get { return GetIcon (ActionIconId.HighlightOff); } }

		public static Image History { get { return GetIcon (ActionIconId.History); } }

		public static Image Home { get { return GetIcon (ActionIconId.Home); } }

		public static Image HourglassEmpty { get { return GetIcon (ActionIconId.HourglassEmpty); } }

		public static Image HourglassFull { get { return GetIcon (ActionIconId.HourglassFull); } }

		public static Image Http { get { return GetIcon (ActionIconId.Http); } }

		public static Image Https { get { return GetIcon (ActionIconId.Https); } }

		public static Image ImportantDevices { get { return GetIcon (ActionIconId.ImportantDevices); } }

		public static Image Info { get { return GetIcon (ActionIconId.Info); } }

		public static Image InfoOutline { get { return GetIcon (ActionIconId.InfoOutline); } }

		public static Image Input { get { return GetIcon (ActionIconId.Input); } }

		public static Image InvertColors { get { return GetIcon (ActionIconId.InvertColors); } }

		public static Image Label { get { return GetIcon (ActionIconId.Label); } }

		public static Image LabelOutline { get { return GetIcon (ActionIconId.LabelOutline); } }

		public static Image Language { get { return GetIcon (ActionIconId.Language); } }

		public static Image Launch { get { return GetIcon (ActionIconId.Launch); } }

		public static Image LightbulbOutline { get { return GetIcon (ActionIconId.LightbulbOutline); } }

		public static Image LineStyle { get { return GetIcon (ActionIconId.LineStyle); } }

		public static Image LineWeight { get { return GetIcon (ActionIconId.LineWeight); } }

		public static Image List { get { return GetIcon (ActionIconId.List); } }

		public static Image Lock { get { return GetIcon (ActionIconId.Lock); } }

		public static Image LockOpen { get { return GetIcon (ActionIconId.LockOpen); } }

		public static Image LockOutline { get { return GetIcon (ActionIconId.LockOutline); } }

		public static Image Loyalty { get { return GetIcon (ActionIconId.Loyalty); } }

		public static Image MarkunreadMailbox { get { return GetIcon (ActionIconId.MarkunreadMailbox); } }

		public static Image Motorcycle { get { return GetIcon (ActionIconId.Motorcycle); } }

		public static Image NoteAdd { get { return GetIcon (ActionIconId.NoteAdd); } }

		public static Image Opacity { get { return GetIcon (ActionIconId.Opacity); } }

		public static Image OpenInBrowser { get { return GetIcon (ActionIconId.OpenInBrowser); } }

		public static Image OpenInNew { get { return GetIcon (ActionIconId.OpenInNew); } }

		public static Image OpenWith { get { return GetIcon (ActionIconId.OpenWith); } }

		public static Image Pageview { get { return GetIcon (ActionIconId.Pageview); } }

		public static Image PanTool { get { return GetIcon (ActionIconId.PanTool); } }

		public static Image Payment { get { return GetIcon (ActionIconId.Payment); } }

		public static Image PermCameraMic { get { return GetIcon (ActionIconId.PermCameraMic); } }

		public static Image PermContactCalendar { get { return GetIcon (ActionIconId.PermContactCalendar); } }

		public static Image PermDataSetting { get { return GetIcon (ActionIconId.PermDataSetting); } }

		public static Image PermDeviceInformation { get { return GetIcon (ActionIconId.PermDeviceInformation); } }

		public static Image PermIdentity { get { return GetIcon (ActionIconId.PermIdentity); } }

		public static Image PermMedia { get { return GetIcon (ActionIconId.PermMedia); } }

		public static Image PermPhoneMsg { get { return GetIcon (ActionIconId.PermPhoneMsg); } }

		public static Image PermScanWifi { get { return GetIcon (ActionIconId.PermScanWifi); } }

		public static Image Pets { get { return GetIcon (ActionIconId.Pets); } }

		public static Image PictureInPicture { get { return GetIcon (ActionIconId.PictureInPicture); } }

		public static Image PictureInPictureAlt { get { return GetIcon (ActionIconId.PictureInPictureAlt); } }

		public static Image PlayForWork { get { return GetIcon (ActionIconId.PlayForWork); } }

		public static Image Polymer { get { return GetIcon (ActionIconId.Polymer); } }

		public static Image PowerSettingsNew { get { return GetIcon (ActionIconId.PowerSettingsNew); } }

		public static Image PregnantWoman { get { return GetIcon (ActionIconId.PregnantWoman); } }

		public static Image Print { get { return GetIcon (ActionIconId.Print); } }

		public static Image QueryBuilder { get { return GetIcon (ActionIconId.QueryBuilder); } }

		public static Image QuestionAnswer { get { return GetIcon (ActionIconId.QuestionAnswer); } }

		public static Image Receipt { get { return GetIcon (ActionIconId.Receipt); } }

		public static Image RecordVoiceOver { get { return GetIcon (ActionIconId.RecordVoiceOver); } }

		public static Image Redeem { get { return GetIcon (ActionIconId.Redeem); } }

		public static Image RemoveShoppingCart { get { return GetIcon (ActionIconId.RemoveShoppingCart); } }

		public static Image ReportProblem { get { return GetIcon (ActionIconId.ReportProblem); } }

		public static Image Restore { get { return GetIcon (ActionIconId.Restore); } }

		public static Image RestorePage { get { return GetIcon (ActionIconId.RestorePage); } }

		public static Image Room { get { return GetIcon (ActionIconId.Room); } }

		public static Image RoundedCorner { get { return GetIcon (ActionIconId.RoundedCorner); } }

		public static Image Rowing { get { return GetIcon (ActionIconId.Rowing); } }

		public static Image Schedule { get { return GetIcon (ActionIconId.Schedule); } }

		public static Image Search { get { return GetIcon (ActionIconId.Search); } }

		public static Image Settings { get { return GetIcon (ActionIconId.Settings); } }

		public static Image SettingsApplications { get { return GetIcon (ActionIconId.SettingsApplications); } }

		public static Image SettingsBackupRestore { get { return GetIcon (ActionIconId.SettingsBackupRestore); } }

		public static Image SettingsBluetooth { get { return GetIcon (ActionIconId.SettingsBluetooth); } }

		public static Image SettingsBrightness { get { return GetIcon (ActionIconId.SettingsBrightness); } }

		public static Image SettingsCell { get { return GetIcon (ActionIconId.SettingsCell); } }

		public static Image SettingsEthernet { get { return GetIcon (ActionIconId.SettingsEthernet); } }

		public static Image SettingsInputAntenna { get { return GetIcon (ActionIconId.SettingsInputAntenna); } }

		public static Image SettingsInputComponent { get { return GetIcon (ActionIconId.SettingsInputComponent); } }

		public static Image SettingsInputComposite { get { return GetIcon (ActionIconId.SettingsInputComposite); } }

		public static Image SettingsInputHdmi { get { return GetIcon (ActionIconId.SettingsInputHdmi); } }

		public static Image SettingsInputSvideo { get { return GetIcon (ActionIconId.SettingsInputSvideo); } }

		public static Image SettingsOverscan { get { return GetIcon (ActionIconId.SettingsOverscan); } }

		public static Image SettingsPhone { get { return GetIcon (ActionIconId.SettingsPhone); } }

		public static Image SettingsPower { get { return GetIcon (ActionIconId.SettingsPower); } }

		public static Image SettingsRemote { get { return GetIcon (ActionIconId.SettingsRemote); } }

		public static Image SettingsVoice { get { return GetIcon (ActionIconId.SettingsVoice); } }

		public static Image Shop { get { return GetIcon (ActionIconId.Shop); } }

		public static Image ShoppingBasket { get { return GetIcon (ActionIconId.ShoppingBasket); } }

		public static Image ShoppingCart { get { return GetIcon (ActionIconId.ShoppingCart); } }

		public static Image ShopTwo { get { return GetIcon (ActionIconId.ShopTwo); } }

		public static Image SpeakerNotes { get { return GetIcon (ActionIconId.SpeakerNotes); } }

		public static Image SpeakerNotesOff { get { return GetIcon (ActionIconId.SpeakerNotesOff); } }

		public static Image Spellcheck { get { return GetIcon (ActionIconId.Spellcheck); } }

		public static Image Stars { get { return GetIcon (ActionIconId.Stars); } }

		public static Image Store { get { return GetIcon (ActionIconId.Store); } }

		public static Image Subject { get { return GetIcon (ActionIconId.Subject); } }

		public static Image SupervisorAccount { get { return GetIcon (ActionIconId.SupervisorAccount); } }

		public static Image SwapHoriz { get { return GetIcon (ActionIconId.SwapHoriz); } }

		public static Image SwapVert { get { return GetIcon (ActionIconId.SwapVert); } }

		public static Image SwapVerticalCircle { get { return GetIcon (ActionIconId.SwapVerticalCircle); } }

		public static Image SystemUpdateAlt { get { return GetIcon (ActionIconId.SystemUpdateAlt); } }

		public static Image Tab { get { return GetIcon (ActionIconId.Tab); } }

		public static Image TabUnselected { get { return GetIcon (ActionIconId.TabUnselected); } }

		public static Image Theaters { get { return GetIcon (ActionIconId.Theaters); } }

		public static Image ThumbDown { get { return GetIcon (ActionIconId.ThumbDown); } }

		public static Image ThumbsUpDown { get { return GetIcon (ActionIconId.ThumbsUpDown); } }

		public static Image ThumbUp { get { return GetIcon (ActionIconId.ThumbUp); } }

		public static Image Timeline { get { return GetIcon (ActionIconId.Timeline); } }

		public static Image Toc { get { return GetIcon (ActionIconId.Toc); } }

		public static Image Today { get { return GetIcon (ActionIconId.Today); } }

		public static Image Toll { get { return GetIcon (ActionIconId.Toll); } }

		public static Image TouchApp { get { return GetIcon (ActionIconId.TouchApp); } }

		public static Image TrackChanges { get { return GetIcon (ActionIconId.TrackChanges); } }

		public static Image Translate { get { return GetIcon (ActionIconId.Translate); } }

		public static Image TrendingDown { get { return GetIcon (ActionIconId.TrendingDown); } }

		public static Image TrendingFlat { get { return GetIcon (ActionIconId.TrendingFlat); } }

		public static Image TrendingUp { get { return GetIcon (ActionIconId.TrendingUp); } }

		public static Image TurnedIn { get { return GetIcon (ActionIconId.TurnedIn); } }

		public static Image TurnedInNot { get { return GetIcon (ActionIconId.TurnedInNot); } }

		public static Image Update { get { return GetIcon (ActionIconId.Update); } }

		public static Image VerifiedUser { get { return GetIcon (ActionIconId.VerifiedUser); } }

		public static Image ViewAgenda { get { return GetIcon (ActionIconId.ViewAgenda); } }

		public static Image ViewArray { get { return GetIcon (ActionIconId.ViewArray); } }

		public static Image ViewCarousel { get { return GetIcon (ActionIconId.ViewCarousel); } }

		public static Image ViewColumn { get { return GetIcon (ActionIconId.ViewColumn); } }

		public static Image ViewDay { get { return GetIcon (ActionIconId.ViewDay); } }

		public static Image ViewHeadline { get { return GetIcon (ActionIconId.ViewHeadline); } }

		public static Image ViewList { get { return GetIcon (ActionIconId.ViewList); } }

		public static Image ViewModule { get { return GetIcon (ActionIconId.ViewModule); } }

		public static Image ViewQuilt { get { return GetIcon (ActionIconId.ViewQuilt); } }

		public static Image ViewStream { get { return GetIcon (ActionIconId.ViewStream); } }

		public static Image ViewWeek { get { return GetIcon (ActionIconId.ViewWeek); } }

		public static Image Visibility { get { return GetIcon (ActionIconId.Visibility); } }

		public static Image VisibilityOff { get { return GetIcon (ActionIconId.VisibilityOff); } }

		public static Image WatchLater { get { return GetIcon (ActionIconId.WatchLater); } }

		public static Image Work { get { return GetIcon (ActionIconId.Work); } }

		public static Image YoutubeSearchedFor { get { return GetIcon (ActionIconId.YoutubeSearchedFor); } }
	}
}
