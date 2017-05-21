using System;
using Xwt.Drawing;

namespace Xwt.GoogleMaterialDesignIcons
{
	public class MapsIcons
	{
		static Image GetIcon (string id)
		{
			string resourceId = typeof(MapsIcons).Assembly.FullName.Split (',') [0] + ".Resources.Maps." + id + "32px.png";
			return Image.FromResource (typeof(MapsIcons), resourceId);
		}

		public static Image AddLocation { get { return GetIcon (MapsIconId.AddLocation); } }

		public static Image Beenhere { get { return GetIcon (MapsIconId.Beenhere); } }

		public static Image Directions { get { return GetIcon (MapsIconId.Directions); } }

		public static Image DirectionsBike { get { return GetIcon (MapsIconId.DirectionsBike); } }

		public static Image DirectionsBoat { get { return GetIcon (MapsIconId.DirectionsBoat); } }

		public static Image DirectionsBus { get { return GetIcon (MapsIconId.DirectionsBus); } }

		public static Image DirectionsCar { get { return GetIcon (MapsIconId.DirectionsCar); } }

		public static Image DirectionsRailway { get { return GetIcon (MapsIconId.DirectionsRailway); } }

		public static Image DirectionsRun { get { return GetIcon (MapsIconId.DirectionsRun); } }

		public static Image DirectionsSubway { get { return GetIcon (MapsIconId.DirectionsSubway); } }

		public static Image DirectionsTransit { get { return GetIcon (MapsIconId.DirectionsTransit); } }

		public static Image DirectionsWalk { get { return GetIcon (MapsIconId.DirectionsWalk); } }

		public static Image EditLocation { get { return GetIcon (MapsIconId.EditLocation); } }

		public static Image EvStation { get { return GetIcon (MapsIconId.EvStation); } }

		public static Image Flight { get { return GetIcon (MapsIconId.Flight); } }

		public static Image Hotel { get { return GetIcon (MapsIconId.Hotel); } }

		public static Image Layers { get { return GetIcon (MapsIconId.Layers); } }

		public static Image LayersClear { get { return GetIcon (MapsIconId.LayersClear); } }

		public static Image LocalActivity { get { return GetIcon (MapsIconId.LocalActivity); } }

		public static Image LocalAirport { get { return GetIcon (MapsIconId.LocalAirport); } }

		public static Image LocalAtm { get { return GetIcon (MapsIconId.LocalAtm); } }

		public static Image LocalBar { get { return GetIcon (MapsIconId.LocalBar); } }

		public static Image LocalCafe { get { return GetIcon (MapsIconId.LocalCafe); } }

		public static Image LocalCarWash { get { return GetIcon (MapsIconId.LocalCarWash); } }

		public static Image LocalConvenienceStore { get { return GetIcon (MapsIconId.LocalConvenienceStore); } }

		public static Image LocalDining { get { return GetIcon (MapsIconId.LocalDining); } }

		public static Image LocalDrink { get { return GetIcon (MapsIconId.LocalDrink); } }

		public static Image LocalFlorist { get { return GetIcon (MapsIconId.LocalFlorist); } }

		public static Image LocalGasStation { get { return GetIcon (MapsIconId.LocalGasStation); } }

		public static Image LocalGroceryStore { get { return GetIcon (MapsIconId.LocalGroceryStore); } }

		public static Image LocalHospital { get { return GetIcon (MapsIconId.LocalHospital); } }

		public static Image LocalHotel { get { return GetIcon (MapsIconId.LocalHotel); } }

		public static Image LocalLaundryService { get { return GetIcon (MapsIconId.LocalLaundryService); } }

		public static Image LocalLibrary { get { return GetIcon (MapsIconId.LocalLibrary); } }

		public static Image LocalMall { get { return GetIcon (MapsIconId.LocalMall); } }

		public static Image LocalMovies { get { return GetIcon (MapsIconId.LocalMovies); } }

		public static Image LocalOffer { get { return GetIcon (MapsIconId.LocalOffer); } }

		public static Image LocalParking { get { return GetIcon (MapsIconId.LocalParking); } }

		public static Image LocalPharmacy { get { return GetIcon (MapsIconId.LocalPharmacy); } }

		public static Image LocalPhone { get { return GetIcon (MapsIconId.LocalPhone); } }

		public static Image LocalPizza { get { return GetIcon (MapsIconId.LocalPizza); } }

		public static Image LocalPlay { get { return GetIcon (MapsIconId.LocalPlay); } }

		public static Image LocalPostOffice { get { return GetIcon (MapsIconId.LocalPostOffice); } }

		public static Image LocalPrintshop { get { return GetIcon (MapsIconId.LocalPrintshop); } }

		public static Image LocalSee { get { return GetIcon (MapsIconId.LocalSee); } }

		public static Image LocalShipping { get { return GetIcon (MapsIconId.LocalShipping); } }

		public static Image LocalTaxi { get { return GetIcon (MapsIconId.LocalTaxi); } }

		public static Image Map { get { return GetIcon (MapsIconId.Map); } }

		public static Image MyLocation { get { return GetIcon (MapsIconId.MyLocation); } }

		public static Image Navigation { get { return GetIcon (MapsIconId.Navigation); } }

		public static Image NearMe { get { return GetIcon (MapsIconId.NearMe); } }

		public static Image PersonPin { get { return GetIcon (MapsIconId.PersonPin); } }

		public static Image PersonPinCircle { get { return GetIcon (MapsIconId.PersonPinCircle); } }

		public static Image PinDrop { get { return GetIcon (MapsIconId.PinDrop); } }

		public static Image Place { get { return GetIcon (MapsIconId.Place); } }

		public static Image RateReview { get { return GetIcon (MapsIconId.RateReview); } }

		public static Image Restaurant { get { return GetIcon (MapsIconId.Restaurant); } }

		public static Image RestaurantMenu { get { return GetIcon (MapsIconId.RestaurantMenu); } }

		public static Image Satellite { get { return GetIcon (MapsIconId.Satellite); } }

		public static Image StoreMallDirectory { get { return GetIcon (MapsIconId.StoreMallDirectory); } }

		public static Image Streetview { get { return GetIcon (MapsIconId.Streetview); } }

		public static Image Subway { get { return GetIcon (MapsIconId.Subway); } }

		public static Image Terrain { get { return GetIcon (MapsIconId.Terrain); } }

		public static Image Traffic { get { return GetIcon (MapsIconId.Traffic); } }

		public static Image Train { get { return GetIcon (MapsIconId.Train); } }

		public static Image Tram { get { return GetIcon (MapsIconId.Tram); } }

		public static Image TransferWithinAStation { get { return GetIcon (MapsIconId.TransferWithinAStation); } }

		public static Image ZoomOutMap { get { return GetIcon (MapsIconId.ZoomOutMap); } }
	}
}
