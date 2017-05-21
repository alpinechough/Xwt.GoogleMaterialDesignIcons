using System;
using Xwt.Drawing;

namespace Xwt.GoogleMaterialDesignIcons
{
	public class FileIcons
	{
		static Image GetIcon (string id)
		{
			string resourceId = typeof(FileIcons).Assembly.FullName.Split (',') [0] + ".Resources.File." + id + "32px.png";
			return Image.FromResource (typeof(FileIcons), resourceId);
		}

		public static Image Attachment { get { return GetIcon (FileIconId.Attachment); } }

		public static Image Cloud { get { return GetIcon (FileIconId.Cloud); } }

		public static Image CloudCircle { get { return GetIcon (FileIconId.CloudCircle); } }

		public static Image CloudDone { get { return GetIcon (FileIconId.CloudDone); } }

		public static Image CloudDownload { get { return GetIcon (FileIconId.CloudDownload); } }

		public static Image CloudOff { get { return GetIcon (FileIconId.CloudOff); } }

		public static Image CloudQueue { get { return GetIcon (FileIconId.CloudQueue); } }

		public static Image CloudUpload { get { return GetIcon (FileIconId.CloudUpload); } }

		public static Image CreateNewFolder { get { return GetIcon (FileIconId.CreateNewFolder); } }

		public static Image FileDownload { get { return GetIcon (FileIconId.FileDownload); } }

		public static Image FileUpload { get { return GetIcon (FileIconId.FileUpload); } }

		public static Image Folder { get { return GetIcon (FileIconId.Folder); } }

		public static Image FolderOpen { get { return GetIcon (FileIconId.FolderOpen); } }

		public static Image FolderShared { get { return GetIcon (FileIconId.FolderShared); } }
	}
}
