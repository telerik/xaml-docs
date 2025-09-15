---
title: Data Binding
page_title: Data Binding
description: Check our &quot;Data Binding&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-visualization-layer-data-binding
tags: data,binding
published: True
position: 1
---

# Data Binding

When displaying a map, you might also want to overlay some additional information. As we've previously seen (in the [Introduction]({%slug radmap-visualization-layer-introduction%}) help topic) we can define this information statically in XAML. However, it would be much more practical to use the `VisualizationLayer`'s data binding capabilities to dynamically load and display map markers.

The `VisualizationLayer` simulates functionality of the `ItemsControl` class so in order to display your map data dynamically you just have to treat the layer as a typical items control. This means you have to use its `ItemsSource` and `ItemTemplate` properties. You can also make a use of the `ItemTemplateSelector` property, in order to implement advanced visualization depending on the data item.        

When using a custom visual in the `ItemTemplate` of the layer, there are several attached properties that can be used to position and display the marker on its proper place:

* `MapLayer.Location`&mdash;Represents the latitude and the longitude of the map point.            

* `MapLayer.BaseZoomLevel`&mdash;Represents the zoom level, for which the element should have its scale transformation equal to 1.            

* `MapLayer.ZoomRange`&mdash;Represents the range of zoom levels for which the element should be visible.            
  
* `MapLayer.MinScale`&mdash;Represents minimum scale factor which will be applied to the framework element when it has `BaseZoomLevel` property set and we zoom out map control.            
  
* `MapLayer.MaxScale`&mdash;Represents maximum scale factor which will be applied to the framework element when it has `BaseZoomLevel` property set and we zoom in map control.            

In order to provide the needed data to the visualization layer, you have to create a collection of business objects, which represent the desired data. The following example shows how to do this.        

__Defining the item model__
```C#
	public class MapItem : INotifyPropertyChanged, INotifyLocationChanged
	{
		private double baseZoomLevel = double.NaN;
		private string caption = string.Empty;
		private Location location = Location.Empty;
		private ZoomRange zoomRange = ZoomRange.Empty;
	
		public MapItem(
			string caption, 
			Location location, 
			double baseZoomLevel, 
			ZoomRange zoomRange)
		{
			this.Caption = caption;
			this.Location = location;
			this.BaseZoomLevel = baseZoomLevel;
			this.ZoomRange = zoomRange;
		}
	
		public event EventHandler<LocationChangedEventArgs> LocationChanged;
	
		public event PropertyChangedEventHandler PropertyChanged;
	
		public double BaseZoomLevel
		{
			get
			{
				return this.baseZoomLevel;
			}
			set
			{
				this.baseZoomLevel = value;
				this.OnPropertyChanged("BaseZoomLevel");
			}
		}
	
		public string Caption
		{
			get
			{
				return this.caption;
			}
	
			set
			{
				this.caption = value;
				this.OnPropertyChanged("Caption");
			}
		}
	
		public Location Location
		{
			get
			{
				return this.location;
			}
	
			set
			{
				var oldLocation = this.location;
				this.location = value;
				this.OnPropertyChanged("Location");				
				this.OnLocationChanged(oldLocation, this.location);
			}
		}
	
		public ZoomRange ZoomRange
		{
			get
			{
				return this.zoomRange;
			}
	
			set
			{
				this.zoomRange = value;
				this.OnPropertyChanged("ZoomRange");
			}
		}
	
		private void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(
					this, 
					new PropertyChangedEventArgs(propertyName));
			}
		}
		
		public void OnLocationChanged(Location oldLocation, Location newLocation)
		{
			if (LocationChanged != null)
			{
				LocationChanged(this, new LocationChangedEventArgs(oldLocation, newLocation));
			}
		}
	}
```
```VB.NET
	Public Class MapItem
		Implements INotifyPropertyChanged, INotifyLocationChanged
		Private m_baseZoomLevel As Double = Double.NaN
		Private m_caption As String = String.Empty
		Private m_location As Location = Location.Empty
		Private m_zoomRange As ZoomRange = ZoomRange.Empty
	
		Public Sub New( _
		  caption As String, _
		  location As Location, _
		  baseZoomLevel As Double, _
		  zoomRange As ZoomRange)
			Me.Caption = caption
			Me.Location = location
			Me.BaseZoomLevel = baseZoomLevel
			Me.ZoomRange = zoomRange
		End Sub
	
		Public Event LocationChanged As EventHandler(Of LocationChangedEventArgs) _
			Implements INotifyLocationChanged.LocationChanged
			
		Public Event PropertyChanged As PropertyChangedEventHandler _
			Implements INotifyPropertyChanged.PropertyChanged
	
		Public Property BaseZoomLevel() As Double
			Get
				Return Me.m_baseZoomLevel
			End Get
	
			Set(value As Double)
				Me.m_baseZoomLevel = value
				Me.OnPropertyChanged("BaseZoomLevel")
			End Set
		End Property
	
		Public Property Caption() As String
			Get
				Return Me.m_caption
			End Get
	
			Set(value As String)
				Me.m_caption = value
				Me.OnPropertyChanged("Caption")
			End Set
		End Property
	
		Public Property Location() As Location
			Get
				Return Me.m_location
			End Get
	
			Set(value As Location)
				Dim oldLocation = Me.m_location
				Me.m_location = value
				Me.OnPropertyChanged("Location")
				Me.OnLocationChanged(oldLocation, Me.m_location)
			End Set
		End Property
	
		Public Property ZoomRange() As ZoomRange
			Get
				Return Me.m_zoomRange
			End Get
	
			Set(value As ZoomRange)
				Me.m_zoomRange = value
				Me.OnPropertyChanged("ZoomRange")
			End Set
		End Property
	
		Private Sub OnPropertyChanged(propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
		
		Public Sub OnLocationChanged(oldLocation As Location, newLocation As Location)
			RaiseEvent LocationChanged(Me, New LocationChangedEventArgs(oldLocation, newLocation))
		End Sub
	End Class
```

