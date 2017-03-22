using System;
using UIKit;
using CoreLocation;
using MapKit;
using System.Collections.Generic;
using Foundation;

namespace iOSSampleControls
{
    public partial class ViewController : UIViewController
    {
        private List<Dados> Lista;
        public ViewController(IntPtr handle) : base(handle)
        {
            Lista = DadosList();
        }

        public List<Dados> DadosList()
        {
            var infomationList = new List<Dados>()
            {
                new Dados ("León, México", 21.15_26_76, -101.71_16_98),
                new Dados ("Cancún, México", 21.05_27_43, -86.84_72_42),
                new Dados ("Tijuana, México", 32.526384, -117.028983),
            };

            return infomationList;

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Visor.Image = UIImage.FromFile("images/dog.jpg");
            string htmlString =
                "<html>" +
                    "<body>" +
                        "<h1> Hello World, Controls!!" +
                    "</body>" +
                "</html>";
            VisorWeb.LoadHtmlString(htmlString, new NSUrl("./", true));
            Selector.ValueChanged += (s, e) => {
                switch (Selector.SelectedSegment)
                {
                    case 0:
                        Mapa.MapType = MKMapType.Standard;
                        break;

                    case 1:
                        Mapa.MapType = MKMapType.Satellite;
                        break;

                    case 2:
                        Mapa.MapType = MKMapType.Hybrid;
                        break;

                }
            };
            Lista.ForEach(x => Mapa.AddAnnotation(new MKPointAnnotation()
            {
                Title = x.Titulo,
                Coordinate = new CLLocationCoordinate2D()
                {
                    Latitude = x.Latitude,
                    Longitude = x.Longitude
                }
                
            }));

            var Leon = new CLLocationCoordinate2D(21.15_26_76, -101.71_16_98);
            var Cancun = new CLLocationCoordinate2D(21.05_27_43, -86.84_72_42);
            var Tijuana = new CLLocationCoordinate2D(32.526384, -117.028983);

            var Info = new NSDictionary();
            var OrigemDestino = new MKDirectionsRequest()
            {
                Source = new MKMapItem(new MKPlacemark(Leon,Info)),
                Destination = new MKMapItem(new MKPlacemark(Cancun,Info)),
            };
            var OrigemDestino2 = new MKDirectionsRequest()
            {
                Source = new MKMapItem(new MKPlacemark(Leon, Info)),
                Destination = new MKMapItem(new MKPlacemark(Tijuana, Info)),
            };
            var RotaLeonCancun = new MKDirections(OrigemDestino);
            RotaLeonCancun.CalculateDirections((response, error) => {
                if (error == null)
                {
                    var rota = response.Routes[0];
                    var Linha = new MKPolylineRenderer(rota.Polyline)
                    {
                        LineWidth = 5.0f,
                        StrokeColor = UIColor.Red
                    };
                    Mapa.OverlayRenderer = (Red, Err) => Linha;
                    Mapa.AddOverlay(rota.Polyline, MKOverlayLevel.AboveRoads);
                }
            });

            var RotaLeonTijuana = new MKDirections(OrigemDestino2);
            RotaLeonTijuana.CalculateDirections((response, error) => {
                if (error == null)
                {
                    var rota = response.Routes[0];
                    var Linha = new MKPolylineRenderer(rota.Polyline)
                    {
                        LineWidth = 5.0f,
                        StrokeColor = UIColor.Blue
                    };
                    Mapa.OverlayRenderer = (Red, Err) => Linha;
                    Mapa.AddOverlay(rota.Polyline, MKOverlayLevel.AboveRoads);
                }
            });
            
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}