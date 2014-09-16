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

#region radmap-features-virtualization-layer_1
public class MapVirtualizationSource : IMapVirtualizationSource
{
    static readonly Location bulgariaLocation = new Location(42.7669999748468, 25.2819999307394);
    static readonly Location sofiaLocation = new Location(42.6957539183824, 23.3327663758679);

    Ellipse BulgariaEllipse { get; set; }
    Ellipse SofiaEllipse { get; set; }

    public MapVirtualizationSource()
    {
        //Exectued ot UI thread
        BulgariaEllipse = new Ellipse();
        BulgariaEllipse.Width = 15;
        BulgariaEllipse.Height = 15;
        BulgariaEllipse.Fill = new SolidColorBrush(Colors.Red);
        BulgariaEllipse.SetValue(MapLayer.LocationProperty, bulgariaLocation);
        MapLayer.SetHotSpot(BulgariaEllipse, new HotSpot { X = 0.5, Y = 0.5 });
        ToolTipService.SetToolTip(BulgariaEllipse, "Bulgaria");

        SofiaEllipse = new Ellipse();
        SofiaEllipse.Width = 20;
        SofiaEllipse.Height = 20;
        SofiaEllipse.Stroke = new SolidColorBrush(Colors.Red);
        SofiaEllipse.Fill = new SolidColorBrush(Colors.Transparent);
        SofiaEllipse.StrokeThickness = 3;
        SofiaEllipse.SetValue(MapLayer.LocationProperty, sofiaLocation);
        MapLayer.SetHotSpot(SofiaEllipse, new HotSpot { X = 0.5, Y = 0.5 });
        ToolTipService.SetToolTip(SofiaEllipse, "Sofia");
    }

    public void BackgroundItemsRequest(object sender, BackgroundItemsRequestEventArgs e)
    {
        LocationRect currentRegion = new LocationRect(e.UpperLeft, e.LowerRight);

        List<object> visibleItems = new List<object>();

        if (currentRegion.Contains(bulgariaLocation))
        {
            if (e.MinZoom == 3)
            {
                visibleItems.Add(this.BulgariaEllipse);
            }
            else if (e.MinZoom == 6)
            {
                visibleItems.Add(this.SofiaEllipse);
            }
        }
        e.CompleteItemsRequest(visibleItems);
    }
}
#endregion

#region radmap-features-virtualization-layer_3
public MainWindow()
{
    InitializeComponent();
    this.radMap.Provider = new OpenStreetMapProvider();
    this.virtualizationLayer.VirtualizationSource = new MapVirtualizationSource();
}
#endregion
}