>important You can notice that the business class implements the `INotifyLocationChanged` interface. This is necessary in order to properly support runtime changes of the `Location` property.

__Defining the ItemTemplate and binding the attached properties__
```XAML
	<telerik:RadMap x:Name="radMap"
	                ZoomLevel="8"
	                Center="42.6957539183824, 23.3327663758679">
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider />
		</telerik:RadMap.Provider>
		<telerik:VisualizationLayer x:Name="visualizationLayer">
			<telerik:VisualizationLayer.ItemTemplate>
				<DataTemplate>
					<Grid telerik:MapLayer.Location="{Binding Location}"
	                      telerik:MapLayer.BaseZoomLevel="{Binding BaseZoomLevel}"
	                      telerik:MapLayer.ZoomRange="{Binding ZoomRange}"
	                      telerik:MapLayer.MaxScale="8"
	                      HorizontalAlignment="Center"
	                      VerticalAlignment="Center">
						<Ellipse x:Name="PART_Ellipse"
	                             Width="20"
	                             Height="20"
	                             Stroke="Red"
	                             StrokeThickness="3"
	                             Fill="Transparent">
							<ToolTipService.ToolTip>
								<ToolTip Content="{Binding Caption}" />
							</ToolTipService.ToolTip>
						</Ellipse>
					</Grid>
				</DataTemplate>
			</telerik:VisualizationLayer.ItemTemplate>
		</telerik:VisualizationLayer>
	</telerik:RadMap>
```

__Setting up the items source__
```C#
	public partial class Example: Window
	{
	    public Example()
	    {
	        InitializeComponent();
	        
	        this.visualizationLayer.ItemsSource = this.GetMapData();
	    }
	    
		private ObservableCollection<MapItem> GetMapData()
		{
			ObservableCollection<MapItem> data = new ObservableCollection<MapItem>();
			
			data.Add(
				new MapItem(
					"Sofia", 
					new Location(42.6957539183824, 23.3327663758679), 
					8, 
					new ZoomRange(5, 12)));
			
			data.Add(
				new MapItem(
					"Plovdiv", 
					new Location(42.1429369264591, 24.7498095849434), 
					8, 
					new ZoomRange(5, 12)));
			
			data.Add(
				new MapItem(
					"Burgas", 
					new Location(42.5131732087098, 27.4611884843576), 
					8, 
					new ZoomRange(5, 12)));
			
			data.Add(
				new MapItem(
					"Varna", 
					new Location(43.2073941930888, 27.9275176988258), 
					8, 
					new ZoomRange(5, 12)));			
			return data;
		}
	}
```
```VB.NET
	Public Partial Class Example
		Inherits Window
		Public Sub New()
			InitializeComponent()
	
			Me.visualizationLayer.ItemsSource = Me.GetMapData()
		End Sub
	
		Private Function GetMapData() As ObservableCollection(Of MapItem)
		
			Dim data As New ObservableCollection(Of MapItem)()
		
			data.Add( _
				New MapItem( _
					"Sofia", _
					New Location(42.6957539183824, 23.3327663758679), _
					8, _
					New ZoomRange(5, 12)))
		
			data.Add( _
				New MapItem( _
					"Plovdiv", _
					New Location(42.1429369264591, 24.7498095849434), _
					8, _
					New ZoomRange(5, 12)))
		
			data.Add( _
				New MapItem( _
					"Burgas", _
					New Location(42.5131732087098, 27.4611884843576), _
					8, _
					New ZoomRange(5, 12)))
		
			data.Add( _
				New MapItem( _
					"Varna", _
					New Location(43.2073941930888, 27.9275176988258), _
					8, _
					New ZoomRange(5, 12)))		
			Return data
		End Function
	End Class
```