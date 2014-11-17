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

#region radmap-features-search_0
BingSearchProvider searchProvider;
MapItemsCollection itemCollection = new MapItemsCollection();
public Sample()
{
    InitializeComponent();
    this.searchProvider = new BingSearchProvider();
    searchProvider.ApplicationId = "key";
    searchProvider.MapControl = this.radMap;
    searchProvider.SearchCompleted += this.searchProvider_SearchCompleted;

    this.itemsLayer.ItemsSource = this.itemCollection;
}
#endregion

#region radmap-features-search_2
private void SearchHandler(object sender, RoutedEventArgs e)
{
    string query = this.SearchCondition.Text;

    if (!string.IsNullOrEmpty(query))
    {
        SearchRequest request = new SearchRequest();
        request.Culture = new System.Globalization.CultureInfo("en-US");
        request.Query = query;

        this.searchProvider.SearchAsync(request);
    }
}
#endregion

#region radmap-features-search_4
private void Provider_SearchCompleted(object sender, SearchCompletedEventArgs args)
{
    this.itemCollection.Clear();
    SearchResultCollection results = args.Response.ResultSets.First().Results;
    if (results.Count > 0)
    {
        foreach (SearchResultBase result in results)
        {
            MapItem item = new MapItem()
            {
                Title = result.Name,
                Location = result.LocationData.Locations[0]
            };
            this.itemCollection.Add(item);
        }
        this.radMap.SetView(args.Response.ResultSets[0].SearchRegion.GeocodeLocation.BestView);
    }
}
#endregion

#region radmap-features-search_6
private void Provider_SearchCompleted(object sender, SearchCompletedEventArgs args)
{

	this.itemCollection.Clear();
	SearchResultCollection results = args.Response.ResultSets.First().Results;
    SearchRegion region = args.Response.ResultSets.First().SearchRegion;
	if (results.Count > 0)
	{
		this.radMap.SetView(region.GeocodeLocation.BestView);
        foreach (SearchResultBase result in args.Response.ResultSets[0].Results)
        {
            MapItem item = new MapItem()
            {
                Title = result.Name,
                Location = result.LocationData.Locations[0]
            };
            this.itemCollection.Add(item);
        }
	}
	else
	{
		if (region != null)
		{
			this.radMap.SetView(region.GeocodeLocation.BestView);
			if (region.GeocodeLocation.Address != null && region.GeocodeLocation.Locations.Count > 0)
			{
				foreach (Location location in region.GeocodeLocation.Locations)
				{
					MapItem item = new MapItem();
					
					item.Location = location;
					this.itemCollection.Add(item);
				}

				// Set the bounding area
				if (args.Response.ResultSets[0].SearchRegion.BoundingArea != null)
				{
					MapShapeData boundingArea = args.Response.ResultSets[0].SearchRegion.BoundingAreaData;
					boundingArea.ShapeFill = new MapShapeFill()
					{
						Stroke = new SolidColorBrush(Colors.Red),
						StrokeThickness = 1
					};
					this.regionLayer.Items.Add(boundingArea);
				}
			}
		}
	}
}
#endregion

#region radmap-features-search_8
private void searchProvider_SearchCompleted( object sender, SearchCompletedEventArgs e )
{
    this.itemCollection.Clear();
    SearchResultCollection results = args.Response.ResultSets.First().Results;
    SearchRegion region = args.Response.ResultSets.First().SearchRegion;
    if (results.Count > 0)
    {
        //code that runs when there are available results.
    }
    else
    {  
        if (region != null)
        {
            this.radMap.SetView(region.GeocodeLocation.BestView);
            if (region.GeocodeLocation.Address != null && region.GeocodeLocation.Locations.Count > 0)
            {
                foreach (Location location in region.GeocodeLocation.Locations)
                {
                    MapItem item = new MapItem();                            
                    item.Location = location;
                    this.itemCollection.Add(item);
                }
            }
        }
    }
}
#endregion

#region radmap-features-search_10
private void searchProvider_SearchCompleted( object sender, SearchCompletedEventArgs e )
{
    SearchRegionCollection alternateRegions = e.Response.ResultSets.First().AlternateSearchRegions;
    if ( alternateRegions.Count > 0 )
    {
        foreach ( SearchRegion region in alternateRegions )
        {
           // implement AlternateSearchRegions logic here.
        }
    }
}
#endregion
}
