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

#region radmap_visualization_layer_reading_map_shapes_0
public partial class EsriFileReader : UserControl
{
	public EsriFileReader()
	{
		InitializeComponent();

		this.Loaded += this.ExampleLoaded;
	}

	private void ExampleLoaded(object sender, RoutedEventArgs e)
	{
		this.busyIndicator.IsIndeterminate = false;
		this.busyIndicator.IsBusy = true;
		this.mapShapeDataReader.Source =  new Uri("/TestMapFeatures;component/Resources/GeoData/zt06_d00.shp", UriKind.Relative);
	}

	private void OnProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
	{
		this.busyIndicator.ProgressValue = e.ProgressPercentage;
		if (e.ProgressPercentage >= 100)
		{
			this.busyIndicator.IsIndeterminate = true;
			this.busyIndicator.BusyContent = "Refresh layer";
		}
	}

	private void OnReadShapeDataCompleted(object sender, Telerik.Windows.Controls.Map.ReadShapeDataCompletedEventArgs e)
	{
		if (this.busyIndicator != null)
		{
			this.busyIndicator.IsBusy = false;
		}
	}
}
#endregion

#region radmap_visualization_layer_reading_map_shapes_1
this.visualizationLayer.Reader.ToolTipFormat = "CNTRY_NAME";
#endregion

#region radmap_visualization_layer_reading_map_shapes_2
this.visualizationLayer.Reader.ToolTipFormat = "{SQKM|F2}";
#endregion

#region radmap_visualization_layer_reading_map_shapes_3
this.visualizationLayer.Reader.ToolTipFormat = "{CNTRY_NAME} - {SQKM|#,#.0} sq. km.";
#endregion

#region radmap_visualization_layer_reading_map_shapes_4
this.mapShapeDataReader.SourceCollection.Add(
	new AsyncReaderSource()
	{
		Source = new Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_base.shp", UriKind.RelativeOrAbsolute)
	});
this.mapShapeDataReader.SourceCollection.Add(
	new AsyncReaderSource()
	{
		Source = new Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_Corridors.shp", UriKind.RelativeOrAbsolute)
	});
this.mapShapeDataReader.SourceCollection.Add(
	new AsyncReaderSource()
	{
		Source = new Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_ServiceRooms.shp", UriKind.RelativeOrAbsolute)
	});
this.mapShapeDataReader.SourceCollection.Add(
	new AsyncReaderSource()
	{
		Source = new Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_LiftsAndLadders.shp", UriKind.RelativeOrAbsolute)
	});
this.mapShapeDataReader.SourceCollection.Add(
	new AsyncReaderSource()
	{
		Source = new Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_Rooms.shp", UriKind.RelativeOrAbsolute)
	});

this.mapShapeDataReader.ReadAsync();
#endregion

#region radmap_visualization_layer_reading_map_shapes_5

#endregion

}
