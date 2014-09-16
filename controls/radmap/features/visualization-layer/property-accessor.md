---
title: Property Accessor
page_title: Property Accessor
description: Property Accessor
slug: radmap-visualization-layer-property-accessor
tags: property,accessor
publish: True
position: 2
---

# Property Accessor



As it is described in the [Data Binding]({%slug radmap-visualization-layer-data-binding%})
        article the Visualization Layer uses attached properties to position
        and display markers on their proper places. But evaluating data
        bindings and accessing values of properties from UI elements takes
        time and slows-down the visualization engine. The Visualization
        Layer provides a way to speed up accessing of the map-related
        properties from the data item without involving the UI engine.
      

You can do it using the __PropertyAccessor__ property
        of the VisualizationLayer object. There are 2 ways you can use it:
      

1. Use default property accessor.
          

1. Create your own class which implements the __IMapPropertyAccessor__ interface.
          

>importantEven if you use property accessor feature you still should bind the
          __MapLayer.Location__ property in the Data Template.
        

## Using the default property accessor

The visualization engine a provides default property accessor which
          uses heuristics to get map-related properties from the data item.
        

The default property accessor uses the following set of rules:
        

1. The first property which has __Telerik.Windows.Controls.Map.Location__ type will be
              considered as geographical position of the item.
            

1. The first property which has __Telerik.Windows.Controls.Map.ZoomRange__ type will be
              considered as zoom range of the item.
            

1. The first property which has __Telerik.Windows.Controls.HotSpot__ type will be
              considered as hotspot definition of the item.
            

1. The property which is named __BaseZoomLevel__ and is of type double type will be
              considered as base zoom level definition.
            

1. The property which is named __MaxScale__ and is of type double type will be
              considered as max scale of the item.
            

1. The property which is named __MinScale__ and is of type double type will be
              considered as min scale of the item.
            

1. The property which is named __ZIndex__ and is of integer type will be considered as the Z-Index of the item.
            

If your business class satisfies these requirements you can use the
          default property accessor without any additional set-up. For example:
        

#### __C#__

{{region radmap_visualization_layer_property_accessor_0}}
	public class MapItem : INotifyPropertyChanged
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
				this.location = value;
				this.OnPropertyChanged("Location");
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
	}
	{{endregion}}



#### __VB.NET__

{{region radmap_visualization_layer_property_accessor_0}}
	Public Class MapItem
		Implements INotifyPropertyChanged
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
				Me.m_location = value
				Me.OnPropertyChanged("Location")
			End Set
		End Property
		
		Public Function GetZIndex(item As Object) As Integer _
			Implements IMapPropertyAccessor.GetZIndex
			Dim value As Integer = Integer.MinValue
	
			Return value
		End Function
	
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
			RaiseEvent PropertyChanged(Me, _
			  New PropertyChangedEventArgs(propertyName))
		End Sub
	End Class
	{{endregion}}



If your data item is represented by this class then default property accessor can be
          used. It will use properties as following:
        

1. The Location property will be used as geographical position of the item.
            

1. The BaseZoomLevel property will be used as base zoom level definition.
            

1. The ZoomRange property will be used as zoom range definition.
            

Since this class has not __MaxScale__, __MinScale__
          and __ZIndex__ properties then visualization engine
          will use default values for them.
        

## Create own class which implements IMapPropertyAccessor interface

Sometimes the default property accessor is not applicable because of the
          data source. For example, your data source items (comming from a WCF Data Service or an Entity
          Framework model) could have different data types or use a different naming convention.
          In this case you can implement your own property accessor.
        

First you should create a new class which implements the
          __IMapPropertyAccessor__ interface.
          For example:
        

#### __C#__

{{region radmap_visualization_layer_property_accessor_1}}
	public class CustomPropertyAccessor : IMapPropertyAccessor
	{
		public double GetDouble(object item, DataMember dataMember)
		{
			double value = double.NaN;
	
			MapItem mapItem = item as MapItem;
			if (mapItem != null)
			{
				switch (dataMember)
				{
					case DataMember.MaxScale:
						break;
	
					case DataMember.MinScale:
						break;
	
					case DataMember.ZoomLevel:
						// Base zoom level
						value = mapItem.BaseZoomLevel;
						break;
				}
			}
	
			return value;
		}
	
		public HotSpot GetHotspot(object item)
		{
			return null;
		}
	
		public Location GetLocation(object item)
		{
			Location location = Location.Empty;
	
			MapItem mapItem = item as MapItem;
			if (mapItem != null)
			{
				location = mapItem.Location;
			}
	
			return location;
		}
		
		public int GetZIndex(object item)
		{
			int value = int.MinValue;
			return value;
		}
	
		public ZoomRange GetZoomRange(object item)
		{
			ZoomRange zoomRange = ZoomRange.Empty;
	
			MapItem mapItem = item as MapItem;
			if (mapItem != null)
			{
				zoomRange = mapItem.ZoomRange;
			}
	
			return zoomRange;
		}
	}
	{{endregion}}



#### __VB.NET__

{{region radmap_visualization_layer_property_accessor_1}}
	Public Class CustomPropertyAccessor
		Implements IMapPropertyAccessor
		Public Function GetDouble(item As Object, member As DataMember) As Double _
			Implements IMapPropertyAccessor.GetDouble
			Dim value As Double = Double.NaN
	
			Dim mapItem As MapItem = TryCast(item, MapItem)
			If mapItem IsNot Nothing Then
				Select Case member
					Case DataMember.MaxScale
						Exit Select
	
					Case DataMember.MinScale
						Exit Select
	
					Case DataMember.ZoomLevel
						' Base zoom level
						value = mapItem.BaseZoomLevel
						Exit Select
				End Select
			End If
	
			Return value
		End Function
	
		Public Function GetHotspot(item As Object) As HotSpot _
			Implements IMapPropertyAccessor.GetHotspot
			Return Nothing
		End Function
	
		Public Function GetLocation(item As Object) As Location _
			Implements IMapPropertyAccessor.GetLocation
			Dim loc As Location = Location.Empty
	
			Dim mapItem As MapItem = TryCast(item, MapItem)
			If mapItem IsNot Nothing Then
				loc = mapItem.Location
			End If
	
			Return loc
		End Function
	
		Public Function GetZoomRange(item As Object) As ZoomRange _
			Implements IMapPropertyAccessor.GetZoomRange
			Dim range As ZoomRange = ZoomRange.Empty
	
			Dim mapItem As MapItem = TryCast(item, MapItem)
			If mapItem IsNot Nothing Then
				range = mapItem.ZoomRange
			End If
	
			Return range
		End Function
	End Class
	{{endregion}}



Now you should assign to the __PropertyAccessor__ property of the
          VisualizationLayer to an instance of the CustomPropertyAccessor type and set the
          __UseDefaultPropertyAccessor__ property to false:
        

#### __C#__

{{region radmap_visualization_layer_property_accessor_2}}
	public Example()
	{
		InitializeComponent();
	
		this.visualizationLayer.PropertyAccessor = new CustomPropertyAccessor();
		this.visualizationLayer.UseDefaultPropertyAccessor = false;
		this.visualizationLayer.ItemsSource = this.GetMapData();
	}
	{{endregion}}



#### __VB.NET__

{{region radmap_visualization_layer_property_accessor_2}}
	Public Sub New()
		InitializeComponent()
	
		Me.visualizationLayer.PropertyAccessor = New CustomPropertyAccessor()
		Me.visualizationLayer.UseDefaultPropertyAccessor = False
		Me.visualizationLayer.ItemsSource = Me.GetMapData()
	End Sub
	{{endregion}}



# See Also
