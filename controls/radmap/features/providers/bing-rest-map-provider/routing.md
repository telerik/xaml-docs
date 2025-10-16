---
title: Routing
page_title: Routing
description: Check our &quot;Routing&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-providers-bing-rest-map-provider-routing
tags: bing,map,provider,rest,routing
published: True
position: 3
---

# Routing

RadMap provides a unified route search architecture which uses the functionality of the different routing services. This allows you to calculate a route between different locations on the map. You can access the routing service via __BingRestMapProvider__ provider. 

>caution The Bing Maps REST Services is [deprecated](https://learn.microsoft.com/en-us/bingmaps/rest-services/). The BingRestMapProvider will be supported until 2026 Q2 inclusive. To avoid disruptions, you can use the [Azure Maps Services](https://learn.microsoft.com/en-us/azure/azure-maps/), which are supported by the RadMap control via the [AzureMapProvider](radmap-features-providers-azuremapprovider).

>The BingRestMapProvider's built-in routing service wraps the [Routes API](https://msdn.microsoft.com/en-us/library/ff701705.aspx) of the Bing Maps Rest services.

![Rad Rest Map Routing Example](images/RadMap_Features_Rest_Provider_Routing.png)	
		
## Set up routing request and events

In order to get the routing data you can create instance of the __BingRestRouteRequest__ object. Then you can call the __CalculateRouteAsync()__ method of the __BingRestMapProvider__ which uses the request object as a parameter. Then you can subscribe to the BingRestMapProvider's __CalculateRouteCompleted__ and __CalculateRouteError__ event. You can take a look at the following steps:

* Set the __ApplicationId__ property of the __BingRestMapProvider__. This property represents a key, which allows you to use the Bing Rest Maps services.

	>Without supplying a valid key you won't be able to visualize the map inside the RadMap control. In order to learn how to obtain one, please read [Accessing the Control Using a Bing Maps](http://msdn.microsoft.com/en-us/library/ee681900.aspx).
	
* Create instance of the __BingRestRouteRequest__ object
* Handle __CalculateRouteCompleted__ and __CalculateRouteError__ events of the __BingRestMapProvider__
* Call __CalculateRouteAsync()__ method of the __BingRestRouteRequest__ and provide the request as a parameter

The __BingRestRouteRequest__ object provides __Options__ property of type __BingRestRouteOptions__ which allow the user to customize it. The following list represents this options:
 
* __Mode__: A property of type __BingRestTravelMode__ that gets or sets the type of direction. This mode is enumeration and it allows the following values.
	* __Driving__: The return route contains driving directions 
	* __Walking__: The return route contains walking directions
* __Optimization__: A property of type __BingRestRouteOptimization__ that gets or sets the calculation method that will use. This optimization is enumeration and it allows the following values.
	* __Distance__: The route is calculated to minimize the total distance. __Traffic information is not used.__
	* __Time__: The route is calculated to minimize the total time. __Traffic information is not used.__
	* __TimeWithTraffic__: The route is calculated to minimize the time and uses current traffic information.
	* __TimeAvoidClosure__: The route is calculated to minimize the time and avoid road closures. __Traffic information is not used.__
* __RouteAvoidance__: A property of type __BingRestRouteAvoidance__ that gets or sets the calculation method that will use. These route attributes are enumerations and it allows the following values.
	* __None__: Use all roads.
	* __Highways__: Avoids the use of highways in the route.
	* __Tolls__: Avoids the use of toll roads in the route.
	* __MinimizeHighways__: Minimizes (tries to avoid) the use of highways in the route.
	* __MinimizeTolls__: Minimizes (tries to avoid) the use of toll roads in the route.       
* __RouteAttributes__: A property of type __BingRestRouteAttributes__ that gets or sets whether to include or exclude parts of the routes response. The default value is BingRestRouteAttributes.ExcludeItinerary. This optimization is enumeration and it allows the following values.
	* __ExcludeItinerary__: Use all roads.
	* __RoutePath__: Avoids the use of highways in the route.
	* __TransitStops__: Avoids the use of toll roads in the route.
	* __All__: Minimizes __(tries to avoid)__ the use of highways in the route.
	* __RouteSummariesOnly__: Minimizes __(tries to avoid)__ the use of toll roads in the route.

__Example 1: Defining BingRestMapProvider XAML__
```XAML	
	<telerik:RadMap x:Name="myMap">
		<telerik:RadMap.Provider>
			<telerik:BingRestMapProvider ApplicationId="Bing_Key" 
										 x:Name="restProvider"
										 CalculateRouteCompleted="BingRestMapProvider_CalculateRouteCompleted"
										 CalculateRouteError="BingRestMapProvider_CalculateRouteError" 
										 Mode="Aerial"/>
		</telerik:RadMap.Provider>		
		<telerik:VisualizationLayer Name="routeLayer"
									UseBitmapCache="False"/>
		<telerik:VisualizationLayer Name="wayPointsLayer"/>
	</telerik:RadMap>
```

__Example 2: Defining BingRestRouteRequest object__
```C#	
		private LocationCollection wayPoints = new LocationCollection();
        public BingRestRouteRequest request { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.wayPointsLayer.ItemsSource = this.wayPoints;
            request = new BingRestRouteRequest();  
            this.restProvider.CalculateRouteAsync(request);
        }		
		private void BingRestMapProvider_CalculateRouteCompleted(object sender, BingRestRoutingCompletedEventArgs e)
        {     
        }		
        private void BingRestMapProvider_CalculateRouteError(object sender, BingRestCalculateRouteErrorEventArgs e)
        {
            MessageBox.Show(e.Error.ToString());
        }
```
```VB.NET	
	Private wayPoints As New LocationCollection()
	Private request As BingRestRouteRequest
	Public Sub New()
		InitializeComponent()
		Me.wayPointsLayer.ItemsSource = Me.wayPoints
		request = New BingRestRouteRequest()
		request.Options.RouteAttributes = BingRestRouteAttributes.RoutePath
		Me.restProvider.CalculateRouteAsync(request)
	End Sub

	Private Sub BingRestMapProvider_CalculateRouteCompleted(sender As Object, e As BingRestRoutingCompletedEventArgs)
	
	End Sub
	Private Sub BingRestMapProvider_CalculateRouteError(sender As Object, e As BingRestCalculateRouteErrorEventArgs)
		MessageBox.Show(e.Error.ToString)
	End Sub
```
	
## Executing Routing
	
In order to execute a routing action you have to call the __CalculateRouteAsync()__ method of the __BingRestMapProvider__ and pass a __BingRestRouteRequest__ object as its argument. The __BingRestRouteRequest__ should contain the points which should take part in the desired order. To pass the location points to the request argument just use its __Waypoints__ property.
	
__Example 4: Calling the CalculateRouteAsync() methods__
```C#	
	 private LocationCollection wayPoints = new LocationCollection();
        public BingRestRouteRequest request { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.wayPointsLayer.ItemsSource = this.wayPoints;
            request = new BingRestRouteRequest();
            wayPoints.Add(new Location(52.5629950395581, 13.359375));
            wayPoints.Add(new Location(48.835797462431, 2.2412109375));            
            request.Options.RouteAttributes = BingRestRouteAttributes.RoutePath;
            foreach (var point in wayPoints)
            {
                request.Waypoints.Add(point.ToString());
            }
            this.restProvider.CalculateRouteAsync(request);
        }
```
```VB.NET	
	Private wayPoints As New LocationCollection()
    Private request As BingRestRouteRequest
    Public Sub New()
        InitializeComponent()
        Me.wayPointsLayer.ItemsSource = Me.wayPoints
        request = New BingRestRouteRequest()
        request.Options.RouteAttributes = BingRestRouteAttributes.RoutePath
        wayPoints.Add(New Location(52.5629950395581, 13.359375))
        wayPoints.Add(New Location(48.835797462431, 2.2412109375))
        For Each point In wayPoints
            request.Waypoints.Add(point.ToString)
        Next
        Me.restProvider.CalculateRouteAsync(request)
    End Sub

    Private Sub BingRestMapProvider_CalculateRouteCompleted(sender As Object, e As BingRestRoutingCompletedEventArgs)

    End Sub

    Private Sub BingRestMapProvider_CalculateRouteError(sender As Object, e As BingRestCalculateRouteErrorEventArgs)
        MessageBox.Show(e.Error.ToString)
    End Sub
```

## Routing Result	
	
The result from the routing services is held by the Route object inside the __BingRestRoutingCompletedEventArgs__ of the handler for the __CalculateRouteCompleted__ event.
		
To get the result you have to access the Points collection of the __Telerik.Windows.Controls.DataVisualization.Map.BingRest.RoutePath__ object. In __Example 5__ the result is displayed by a PolylineData via the RadMap's visualization layer.	

__Example 5: Handling the CalculateRouteCompleted event__
```C#		
	private void BingRestMapProvider_CalculateRouteCompleted(object sender, BingRestRoutingCompletedEventArgs e)
	{          
		Telerik.Windows.Controls.DataVisualization.Map.BingRest.Route route = e.Route;
		if (route != null)
		{
			PolylineData routeLine = this.CreateNewPolyline(Colors.Blue, 5);

			// Building the polyline representing the route.
			foreach (double[] coordinatePair in route.RoutePath.Line.Coordinates)
			{
				Location point = new Location(coordinatePair[0], coordinatePair[1]);
				routeLine.Points.Add(point);
			}
			this.routeLayer.Items.Add(routeLine);
			// Bringing the route into view.
			double[] bbox = e.Route.BoundingBox;
			LocationRect rect = new LocationRect(new Location(bbox[2], bbox[1]), new Location(bbox[0], bbox[3]));
			this.myMap.SetView(rect);
		}
	}
	private PolylineData CreateNewPolyline(Color color, double thickness)
	{
		PolylineData routeLine = new PolylineData()
		{
			ShapeFill = new MapShapeFill()
			{
				Stroke = new SolidColorBrush(color),
				StrokeThickness = thickness,
				StrokeDashArray = this.request.Options.Mode == BingRestTravelMode.Walking ? new DoubleCollection() { 2, 1 } : new DoubleCollection(),
			},
			Points = new LocationCollection(),
		};
		return routeLine;
	}	
```
```VB.NET	
	Private Sub BingRestMapProvider_CalculateRouteCompleted(sender As Object, e As BingRestRoutingCompletedEventArgs)
        Dim route As Telerik.Windows.Controls.DataVisualization.Map.BingRest.Route = e.Route
        If route IsNot Nothing Then
            Dim routeLine As PolylineData = Me.CreateNewPolyline(Colors.Blue, 5)
            ' Building the polyline representing the route.'
            For Each coordinatePair As Double() In route.RoutePath.Line.Coordinates
                Dim point As New Location(coordinatePair(0), coordinatePair(1))
                routeLine.Points.Add(point)
            Next
            Me.routeLayer.Items.Add(routeLine)
            ' Bringing the route into view.'
            Dim bbox As Double() = e.Route.BoundingBox
            Dim rect As New LocationRect(New Location(bbox(2), bbox(1)), New Location(bbox(0), bbox(3)))
            Me.myMap.SetView(rect)
        End If
    End Sub
	Private Function CreateNewPolyline(color As Color, thickness As Double) As PolylineData
        Dim routeLine As New PolylineData
        routeLine.Points = New LocationCollection()

        Dim shapeFill As New MapShapeFill
        shapeFill.Stroke = New SolidColorBrush(color)
        shapeFill.StrokeThickness = thickness
        shapeFill.StrokeDashArray = If(Me.request.Options.Mode = BingRestTravelMode.Walking, New DoubleCollection() From {2, 1}, New DoubleCollection())
        routeLine.ShapeFill = shapeFill
        Return routeLine
    End Function
```	
	
## See Also
 * [Providers Overview] ({%slug radmap-features-providers%})
 * [Bing Rest Map]({%slug radmap-features-providers-bing-rest-map%})
 * [Search Location]({%slug radmap-features-providers-bing-rest-map-provider-search-location%})
 * [Elevation]({%slug  radmap-features-providers-bing-rest-map-provider-elevation%})
