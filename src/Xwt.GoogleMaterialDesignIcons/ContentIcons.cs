using System;
using Xwt.Drawing;

namespace Xwt.GoogleMaterialDesignIcons
{
	public class ContentIcons
	{
		static Image GetIcon (string id)
		{
			string resourceId = typeof(ContentIcons).Assembly.FullName.Split (',') [0] + ".Resources.Content." + id + "32px.png";
			return Image.FromResource (typeof(ContentIcons), resourceId);
		}

		public static Image Add { get { return GetIcon (ContentIconId.Add); } }

		public static Image AddBox { get { return GetIcon (ContentIconId.AddBox); } }

		public static Image AddCircle { get { return GetIcon (ContentIconId.AddCircle); } }

		public static Image AddCircleOutline { get { return GetIcon (ContentIconId.AddCircleOutline); } }

		public static Image Archive { get { return GetIcon (ContentIconId.Archive); } }

		public static Image Backspace { get { return GetIcon (ContentIconId.Backspace); } }

		public static Image Block { get { return GetIcon (ContentIconId.Block); } }

		public static Image Clear { get { return GetIcon (ContentIconId.Clear); } }

		public static Image ContentCopy { get { return GetIcon (ContentIconId.ContentCopy); } }

		public static Image ContentCut { get { return GetIcon (ContentIconId.ContentCut); } }

		public static Image ContentPaste { get { return GetIcon (ContentIconId.ContentPaste); } }

		public static Image Create { get { return GetIcon (ContentIconId.Create); } }

		public static Image DeleteSweep { get { return GetIcon (ContentIconId.DeleteSweep); } }

		public static Image Drafts { get { return GetIcon (ContentIconId.Drafts); } }

		public static Image FilterList { get { return GetIcon (ContentIconId.FilterList); } }

		public static Image Flag { get { return GetIcon (ContentIconId.Flag); } }

		public static Image Forward { get { return GetIcon (ContentIconId.Forward); } }

		public static Image Gesture { get { return GetIcon (ContentIconId.Gesture); } }

		public static Image Inbox { get { return GetIcon (ContentIconId.Inbox); } }

		public static Image Link { get { return GetIcon (ContentIconId.Link); } }

		public static Image LowPriority { get { return GetIcon (ContentIconId.LowPriority); } }

		public static Image Mail { get { return GetIcon (ContentIconId.Mail); } }

		public static Image Markunread { get { return GetIcon (ContentIconId.Markunread); } }

		public static Image MoveToInbox { get { return GetIcon (ContentIconId.MoveToInbox); } }

		public static Image NextWeek { get { return GetIcon (ContentIconId.NextWeek); } }

		public static Image Redo { get { return GetIcon (ContentIconId.Redo); } }

		public static Image Remove { get { return GetIcon (ContentIconId.Remove); } }

		public static Image RemoveCircle { get { return GetIcon (ContentIconId.RemoveCircle); } }

		public static Image RemoveCircleOutline { get { return GetIcon (ContentIconId.RemoveCircleOutline); } }

		public static Image Reply { get { return GetIcon (ContentIconId.Reply); } }

		public static Image ReplyAll { get { return GetIcon (ContentIconId.ReplyAll); } }

		public static Image Report { get { return GetIcon (ContentIconId.Report); } }

		public static Image Save { get { return GetIcon (ContentIconId.Save); } }

		public static Image SelectAll { get { return GetIcon (ContentIconId.SelectAll); } }

		public static Image Send { get { return GetIcon (ContentIconId.Send); } }

		public static Image Sort { get { return GetIcon (ContentIconId.Sort); } }

		public static Image TextFormat { get { return GetIcon (ContentIconId.TextFormat); } }

		public static Image Unarchive { get { return GetIcon (ContentIconId.Unarchive); } }

		public static Image Undo { get { return GetIcon (ContentIconId.Undo); } }

		public static Image Weekend { get { return GetIcon (ContentIconId.Weekend); } }
	}
}
