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

#region radchart-populating-with-data-binding-to-adonet-service_2
public class ProductDetail
    {
        public decimal? UnitPrice { get; set; }
        public ProductDetail(decimal? unitPrice)
        {
            this.UnitPrice = unitPrice;
        }
    }
#endregion

#region radchart-populating-with-data-binding-to-adonet-service_4
dbContext = new DataServiceContext  ( new Uri( "SampleAdoNetDataService.svc", UriKind.Relative ) );
#endregion

#region radchart-populating-with-data-binding-to-adonet-service_6
NorthwindEntities dbContext = new NorthwindEntities( new Uri( "Enter your service address here") );
#endregion

#region radchart-populating-with-data-binding-to-adonet-service_8
private void BeginRequest()
{
    DataServiceQuery<Products> query = dbContext.CreateQuery<Products>( "Products" );
    query.BeginExecute( RequestCompleted, query );
}
private void ProductsRequestCompleted(IAsyncResult asyncResult)
  {
    DataServiceQuery<Product> query = asyncResult.AsyncState as DataServiceQuery<Product>;
    products = query.EndExecute(asyncResult).ToList();
    List<ProductDetail> result = new List<ProductDetail>();
  foreach (Product p in products.Take(10))
   {
    result.Add(new ProductDetail(p.UnitPrice));
   }
   RadChart1.ItemsSource = result;
 }
#endregion

#region radchart-populating-with-data-binding-to-adonet-service_10
this.radChart.ItemsSource = dbContext.Products.Execute().Take(10).ToList();
#endregion

#region radchart-populating-with-data-binding-to-adonet-service_12
public class NorthwindDataSource
{
}
#endregion

#region radchart-populating-with-data-binding-to-adonet-service_14
public class NorthwindDataSource
{
    private static NorthwindEntities northwindEntity;
    public NorthwindDataSource()
    {
        northwindEntity = new NorthwindEntities( new Uri( "SampleAdoNetDataService.svc", UriKind.Relative ) );
        this.Products = new ObservableCollection<Products>();
    }
    public ObservableCollection<Products> Products
    {
        get;
        set;
    }
}
#endregion

#region radchart-populating-with-data-binding-to-adonet-service_16
var query = ( from p in northwindEntity.Products
              select p ).Take( 10 );
DataServiceQuery<Products> products = ( DataServiceQuery<Products> )query;
products.BeginExecute(
   ( IAsyncResult result ) => EntitiesLoaded<Products>( result, this.Products ), products );
foreach ( Products p in query.ToList() )
{
    this.Products.Add( p );
}
#endregion

#region radchart-populating-with-data-binding-to-adonet-service_18
private static void EntitiesLoaded<T>( IAsyncResult result, Collection<T> entities )
{
    DataServiceQuery<T> query = result.AsyncState as DataServiceQuery<T>;
    foreach ( T entity in query.EndExecute( result ) )
    {
        entities.Add( entity );
    }
}
#endregion
}
