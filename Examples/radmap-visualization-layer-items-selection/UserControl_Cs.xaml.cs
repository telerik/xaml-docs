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

#region radmap-visualization-layer-items-selection_1
public class MapItem : INotifyPropertyChanged
{
	private static SolidColorBrush RegularBrush = new SolidColorBrush(Colors.Green);
	private static SolidColorBrush SelectedBrush = new SolidColorBrush(Colors.Red);

	private string caption = string.Empty;
	private Location location = Location.Empty;
	private bool isSelected = false;
	private SolidColorBrush background = RegularBrush;

	public MapItem(
		string caption,
		Location location)
	{
		this.Caption = caption;
		this.Location = location;
	}

	public event PropertyChangedEventHandler PropertyChanged;

	public SolidColorBrush Background
	{
		get
		{
			return this.background;
		}

		set
		{
			this.background = value;
			this.OnPropertyChanged("Background");
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

	public bool IsSelected
	{
		get
		{
			return this.isSelected;
		}

		set
		{
			this.isSelected = value;
			this.Background = this.isSelected ? SelectedBrush : RegularBrush;
			this.OnPropertyChanged("IsSelected");
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
#region radmap-visualization-layer-items-selection_4
public partial class SelectLocations : UserControl
{
    private Random rnd = new Random();

    public SelectLocations()
    {
        InitializeComponent();

        LocationRect usa = new LocationRect(
            new Location(50, -120),
            new Location(30, -70));
        this.visualizationLayer.ItemsSource = this.GeneratePoiCollection(50, usa);
    }

    private void GenerateMapItem(
        ObservableCollection<MapItem> data,
        Location location,
        int index)
    {
        MapItem poi = new MapItem(
            string.Format("Item {0}", index),
            location);

        data.Add(poi);
    }

    private ObservableCollection<MapItem> GeneratePoiCollection(int count, LocationRect region)
    {
        ObservableCollection<MapItem> data = new ObservableCollection<MapItem>();

        for (int i = 0; i < count; i++)
        {
            Location baseLocation = new Location(
                    region.North - rnd.NextDouble() * egion.GeoSize.Height,
                    region.West + rnd.NextDouble() * region.GeoSize.Width);
            this.GenerateMapItem(data, baseLocation, i);
        }

        return data;
    }

    private void LayerSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.RemovedItems != null)
        {
            foreach (MapItem item in e.RemovedItems)
            {
                item.IsSelected = false;
            }
        }

        if (e.AddedItems != null)
        {
            foreach (MapItem item in e.AddedItems)
            {
                item.IsSelected = true;
            }
        }
    }
}
    #endregion

    
#region radmap-visualization-layer-items-selection_8
    private void ShowSelectedItems(object sender, RoutedEventArgs e)
{
	string condition = this.filter.Text.Trim();
double minSqkm;
if (double.TryParse(condition, out minSqkm))
{
IEnumerable<object> itemsToSelect = from MapShapeData item in this.visualizationLayer.Items
where ((double)item.ExtendedData.GetValue("SQKM")) > minSqkm * 1000d
select item;
this.visualizationLayer.Select(itemsToSelect, true);
}
}

private void ReverseSelection(object sender, RoutedEventArgs e)
{
this.visualizationLayer.ReverseSelection(this.visualizationLayer.Items);
}
    #endregion

}
