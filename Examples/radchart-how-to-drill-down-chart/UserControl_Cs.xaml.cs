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

#region radchart-how-to-drill-down-chart_4
public class NorthwindDataSource
{
    private static NorthwindEntities northwindEntity;
    public NorthwindDataSource()
    {
        northwindEntity = new NorthwindEntities( new Uri( "http://localhost:52981/Services/SampleAdoNetDataService.svc/" ) );
        this.Products = new ObservableCollection<Products>();
    }
    public ObservableCollection<Products> Products
    {
        get;
        set;
    }
    public ObservableCollection<Order_Details> OrderDetails
    {
        get;
        set;
    }
}
#endregion

#region radchart-how-to-drill-down-chart_6
public NorthwindDataSource()
{
    northwindEntity = new NorthwindEntities( new Uri( "http://localhost:52981/Services/SampleAdoNetDataService.svc/" ) );
    this.Products = new ObservableCollection<Products>();
    var query = ( from p in northwindEntity.Products
                  select p ).Take( 8 );
    DataServiceQuery<Products> products = ( DataServiceQuery<Products> )query;
    products.BeginExecute(
       ( IAsyncResult result ) => EntitiesLoaded<Products>( result, this.Products ), products );
}
#endregion

#region radchart-how-to-drill-down-chart_7
public NorthwindDataSource()
{
    northwindEntity = new NorthwindEntities( new Uri( "http://localhost:52981/Services/SampleAdoNetDataService.svc/" ) );
    this.Products = new ObservableCollection<Products>();
    foreach ( Products p in northwindEntity.Products.Execute().Take( 8 ) )
    {
        this.Products.Add( p );
    }
}
#endregion

#region radchart-how-to-drill-down-chart_10
private static void EntitiesLoaded<T>( IAsyncResult result, Collection<T> entities )
{
    DataServiceQuery<T> query = result.AsyncState as DataServiceQuery<T>;
    foreach ( T entity in query.EndExecute( result ) )
    {
        entities.Add( entity );
    }
}
#endregion

#region radchart-how-to-drill-down-chart_12
public static void BeginLoadingOrderDetails( Products p, int rowCount )
{
    var query = ( from od in northwindEntity.Order_Details.Expand( "Orders" )
                 where od.ProductID == p.ProductID
                 select od );
    if ( rowCount > -1 )
        query = query.Take( rowCount );                                
    DataServiceQuery<Order_Details> orderDetails = ( DataServiceQuery<Order_Details> )query;
    orderDetails.BeginExecute(
        ( IAsyncResult result ) => EntitiesLoaded<Order_Details>( result, p.Order_Details ), orderDetails );
}
#endregion

#region radchart-how-to-drill-down-chart_13
public static void LoadOrderDetails( Products p, int rowCount )
{
    var query = ( from od in northwindEntity.Order_Details.Expand( "Orders" )
                  where od.ProductID == p.ProductID
                  select od );
    if ( rowCount > -1 )
        query = query.Take( rowCount );
    foreach ( Order_Details orderDetail in query.ToList() )
    {
        p.Order_Details.Add( orderDetail );
    }
}
#endregion

#region radchart-how-to-drill-down-chart_18
private void ChartArea_ItemToolTipOpening( ItemToolTip2D tooltip, ItemToolTipEventArgs e )
{
    Products p = e.DataPoint.DataItem as Products;
    p.Order_Details = new ObservableCollection<Order_Details>();
    NorthwindDataSource.BeginLoadingOrderDetails( p, 6 );
    DrillDownChartToolTip toolTipControl = new DrillDownChartToolTip();
    toolTipControl.DataContext = p.Order_Details;
    tooltip.Content = toolTipControl;
}
#endregion

#region radchart-how-to-drill-down-chart_19
private void ChartArea_ItemToolTipOpening( ItemToolTip2D tooltip, ItemToolTipEventArgs e )
{
    Products p = e.DataPoint.DataItem as Products;
    p.Order_Details = new ObservableCollection<Order_Details>();
    NorthwindDataSource.LoadOrderDetails( p, 6 );
    DrillDownChartToolTip toolTipControl = new DrillDownChartToolTip();
    toolTipControl.DataContext = p.Order_Details;
    tooltip.Content = toolTipControl;
}
#endregion

#region radchart-how-to-drill-down-chart_22
Products p = e.DataPoint.DataItem as Products;
#endregion

#region radchart-how-to-drill-down-chart_26
private void ChartArea_ItemClick( object sender, ChartItemClickEventArgs e )
{
    // Get the product and load all order details
    Products selectedItem = ( e.DataPoint.DataItem as Products );
    selectedItem.Order_Details = new ObservableCollection<Order_Details>();
    radChart.ItemsSource = selectedItem.Order_Details;
    NorthwindDataSource.BeginLoadingOrderDetails( selectedItem, -1 );
    // Change the chart title
    radChart.DefaultView.ChartTitle.Content = "Financial Report";
    radChart.SeriesMappings.Clear();
    // Change the Item mapping
    SeriesMapping newSeriesMapping = new SeriesMapping();
    newSeriesMapping.LegendLabel = "Quantity";
    ItemMapping newItemMapping = new ItemMapping();
    newItemMapping.FieldName = "Quantity";
    newItemMapping.DataPointMember = DataPointMember.YValue;
    newSeriesMapping.ItemMappings.Add( newItemMapping );
    radChart.SeriesMappings.Add( newSeriesMapping );
}
#endregion

#region radchart-how-to-drill-down-chart_27
private void ChartArea_ItemClick( object sender, ChartItemClickEventArgs e )
{
    // Get the product and load all order details
    Products selectedItem = ( e.DataPoint.DataItem as Products );
    selectedItem.Order_Details = new ObservableCollection<Order_Details>();
    radChart.ItemsSource = selectedItem.Order_Details;
    NorthwindDataSource.LoadOrderDetails( selectedItem, -1 );
    // Change the chart title
    radChart.DefaultView.ChartTitle.Content = "Financial Report";
    radChart.SeriesMappings.Clear();
    // Change the Item mapping
    SeriesMapping newSeriesMapping = new SeriesMapping();
    newSeriesMapping.LegendLabel = "Quantity";
    ItemMapping newItemMapping = new ItemMapping();
    newItemMapping.FieldName = "Quantity";
    newItemMapping.DataPointMember = DataPointMember.YValue;
    newSeriesMapping.ItemMappings.Add( newItemMapping );
    radChart.SeriesMappings.Add( newSeriesMapping );
}
#endregion
}
