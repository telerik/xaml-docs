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

#region radmap_visualization_layer_data_binding_0
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

#region radmap_visualization_layer_data_binding_1
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
#endregion

}
