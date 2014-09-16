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

#region radmap_visualization_layer_property_accessor_0
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
#endregion

#region radmap_visualization_layer_property_accessor_1
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
#endregion

#region radmap_visualization_layer_property_accessor_2
public Example()
{
	InitializeComponent();

	this.visualizationLayer.PropertyAccessor = new CustomPropertyAccessor();
	this.visualizationLayer.UseDefaultPropertyAccessor = false;
	this.visualizationLayer.ItemsSource = this.GetMapData();
}
#endregion

}
