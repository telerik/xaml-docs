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

#region gridview-loading-data-from-adonet-services_1
NorthwindEntities dbContext = new NorthwindEntities( new Uri( "GridViewDataService.svc", UriKind.Relative ) );
#endregion

#region gridview-loading-data-from-adonet-services_2
NorthwindEntities dbContext = new NorthwindEntities( new Uri( "Enter your service address here") );
#endregion

#region gridview-loading-data-from-adonet-services_5
private void BeginRequest()
{
    DataServiceQuery<Customers> query = dbContext.CreateQuery<Customers>( "Customers" );
    query.BeginExecute( RequestCompleted, query );
}
private void RequestCompleted( IAsyncResult asyncResult )
{
    DataServiceQuery<Customers> query = asyncResult.AsyncState as DataServiceQuery<Customers>;
    var customers = query.EndExecute( asyncResult ).ToList();
    this.radGridView.ItemsSource = customers;
}
#endregion

#region gridview-loading-data-from-adonet-services_7
this.radGridView.ItemsSource = dbContext.Customers.Execute().ToList();
#endregion

#region gridview-loading-data-from-adonet-services_9
public class NorthwindDataSource
{
}
#endregion

#region gridview-loading-data-from-adonet-services_11
public class NorthwindDataSource
{
    private static NorthwindEntities northwindEntity;
    public NorthwindDataSource()
    {
        northwindEntity = new NorthwindEntities( new Uri( "GridViewDataService.svc", UriKind.Relative ) );
        this.Customers = new ObservableCollection<Customers>();
    }
    public ObservableCollection<Customers> Customers
    {
        get;
        set;
    }
}
#endregion

#region gridview-loading-data-from-adonet-services_13
public class NorthwindDataSource
{
    private static NorthwindEntities northwindEntity;
    public NorthwindDataSource()
    {
        northwindEntity = new NorthwindEntities( new Uri( "Enter your service address here"));
        this.Customers = new ObservableCollection<Customers>();
    }
    public ObservableCollection<Customers> Customers
    {
        get;
        set;
    }
}
#endregion

#region gridview-loading-data-from-adonet-services_15
northwindEntity.Customers.BeginExecute(
    ( IAsyncResult result ) => EntitiesLoaded<Customers>( result, this.Customers ),
    northwindEntity.Customers );
#endregion

#region gridview-loading-data-from-adonet-services_16
foreach ( Customers c in northwindEntity.Customers.Execute() )
{
    this.Customers.Add( c );
}
#endregion

#region gridview-loading-data-from-adonet-services_19
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
