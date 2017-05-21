using System;
using Xwt.Drawing;

namespace Xwt.GoogleMaterialDesignIcons
{
	public class EditorIcons
	{
		static Image GetIcon (string id)
		{
			string resourceId = typeof(EditorIcons).Assembly.FullName.Split (',') [0] + ".Resources.Editor." + id + "32px.png";
			return Image.FromResource (typeof(EditorIcons), resourceId);
		}

		public static Image AttachFile { get { return GetIcon (EditorIconId.AttachFile); } }

		public static Image AttachMoney { get { return GetIcon (EditorIconId.AttachMoney); } }

		public static Image BorderAll { get { return GetIcon (EditorIconId.BorderAll); } }

		public static Image BorderBottom { get { return GetIcon (EditorIconId.BorderBottom); } }

		public static Image BorderClear { get { return GetIcon (EditorIconId.BorderClear); } }

		public static Image BorderColor { get { return GetIcon (EditorIconId.BorderColor); } }

		public static Image BorderHorizontal { get { return GetIcon (EditorIconId.BorderHorizontal); } }

		public static Image BorderInner { get { return GetIcon (EditorIconId.BorderInner); } }

		public static Image BorderLeft { get { return GetIcon (EditorIconId.BorderLeft); } }

		public static Image BorderOuter { get { return GetIcon (EditorIconId.BorderOuter); } }

		public static Image BorderRight { get { return GetIcon (EditorIconId.BorderRight); } }

		public static Image BorderStyle { get { return GetIcon (EditorIconId.BorderStyle); } }

		public static Image BorderTop { get { return GetIcon (EditorIconId.BorderTop); } }

		public static Image BorderVertical { get { return GetIcon (EditorIconId.BorderVertical); } }

		public static Image BubbleChart { get { return GetIcon (EditorIconId.BubbleChart); } }

		public static Image DragHandle { get { return GetIcon (EditorIconId.DragHandle); } }

		public static Image FormatAlignCenter { get { return GetIcon (EditorIconId.FormatAlignCenter); } }

		public static Image FormatAlignJustify { get { return GetIcon (EditorIconId.FormatAlignJustify); } }

		public static Image FormatAlignLeft { get { return GetIcon (EditorIconId.FormatAlignLeft); } }

		public static Image FormatAlignRight { get { return GetIcon (EditorIconId.FormatAlignRight); } }

		public static Image FormatBold { get { return GetIcon (EditorIconId.FormatBold); } }

		public static Image FormatClear { get { return GetIcon (EditorIconId.FormatClear); } }

		public static Image FormatColorFill { get { return GetIcon (EditorIconId.FormatColorFill); } }

		public static Image FormatColorReset { get { return GetIcon (EditorIconId.FormatColorReset); } }

		public static Image FormatColorText { get { return GetIcon (EditorIconId.FormatColorText); } }

		public static Image FormatIndentDecrease { get { return GetIcon (EditorIconId.FormatIndentDecrease); } }

		public static Image FormatIndentIncrease { get { return GetIcon (EditorIconId.FormatIndentIncrease); } }

		public static Image FormatItalic { get { return GetIcon (EditorIconId.FormatItalic); } }

		public static Image FormatLineSpacing { get { return GetIcon (EditorIconId.FormatLineSpacing); } }

		public static Image FormatListBulleted { get { return GetIcon (EditorIconId.FormatListBulleted); } }

		public static Image FormatListNumbered { get { return GetIcon (EditorIconId.FormatListNumbered); } }

		public static Image FormatPaint { get { return GetIcon (EditorIconId.FormatPaint); } }

		public static Image FormatQuote { get { return GetIcon (EditorIconId.FormatQuote); } }

		public static Image FormatShapes { get { return GetIcon (EditorIconId.FormatShapes); } }

		public static Image FormatSize { get { return GetIcon (EditorIconId.FormatSize); } }

		public static Image FormatStrikethrough { get { return GetIcon (EditorIconId.FormatStrikethrough); } }

		public static Image FormatTextdirectionLToR { get { return GetIcon (EditorIconId.FormatTextdirectionLToR); } }

		public static Image FormatTextdirectionRToL { get { return GetIcon (EditorIconId.FormatTextdirectionRToL); } }

		public static Image FormatUnderlined { get { return GetIcon (EditorIconId.FormatUnderlined); } }

		public static Image Functions { get { return GetIcon (EditorIconId.Functions); } }

		public static Image Highlight { get { return GetIcon (EditorIconId.Highlight); } }

		public static Image InsertChart { get { return GetIcon (EditorIconId.InsertChart); } }

		public static Image InsertComment { get { return GetIcon (EditorIconId.InsertComment); } }

		public static Image InsertDriveFile { get { return GetIcon (EditorIconId.InsertDriveFile); } }

		public static Image InsertEmoticon { get { return GetIcon (EditorIconId.InsertEmoticon); } }

		public static Image InsertInvitation { get { return GetIcon (EditorIconId.InsertInvitation); } }

		public static Image InsertLink { get { return GetIcon (EditorIconId.InsertLink); } }

		public static Image InsertPhoto { get { return GetIcon (EditorIconId.InsertPhoto); } }

		public static Image LinearScale { get { return GetIcon (EditorIconId.LinearScale); } }

		public static Image MergeType { get { return GetIcon (EditorIconId.MergeType); } }

		public static Image ModeComment { get { return GetIcon (EditorIconId.ModeComment); } }

		public static Image ModeEdit { get { return GetIcon (EditorIconId.ModeEdit); } }

		public static Image MonetizationOn { get { return GetIcon (EditorIconId.MonetizationOn); } }

		public static Image MultilineChart { get { return GetIcon (EditorIconId.MultilineChart); } }

		public static Image PieChart { get { return GetIcon (EditorIconId.PieChart); } }

		public static Image PieChartOutlined { get { return GetIcon (EditorIconId.PieChartOutlined); } }

		public static Image Publish { get { return GetIcon (EditorIconId.Publish); } }

		public static Image ShortText { get { return GetIcon (EditorIconId.ShortText); } }

		public static Image ShowChart { get { return GetIcon (EditorIconId.ShowChart); } }

		public static Image SpaceBar { get { return GetIcon (EditorIconId.SpaceBar); } }

		public static Image StrikethroughS { get { return GetIcon (EditorIconId.StrikethroughS); } }

		public static Image TextFields { get { return GetIcon (EditorIconId.TextFields); } }

		public static Image Title { get { return GetIcon (EditorIconId.Title); } }

		public static Image VerticalAlignBottom { get { return GetIcon (EditorIconId.VerticalAlignBottom); } }

		public static Image VerticalAlignCenter { get { return GetIcon (EditorIconId.VerticalAlignCenter); } }

		public static Image VerticalAlignTop { get { return GetIcon (EditorIconId.VerticalAlignTop); } }

		public static Image WrapText { get { return GetIcon (EditorIconId.WrapText); } }
	}
}
