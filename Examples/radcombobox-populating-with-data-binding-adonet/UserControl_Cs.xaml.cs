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

#region radcombobox-populating-with-data-binding-adonet_1
NorthwindEntities dbContext = new NorthwindEntities( new Uri( "Enter your service address here") );
#endregion

#region radcombobox-populating-with-data-binding-adonet_3
private void BeginRequest()
{
    DataServiceQuery<Products> query = dbContext.CreateQuery<Products>( "Products" );
    query.BeginExecute( RequestCompleted, query );
}
private void RequestCompleted( IAsyncResult asyncResult )
{
    DataServiceQuery<Products> query = asyncResult.AsyncState as DataServiceQuery<Products>;
    var products = query.EndExecute( asyncResult ).ToList();
    this.radComboBox.ItemsSource = products;
}
#endregion

#region radcombobox-populating-with-data-binding-adonet_5
this.radComboBox.ItemsSource = dbContext.Products.Execute();
#endregion

#region radcombobox-populating-with-data-binding-adonet_9
public class NorthwindDataSource
{
}
#endregion

#region radcombobox-populating-with-data-binding-adonet_11
public class NorthwindDataSource
{
    private static NorthwindEntities northwindEntity;
    public NorthwindDataSource()
    {
        northwindEntity = new NorthwindEntities( new Uri( "Enter your service address here") );
        this.Products = new ObservableCollection<Products>();
    }
    public ObservableCollection<Products> Products
    {
        get;
        set;
    }
}
#endregion

#region radcombobox-populating-with-data-binding-adonet_13
northwindEntity.Products.BeginExecute(
   ( IAsyncResult result ) => EntitiesLoaded<Products>( result, this.Products ),
   northwindEntity.Products );
#endregion

#region radcombobox-populating-with-data-binding-adonet_15
private static void EntitiesLoaded<T>( IAsyncResult result, Collection<T> entities )
{
   DataServiceQuery<T> query = result.AsyncState as DataServiceQuery<T>;
   foreach ( T entity in query.EndExecute( result ) )
   {
       entities.Add( entity );
   }
}
#endregion

#region radcombobox-populating-with-data-binding-adonet_17
foreach ( Products p in northwindEntity.Products.Execute() )
{
    this.Products.Add( p );
}
#endregion
}
