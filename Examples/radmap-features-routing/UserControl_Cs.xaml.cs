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

#region radmap-features-routing_1
LocationCollection wayPoints = new LocationCollection();
BingRouteProvider routeProvider;
public RouteSample()
{
    InitializeComponent();
    this.routeProvider = new BingRouteProvider();
    this.routeProvider.ApplicationId = "key";
    this.routeProvider.MapControl = this.radMap;
    this.routeProvider.RoutingCompleted += this.routeProvider_RoutingCompleted;

    this.wayPointsLayer.ItemsSource = this.wayPoints;
}
private void routeProvider_RoutingCompleted( object sender, RoutingCompletedEventArgs e )
{
}
#endregion

#region radmap-features-routing_3
private void ExecuteRouting()
{
    RouteRequest request = new RouteRequest();
    request.Options.RoutePathType = RoutePathType.Points;
    Location sofia = new Location( 42.7072638273239, 23.3318710327148 );
    Location munich = new Location( 48.1364169716835, 11.577525883913 );
    Location amsterdam = new Location( 52.3712052404881, 4.8920676112175 );
    request.Waypoints.Add( sofia );
    request.Waypoints.Add( munich );
    request.Waypoints.Add( amsterdam );
    this.routeProvider.CalculateRouteAsync( request );
}
#endregion

#region radmap-features-routing_3b
private void MapMouseClick(object sender, MapMouseRoutedEventArgs eventArgs)
{
    this.wayPoints.Add(eventArgs.Location);
}

private void ClearRouteClicked(object sender, RoutedEventArgs e)
{
    this.findRouteButton.IsEnabled = true;

    this.wayPoints.Clear();
    this.routeLayer.Items.Clear();
}

private void FindRouteClicked(object sender, RoutedEventArgs e)
{
    this.routeLayer.Items.Clear();

    RouteRequest routeRequest = new RouteRequest();
    routeRequest.Culture = new System.Globalization.CultureInfo("en-US");
    routeRequest.Options.RoutePathType = RoutePathType.Points;

    if (this.wayPoints.Count > 1)
    {
        this.findRouteButton.IsEnabled = false;

        foreach (Location location in this.wayPoints)
        {
            routeRequest.Waypoints.Add(location);
        }
        this.routeProvider.CalculateRouteAsync(routeRequest);
    }
}
#endregion

#region radmap-features-routing_5
private void RouteProvider_RoutingCompleted(object sender, RoutingCompletedEventArgs e)
{
    this.findRouteButton.IsEnabled = true;

    RouteResponse routeResponse = e.Response as RouteResponse;
    if (routeResponse != null
        && routeResponse.Error == null)
    {
        if (routeResponse.Result != null 
            && routeResponse.Result.RoutePath != null)
        {
            PolylineData routeLine = new PolylineData()
            {
                Points = routeResponse.Result.RoutePath.Points,
                ShapeFill = new MapShapeFill()
                {
                    Stroke = new SolidColorBrush(Colors.Red),
                    StrokeThickness = 2
                }
            };

            this.routeLayer.Items.Add(routeLine);
        }
    }
}
#endregion
}
