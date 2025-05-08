---
title: Elevation
page_title: Elevation
description: Check our &quot;Elevation&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-providers-bing-rest-map-provider-elevation
tags: bing,map,provider,rest,elevation
published: True
position: 5
---

# Elevation

RadMap Bing Elevation Service allows you to obtain elevation information of a location on a map. You can get the elevation information for a set of locations, polyline or area on the Earth. You can access the elevation service via __BingRestMapProvider__ provider. 

>caution The Bing Maps REST Services is [deprecated](https://learn.microsoft.com/en-us/bingmaps/rest-services/). The BingRestMapProvider will be supported until 2026 Q2 inclusive. To avoid disruptions, you can use the [Azure Maps Services](https://learn.microsoft.com/en-us/azure/azure-maps/), which are supported by the RadMap control via the [AzureMapProvider](radmap-features-providers-azuremapprovider).

>The RadMap built-in elevation service wraps the [Elevation API](https://msdn.microsoft.com/en-us/library/jj158959.aspx) of the Bing Maps Rest services.

![Rad Rest Map Routing Example](images/RadMap_Features_Rest_Provider_Elevation.png)

In order to get the elevation data you can create instance of the __BingRestElevationRequest__ object. Then you can call the __CalculateElevationAsync()__ method of the __BingRestMapProvider__ which uses the request object as a parameter. Then you can subscribe to the BingRestMapProvider's __CalculateElevationCompleted__ and __CalculateElevationError__ event. You can take a look at the following steps:

* Set the __ApplicationId__ property of the __BingRestMapProvider__. This property represents a key, which allows you to use the Bing Rest Maps services.

	>Without supplying a valid key you won't be able to visualize the map inside the RadMap control. In order to learn how to obtain one, please read [Accessing the Control Using a Bing Maps](http://msdn.microsoft.com/en-us/library/ee681900.aspx).
	
* Create instance of the __BingRestRouteRequest__ object
* Handle __CalculateElevationCompleted__ and __CalculateElevationError__ events of the __BingRestMapProvider__
* Call __CalculateElevationAsync()__ method of the __BingRestRouteRequest__ and provide the request as a parameter

You can customize the __BingRestElevationRequest__ object by setting the following properties.
* __ElevationType__: A property of type __BingRestElevationRequestType__ that gets or sets the type of the elevation to be calculated. This mode is enumeration and it allows the following values.
	* __List__: Get elevations for latitude and longitude coordinates. Required parameters of the __BingRestElevationRequest__ object __Points__ property.
	* __Polyline__: Get elevations at equally-spaced locations along a polyline path. Required parameters of the __BingRestElevationRequest__ object __Points__ and __Samples__ properties.
	* __Bounds__: Get elevations at equally-spaced locations within an area on the Earth defined as a bounding box. Required parameters of the __BingRestElevationRequest__ object __Bounds__, __Rows__, __Columns__ properties.
	* __SeaLevel__: Get the offset of the geoid sea level Earth model from the ellipsoid Earth model at a set of latitude and longitude coordinates. Required parameters of the __BingRestElevationRequest__ object __Points__ property.
* __HeightsType__: A property of type __BingRestElevationHeightsType__ that gets or sets the elevation heights type used in the elevation service request. This mode is enumeration and it allows the following values.
	* __SeaLevel__: Use the geoid Earth model (EGM2008 2.5').
	* __Ellipsoid__: Use the ellipsoid Earth model (WGS84).
* __Points__: Gets or sets a set of coordinates on the Earth to use in elevation calculations. The exact use of these points depends on the type of elevation request.
* __Bounds__: Gets or sets the rectangular area over which to provide elevation values.
* __Rows__: Gets or sets the number of rows to use to divide the bounding box area into a grid. The rows that define the bounding box each count as two (2) of the rows. Elevation values are returned for all vertices of the grid. Integers with a value of two 2 or greater. The number of rows and columns can define a maximum of 1024 locations (rows * cols <= 1024).
* __Columns__: Gets or sets the number of columns to use to divide the bounding box area into a grid. The columns that define the bounding box each count as two (2) of the columns. Elevation values are returned for all vertices of the grid. Integers with a value of two 2 or greater. The number of rows and columns can define a maximum of 1024 locations (rows * cols <= 1024).
* __Samples__: Gets or sets the number of equally-spaced elevation values to provide along with a polyline path. A positive integer. The maximum number of samples is 1024.

## Get elevations for list of points

When the __ElevationType__ enumeration is set to __List__ the ElevationRequest gets elevations for given list of latitude and longitude coordinates. Elevations are returned for each set of coordinates.

#### __[XAML] Example 1: Defining BingRestMapProvider in XAML__
{{region xaml-radmap-features-providers-bing-rest-map-provider-elevation_0}}	
	 <Grid>
        <Grid.Resources>
            <DataTemplate x:Key="pushTemplate">
                <Grid VerticalAlignment="Top" HorizontalAlignment="Center" MinWidth="50">
                    <Grid.RowDefinitions>
                        <RowDefinition />
                        <RowDefinition />
                    </Grid.RowDefinitions>
                    <Border BorderBrush="{telerik:Windows8Resource ResourceKey=AccentBrush}" BorderThickness="1" 
                            Background="{telerik:Windows8Resource ResourceKey=AccentBrush}"  UseLayoutRounding="True">
                        <TextBlock Margin="4 2" Text="{Binding ElevationHeight}" Foreground="White" FontFamily="Segoe UI" FontSize="11" HorizontalAlignment="Center"/>
                    </Border>
                    <Path Data="M0,0L7,14L14,0" Fill="{telerik:Windows8Resource ResourceKey=AccentBrush}" Stretch="Fill" 
                          Width="14" Height="7" UseLayoutRounding="True" Stroke="Black"
                          VerticalAlignment="Bottom" HorizontalAlignment="Center"  Grid.Row="1" Margin="0 -1 0 0"/>
                </Grid>
            </DataTemplate>
        </Grid.Resources>
        <telerik:RadMap x:Name="myMap">
            <telerik:RadMap.Provider>
                <telerik:BingRestMapProvider x:Name="restProvider"                 
                                             ApplicationId="Bing_Key"
                                             CalculateElevationCompleted="BingRestMapProvider_CalculateElevationCompleted"
                                             CalculateElevationError="BingRestMapProvider_CalculateElevationError"
                                             Mode="Aerial"/>
            </telerik:RadMap.Provider>
            <telerik:VisualizationLayer x:Name="vizLayer" ItemTemplate="{StaticResource pushTemplate}"/>
        </telerik:RadMap>
    </Grid>
{{endregion}}

#### __[C#] Example 2: Setting list of locations__
{{region cs-radmap-features-providers-bing-rest-map-provider-elevation_1}}	
	public partial class MainWindow : Window
    {
        private ObservableCollection<ElevationModel> models = new ObservableCollection<ElevationModel>();
        public MainWindow()
        {
            InitializeComponent();
            this.myMap.Center = new Location(46.9481529297053, 10.9671020507813);
            this.myMap.ZoomLevel = 13;
            models.Add(new ElevationModel() { ModelLocation = new Location(46.9421687679625, 10.9677565097809) });
            models.Add(new ElevationModel() { ModelLocation = new Location(46.9189765706718, 10.9194660186768) });
            models.Add(new ElevationModel() { ModelLocation = new Location(46.923684692032, 10.921847820282) });
            models.Add(new ElevationModel() { ModelLocation = new Location(46.968539, 11.008300) });
            models.Add(new ElevationModel() { ModelLocation = new Location(46.9774489498581, 10.9834121062829) });

            BingRestElevationRequest request = new BingRestElevationRequest();
            request.HeightsType = BingRestElevationHeightsType.SeaLevel;
            request.ElevationType = BingRestElevationRequestType.List;
            request.Points = models.Select(x => x.ModelLocation).ToList();
            this.restProvider.CalculateElevationAsync(request);
        }

        private void BingRestMapProvider_CalculateElevationCompleted(object sender, Telerik.Windows.Controls.Map.BingRestElevationCompletedEventArgs e)
        {
            for (int i = 0; i < e.Elevations[0].Elevations.Count(); i++)
            {
                models[i].ElevationHeight = e.Elevations[0].Elevations[i];
            }
            this.vizLayer.ItemsSource = this.models;
        }

        private void BingRestMapProvider_CalculateElevationError(object sender, Telerik.Windows.Controls.Map.BingRestCalculateElevationErrorEventArgs e)
        {
            MessageBox.Show(e.Error.ToString());
        }
    }
    public class ElevationModel
    {
        public Location ModelLocation { get; set; }
        public double ElevationHeight { get; set; }
    }
{{endregion}}

#### __[VB.NET] Example 3: Setting list of locations__
{{region cs-radmap-features-providers-bing-rest-map-provider-elevation_2}}	
	Class MainWindow
		Private models As New ObservableCollection(Of ElevationModel)()
		Public Sub New()
			InitializeComponent()
			Me.myMap.Center = New Location(46.9481529297053, 10.9671020507813)
			Me.myMap.ZoomLevel = 13
			Dim locationOne = New ElevationModel()
			locationOne.ModelLocation = New Location(46.9421687679625, 10.9677565097809)
			Dim locationTwo = New ElevationModel()
			locationTwo.ModelLocation = New Location(46.9189765706718, 10.9194660186768)
			Dim locationThree = New ElevationModel()
			locationThree.ModelLocation = New Location(46.923684692032, 10.921847820282)
			Dim locationFour = New ElevationModel()
			locationFour.ModelLocation = New Location(46.968539, 11.0083)
			Dim locationFive = New ElevationModel()
			locationFive.ModelLocation = New Location(46.9774489498581, 10.9834121062829)
			models.Add(locationOne)
			models.Add(locationTwo)
			models.Add(locationThree)
			models.Add(locationFour)
			models.Add(locationFive)
			Dim request As New BingRestElevationRequest()
			request.HeightsType = BingRestElevationHeightsType.SeaLevel
			request.ElevationType = BingRestElevationRequestType.List
			request.Points = models.[Select](Function(x) x.ModelLocation).ToList()
			Me.restProvider.CalculateElevationAsync(request)
		End Sub
		Private Sub BingRestMapProvider_CalculateElevationCompleted(sender As Object, e As Telerik.Windows.Controls.Map.BingRestElevationCompletedEventArgs)
			For i As Integer = 0 To e.Elevations(0).Elevations.Count() - 1
				models(i).ElevationHeight = e.Elevations(0).Elevations(i)
			Next
			Me.vizLayer.ItemsSource = Me.models
		End Sub

		Private Sub BingRestMapProvider_CalculateElevationError(sender As Object, e As Telerik.Windows.Controls.Map.BingRestCalculateElevationErrorEventArgs)
			MessageBox.Show(e.Error.ToString)
		End Sub
	End Class
	Class ElevationModel
		Private m_ModelLocation As Location
		Public Property ModelLocation() As Location
			Get
				Return m_ModelLocation
			End Get
			Set
				m_ModelLocation = Value
			End Set
		End Property
		Public Property ElevationHeight() As Double
			Get
				Return m_ElevationHeight
			End Get
			Set
				m_ElevationHeight = Value
			End Set
		End Property
		Private m_ElevationHeight As Double
	End Class
{{endregion}}

## See Also
 * [Providers Overview]({%slug radmap-features-providers%})
 * [ArcGIS Online Map Provider]({%slug radmap-features-providers-arcgis%})
