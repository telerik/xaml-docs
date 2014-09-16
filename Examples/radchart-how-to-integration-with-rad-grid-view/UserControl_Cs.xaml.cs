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

#region radchart-how-to-integration-with-rad-grid-view_1
public class NorthwindDataSource
{
    private static NorthwindEntities northwindEntity;
    public NorthwindDataSource()
    {
        northwindEntity = new NorthwindEntities( new Uri( "http://localhost:52981/Services/SampleAdoNetDataService.svc/" ) );
        this.Products = new ObservableCollection<Products>();
        var query = from p in northwindEntity.Products
                    select p;
        DataServiceQuery<Products> products = ( DataServiceQuery<Products> )query;
        products.BeginExecute(
           ( IAsyncResult result ) => EntitiesLoaded<Products>( result, this.Products ), products );
    }
    public ObservableCollection<Products> Products
    {
        get;
        set;
    }
    private static void EntitiesLoaded<T>( IAsyncResult result, Collection<T> entities )
    {
        DataServiceQuery<T> query = result.AsyncState as DataServiceQuery<T>;
        foreach ( T entity in query.EndExecute( result ) )
        {
            entities.Add( entity );
        }
    }
}
#endregion

#region radchart-how-to-integration-with-rad-grid-view_2
public class NorthwindDataSource
{
    private static NorthwindEntities northwindEntity;
    public NorthwindDataSource()
    {
        northwindEntity = new NorthwindEntities( new Uri( "http://localhost:52981/Services/SampleAdoNetDataService.svc/" ) );
        this.Products = new ObservableCollection<Products>();
        foreach ( Products p in northwindEntity.Products.Execute() )
        {
            this.Products.Add( p );
        }
    }
    public ObservableCollection<Products> Products
    {
        get;
        set;
    }
}
#endregion

#region radchart-how-to-integration-with-rad-grid-view_8
private void radGridView_SelectionChanged( object sender, SelectionChangeEventArgs e )
{
    Collection<Products> selectedList = new Collection<Products>();
    // Get all selected Items
    foreach ( Products product in radGridView.SelectedItems )
        selectedList.Add( ( Products )item );
    CreateSeriesMappings( selectedList );
    SetChartItemsSource( selectedList );
}
#endregion

#region radchart-how-to-integration-with-rad-grid-view_10
private void CreateSeriesMappings( Collection<Products> invoicesList )
{
    radChart.SeriesMappings.Clear();
    SeriesMapping seriesMapping = new SeriesMapping();
    seriesMapping.SeriesDefinition = invoicesList.Count < 2 ? ( ISeriesDefinition )new BarSeriesDefinition() : ( ISeriesDefinition )new LineSeriesDefinition();
    seriesMapping.LegendLabel = "Product In Stock";
    ItemMapping itemMapping = new ItemMapping();
    itemMapping.DataPointMember = DataPointMember.YValue;
    itemMapping.FieldName = "UnitsInStock";
    seriesMapping.ItemMappings.Add( itemMapping );
    SeriesMapping seriesMapping1 = new SeriesMapping();
    seriesMapping1.SeriesDefinition = invoicesList.Count < 2 ? ( ISeriesDefinition )new BarSeriesDefinition() : ( ISeriesDefinition )new LineSeriesDefinition();
    seriesMapping1.LegendLabel = "Product Price";
    ItemMapping itemMapping1 = new ItemMapping();
    itemMapping1.DataPointMember = DataPointMember.YValue;
    itemMapping1.FieldName = "UnitPrice";
    seriesMapping1.ItemMappings.Add( itemMapping1 );
    radChart.SeriesMappings.Add( seriesMapping );
    radChart.SeriesMappings.Add( seriesMapping1 );
}
#endregion

#region radchart-how-to-integration-with-rad-grid-view_12
private void SetChartItemsSource( Collection<Products> invoicesList )
{
    radChart.ItemsSource = invoicesList;
}
#endregion
}
