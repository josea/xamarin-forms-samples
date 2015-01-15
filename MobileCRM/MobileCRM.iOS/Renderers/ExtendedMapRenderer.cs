using System;
using Xamarin.Forms;
using Xamarin.Forms.Maps.iOS;
using Xamarin.Forms.Platform.iOS;
using System.Threading.Tasks;
using MapKit;
using Xamarin.Forms.Maps;
using CoreLocation;


[assembly: ExportRenderer(typeof( Xamarin.Forms.Maps.Map), typeof(MobileCRM.iOS.ExtendedMapRenderer))]

namespace MobileCRM.iOS
{
	public class ExtendedMapRenderer : MapRenderer
	{
		public class MyMapViewDelegate : MKMapViewDelegate
		{
			public override MKAnnotationView GetViewForAnnotation (MKMapView mapView, IMKAnnotation annotation)
			{
				var pin = new MKPinAnnotationView (annotation, "pin");
				pin.PinColor = MKPinAnnotationColor.Green;

				return pin; 
				//return null;
			}
		}

		private MKMapView _map { get { return Control as MKMapView; } } 

		public ExtendedMapRenderer() :base()
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged(e); 

			if (_map != null) {
				// Comment/uncomment this line will change if the Map.VisibleRegion property is set or not.
				// ... that doesn't make sense.
				_map.Delegate = new MyMapViewDelegate (); 
			}

		}
	}



}

