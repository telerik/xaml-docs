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

#region radmap-features-data-binding_1
public DataBindingSample()
{
    InitializeComponent();
    this.radMap.InitializeCompleted += radMap_InitializeCompleted;            
}
void radMap_InitializeCompleted( object sender, EventArgs e )
{
    this.informationLayer.ItemsSource = this.GetMapData();
}
#endregion

#region radmap-features-data-binding_4
public class MapItem
{
    public MapItem( string caption, Location location, double baseZoomLevel, ZoomRange zoomRange )
    {
        this.Caption = caption;
        this.Location = location;
        this.BaseZoomLevel = baseZoomLevel;
        this.ZoomRange = zoomRange;
    }
    public string Caption
    {
        get;
        set;
    }
    public Location Location
    {
        get;
        set;
    }
    public double BaseZoomLevel
    {
        get;
        set;
    }
    public ZoomRange ZoomRange
    {
        get;
        set;
    }
}
#endregion

#region radmap-features-data-binding_6
private ObservableCollection<MapItem> GetMapData()
{
    ObservableCollection<MapItem> data = new ObservableCollection<MapItem>();
    data.Add( new MapItem( "Sofia", new Location( 42.6957539183824, 23.3327663758679 ), 5, new ZoomRange( 5, 12 ) ) );
    data.Add( new MapItem( "Plovdiv", new Location( 42.1429369264591, 24.7498095849434 ), 5, new ZoomRange( 5, 12 ) ) );
    data.Add( new MapItem( "Burgas", new Location( 42.5131732087098, 27.4611884843576 ), 5, new ZoomRange( 5, 12 ) ) );
    data.Add( new MapItem( "Varna", new Location( 43.2073941930888, 27.9275176988258 ), 5, new ZoomRange( 5, 12 ) ) );
    return data;
}
#endregion
}
