---
title: Search Location
page_title: Search Location
description: Check our &quot;Search Location&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-providers-bing-rest-map-provider-search-location
tags: bing,map,provider,rest,location api, search
published: True
position: 2
---

# Search Location

The RadMap control allows the user to implement search functionality, that will let the user search for a specific place on the map.  The search is performed through an __IBingRestSearchLocationProvider__ interface, which communicates with the respective map provider's services. The __BingRestMapProvider__ implements this interface. In the following sections of this article we will demonstrate how you can implement this functionality.

>caution The Bing Maps REST Services is [deprecated](https://learn.microsoft.com/en-us/bingmaps/rest-services/). The BingRestMapProvider will be supported until 2026 Q2 inclusive. To avoid disruptions, you can use the [Azure Maps Services](https://learn.microsoft.com/en-us/azure/azure-maps/), which are supported by the RadMap control via the [AzureMapProvider](radmap-features-providers-azuremapprovider).

>The RadMap search functionality wraps the [Location API](https://msdn.microsoft.com/en-us/library/ff701715.aspx) of the Bing Rest Map services.

## Find a place by given Location or Query

In the following examples, we will demonstrate how to find a specific location by given address or location. To do it you can create an instance of the __BingRestSearchLocationRequest__ object which the __SearchLocationAsync()__ method of the __BingRestMapProvider__ uses as a parameter and set its __Query__ property. Then you can subscribe to the __SearchLocationCompleted__ and __SearchLocationError__ events of the __BingRestMapProvider__. The __SearchLocationError__ event is the place for handling any kind of errors that occur during the search operation.  You can take a look at the following steps:

* Set the __ApplicationId__ property of the __BingRestMapProvider__. This property represents a key, which allows you to use the Bing Rest Maps services.
	
	>Without supplying a valid key you won't be able to visualize the map inside the RadMap control. In order to learn how to obtain one, please read [Accessing the Control Using a Bing Maps](http://msdn.microsoft.com/en-us/library/ee681900.aspx).

* Create instance of the __BingRestSearchLocationRequest__ object
* Handle __SearchLocationCompleted__ and __SearchLocationError__ events of the __BingRestMapProvider__
* Call __SearchLocationAsync()__ method of the __BingRestMapProvider__ and provide the request as a parameter
	
>The __SearchLocationCompleted__ returns __BingRestSearchLocationCompletedEventArgs__ argument which contains array of Telerik.Windows.Controls.DataVisualization.Map.BingRest.__Location__ objects. This is a complex __DataContract__ object given from the __Bing REST__ services and contains lots of data – address, name, geocode points, district, maneuver type etc. For better overview follow [Search](https://github.com/telerik/xaml-sdk/tree/master/Map/WPF/Search) sample project.
   
* __Find a place by Location__
	In this example we will get the location on the MapMouseClick event of the RadMap.	
	#### __[XAML] Example 1: Defining BingRestMapProvider in XAML__
	{{region cs-radmap-features-providers-bing-rest-map-provider-search-location_0}}
		<telerik:RadMap x:Name="myMap" MapMouseClick="bingMap_MapMouseClick">
            <telerik:RadMap.Provider>
                <telerik:BingRestMapProvider ApplicationId="Bing_Key" 
                                             x:Name="restProvider"
                                             SearchLocationCompleted="restProvider_SearchLocationCompleted"
                                             SearchLocationError="restProvider_SearchLocationError"
                                             Mode="Aerial"/>
            </telerik:RadMap.Provider>           
        </telerik:RadMap>
	{{endregion}}
	
	#### __[C#] Example 2: Get location by mouse click__
	{{region cs-radmap-features-providers-bing-rest-map-provider-search-location_1}}
				
		private void bingMap_MapMouseClick(object sender, MapMouseRoutedEventArgs eventArgs)
		{
			GetSearchData(eventArgs.Location);
		}
		private void GetSearchData(Location location)
		{
			// Build location request.
			BingRestSearchLocationRequest request = new BingRestSearchLocationRequest();        
			request.Query = location.ToString();
			// Call the location service.            
			this.restProvider.SearchLocationAsync(request);
		}
		private void restProvider_SearchLocationCompleted(object sender, BingRestSearchLocationCompletedEventArgs e)
		{
			foreach (Telerik.Windows.Controls.DataVisualization.Map.BingRest.Location location in e.Locations)
			{
				MessageBox.Show(string.Format("Address: {0}", location.Address.FormattedAddress));
			}
		}
		private void restProvider_SearchLocationError(object sender, BingRestSearchLocationErrorEventArgs e)
		{
			MessageBox.Show(e.Error.ToString());
		}	
	{{endregion}}
	#### __[VB.NET] Example 2: Get location by mouse click__
	{{region vb-radmap-features-providers-bing-rest-map-provider-search-location_2}}
		Private Sub myMap_MapMouseClick(sender As Object, eventArgs As MapMouseRoutedEventArgs)
			GetSearchData(eventArgs.Location)
		End Sub

		Private Sub GetSearchData(location As Location)
			' Build location request.'
			Dim data As New BingRestSearchLocationRequest()
			data.Query = location.ToString
			' Call the location service.'
			Me.restProvider.SearchLocationAsync(data)
		End Sub

		Private Sub restProvider_SearchLocationCompleted(sender As Object, e As BingRestSearchLocationCompletedEventArgs)
			For Each location As Telerik.Windows.Controls.DataVisualization.Map.BingRest.Location In e.Locations
				MessageBox.Show(String.Format("Address: {0}", location.Address.FormattedAddress))
			Next
		End Sub

		Private Sub restProvider_SearchLocationError(sender As Object, e As BingRestSearchLocationErrorEventArgs)
			MessageBox.Show(e.Error.ToString)
		End Sub
	{{endregion}}
	
* __Find a place by Address/String Query__

	The approach here is almost the same as the one explained above. Here we are setting a string address to the Query property of the __BingRestSearchLocationRequest__ object.

	#### __[XAML] Example 3: Defining BingRestMapProvider in XAML__
	{{region cs-radmap-features-providers-bing-rest-map-provider-search-location_3}}
		<telerik:RadMap x:Name="myMap">
            <telerik:RadMap.Provider>
                <telerik:BingRestMapProvider ApplicationId="Bing_Key" 
                                             x:Name="restProvider"
                                             SearchLocationCompleted="restProvider_SearchLocationCompleted"
                                             SearchLocationError="restProvider_SearchLocationError"
                                             Mode="Aerial"/>
            </telerik:RadMap.Provider>           
        </telerik:RadMap>
	{{endregion}}
	
	#### __[C#] Example 3: Get a location by specific address__
	{{region cs-radmap-features-providers-bing-rest-map-provider-search-location_4}}
		public partial class MainWindow : Window
		{
			public MainWindow()
			{
				InitializeComponent();
				this.myMap.Loaded += Map_Loaded;
			}

			private void Map_Loaded(object sender, RoutedEventArgs e)
			{
				// Build location request.
				BingRestSearchLocationRequest data = new BingRestSearchLocationRequest();
				data.Query = "162 South Avenue, Bloomington, MN 55425";
				// Call the location service.    
				this.restProvider.SearchLocationAsync(data);
			}

			private void restProvider_SearchLocationCompleted(object sender, BingRestSearchLocationCompletedEventArgs e)
			{
				double[] bbox = e.Locations[0].BoundingBox;
				LocationRect rect = new LocationRect(new Location(bbox[2], bbox[1]), new Location(bbox[0], bbox[3]));
				this.myMap.SetView(rect);
				foreach (Telerik.Windows.Controls.DataVisualization.Map.BingRest.Location location in e.Locations)
				{
					var coordinates = location.GeocodePoints[0].Coordinates;
					double latitude = coordinates[0];
					double longitude = coordinates[1];
					MessageBox.Show(string.Format("Longitude: {0}, Latitude: {1}, Address: {2}", longitude, latitude, location.Address.FormattedAddress));
				}
			}

			private void restProvider_SearchLocationError(object sender, BingRestSearchLocationErrorEventArgs e)
			{
				MessageBox.Show(e.Error.ToString());
			}
		}	
	{{endregion}}	
	#### __[VB.NET] Example 3: Get a location by specific address__
	{{region vb-radmap-features-providers-bing-rest-map-provider-search-location_5}}
		Class MainWindow
			Public Sub New()
				InitializeComponent()
				AddHandler Me.myMap.Loaded, AddressOf Map_Loaded
			End Sub

			Private Sub Map_Loaded(sender As Object, e As RoutedEventArgs)
				' Build location request.'
				Dim data As New BingRestSearchLocationRequest()
				data.Query = "162 South Avenue, Bloomington, MN 55425"
				' Call the location service.'
				Me.restProvider.SearchLocationAsync(data)
			End Sub

			Private Sub restProvider_SearchLocationCompleted(sender As Object, e As BingRestSearchLocationCompletedEventArgs)
				Dim bbox As Double() = e.Locations(0).BoundingBox
				Dim rect As New LocationRect(New Location(bbox(2), bbox(1)), New Location(bbox(0), bbox(3)))
				Me.myMap.SetView(rect)
				For Each location As Telerik.Windows.Controls.DataVisualization.Map.BingRest.Location In e.Locations
					Dim coordinates = location.GeocodePoints(0).Coordinates
					Dim latitude As Double = coordinates(0)
					Dim longitude As Double = coordinates(1)
					MessageBox.Show(String.Format("Longitude: {0}, Latitude: {1}, Address: {2}", longitude, latitude, location.Address.FormattedAddress))
				Next
			End Sub

			Private Sub restProvider_SearchLocationError(sender As Object, e As BingRestSearchLocationErrorEventArgs)
				MessageBox.Show(e.Error.ToString)
			End Sub
		End Class
	{{endregion}}

## Structured / Unstructured URL
	
The __Microsoft Bing Maps REST Service__ provides two URL templates which you can use to get latitude and longitude coordinates for a location by a given query. To learn more about these templates, please refer to the [Find a Location by Address](https://msdn.microsoft.com/en-us/library/ff701711.aspx)) MSDN article.

With the __R1 2018 SP2__ version of our controls, you can now change the type of URL which the BingRestMapProvider's search mechanism uses in its code. By default, the __BingRestSearchLocationRequest__ uses the __structured__ URL template. To force the search functionality to use an unstructured URL template, you can set the __UseUnstructuredQuery__ property of the __BingRestSearchLocationRequest__ to __True__. 

Setting one of these URLs depends on how you have structured your query. To search for a location you can type it in structured form, for example, '1 Microsoft way, Redmond WA 98052'. In such a scenario you can use a __Structured URL__. On the other hand, if you type an unstructured address (or free form query) you should choose the unstructured Bing URL to get better results from the service.	

#### __[C#] Example 4: Get a location by specific address__
	{{region cs-radmap-features-providers-bing-rest-map-provider-search-location_6}}	
		BingRestMapProvider provider = new BingRestMapProvider(MapMode.Aerial, true, "Your Bing Map Key");
		BingRestSearchLocationRequest request = new BingRestSearchLocationRequest();
		request.SearchLocationOptions.UseUnstructuredQuery = true;
		request.Query = "Your query";
		this.provider.SearchLocationAsync(request);		
	{{endregion}}
	
## See Also
 * [Providers Overview] ({%slug radmap-features-providers%})
 * [Bing Rest Map]({%slug radmap-features-providers-bing-rest-map%})
 * [Routing]({%slug  radmap-features-providers-bing-rest-map-provider-routing%})
 * [Elevation]({%slug  radmap-features-providers-bing-rest-map-provider-elevation%})
