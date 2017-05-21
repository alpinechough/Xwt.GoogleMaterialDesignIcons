using System;
using System.Reflection;

using Xwt;
using Xwt.Drawing;
using Xwt.GoogleMaterialDesignIcons;

namespace GoogleMaterialDesignIconsTest
{
	public class MainWindow: Window
	{
		private TreeStore store;
		private TreeView samplesTree;
		private DataField<string> nameCol = new DataField<string> ();
		private DataField<Type> widgetCol = new DataField<Type> ();
		private VBox currentSample;
		private VBox sampleBox;

		private TreePosition AddSample (TreePosition pos, string name, Type sampleType)
		{
			return store.AddNode (pos).SetValue (nameCol, name).SetValue (widgetCol, sampleType).CurrentPosition;
		}

		private void HandleSamplesTreeSelectionChanged (object sender, EventArgs e)
		{
			if (samplesTree.SelectedRow == null) {
				return;
			}

			if (currentSample != null) {
				sampleBox.Remove (currentSample);
			}

			Type t = store.GetNavigatorAt (samplesTree.SelectedRow).GetValue (widgetCol);
			if (t == null) {
				return;
			}

			currentSample = new VBox ();

			HBox row = null;

			var icons = t.GetProperties (BindingFlags.Public | BindingFlags.Static);

			for (int i = 0; i < icons.Length; i++) {
				if (i % 3 == 0) {
					if (row != null) {
						currentSample.PackStart (row);
					}
					row = new HBox ();
				}

				if (icons [i].PropertyType != typeof(Image)) {
					continue;
				}

				Image img = (Image)(icons [i].GetValue (typeof(Image), null));
				row.PackStart (new ImageView (img.WithSize (IconSize.Large)));
				row.PackStart (new ImageView (img.WithSize (IconSize.Medium)));
				row.PackStart (new ImageView (img.WithSize (IconSize.Small)));
			}

			currentSample.PackStart (row);
			sampleBox.PackStart (currentSample);
		}

		public MainWindow ()
		{
			Title = "Xwt Google Material Design Icon Demo Application";
			Width = 500;
			Height = 400;

			Menu menu = new Menu ();

			var file = new MenuItem ("_File");
			file.SubMenu = new Menu ();

			MenuItem mi = new MenuItem ("_Close");

			mi.Clicked += delegate {
				Application.Exit ();
			};

			file.SubMenu.Items.Add (mi);
			menu.Items.Add (file);

			MainMenu = menu;

			HPaned box = new HPaned ();
			box.Position = 160;

			store = new TreeStore (nameCol, widgetCol);
			samplesTree = new TreeView ();
			samplesTree.Columns.Add ("Name", nameCol);

			var w = AddSample (null, "Icons", null);
			AddSample (w, "Action", typeof(ActionIcons));
			AddSample (w, "Alert", typeof(AlertIcons));
			AddSample (w, "Av", typeof(AvIcons));
			AddSample (w, "Communication", typeof(CommunicationIcons));
			AddSample (w, "Content", typeof(ContentIcons));
			AddSample (w, "Device", typeof(DeviceIcons));
			AddSample (w, "Editor", typeof(EditorIcons));
			AddSample (w, "File", typeof(FileIcons));
			AddSample (w, "Hardware", typeof(HardwareIcons));
			AddSample (w, "Image", typeof(ImageIcons));
			AddSample (w, "Maps", typeof(MapsIcons));
			AddSample (w, "Navigation", typeof(NavigationIcons));
			AddSample (w, "Notification", typeof(NotificationIcons));
			AddSample (w, "Places", typeof(PlacesIcons));
			AddSample (w, "Social", typeof(SocialIcons));
			AddSample (w, "Toggle", typeof(ToggleIcons));
			samplesTree.DataSource = store;

			box.Panel1.Content = samplesTree;

			ScrollView scrollView = new ScrollView ();
			scrollView.VerticalScrollPolicy = ScrollPolicy.Always;

			sampleBox = new VBox ();
			scrollView.Content = sampleBox;

			box.Panel2.Content = scrollView;
			box.Panel2.Resize = true;

			Content = box;

			samplesTree.SelectionChanged += HandleSamplesTreeSelectionChanged;

			CloseRequested += delegate {
				Application.Exit ();
			};
		}
	}
}

