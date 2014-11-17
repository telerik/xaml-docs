using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radmap-howto-resize-map-shapes-with-mouse-dragging_1
private void radMap_InitializeCompleted(object sender, EventArgs e)
        {
            if (!initialized)
            {
                initialized = true;

                this.BuildPolyline();
            }
        }

        private void BuildPolyline()
        {
            LocationCollection points = new LocationCollection();
            points.Add(new Location(40, -100));
            points.Add(new Location(41, -101));
            points.Add(new Location(40, -102));
            points.Add(new Location(43, -103));
            points.Add(new Location(45, -97));

            MapPolyline polyline = new MapPolyline();
            polyline.Points = points;

            this.polylineLayer.Items.Add(polyline);
            }
#endregion

#region radmap-howto-resize-map-shapes-with-mouse-dragging_2
  private void pinPoint_MouseMove(object sender, MouseEventArgs e)
        {
            if (!this.isDragging)
                return;

            var pinPoint = sender as MapPinPoint;
            var oldLocation = MapLayer.GetLocation(pinPoint);
            var location = Location.GetCoordinates(radMap, e.GetPosition(radMap));
            MapLayer.SetLocation(sender as DependencyObject, location);

            var polyline = this.polylineLayer.Items[0] as MapPolyline;
            for (int i = 0; i < polyline.Points.Count; i++)
            {
                var locationPoint = polyline.Points[i];
                if (locationPoint == oldLocation)
                {
                    polyline.Points[i] = location;
                    break;
                }
            }
        }
#endregion
}
