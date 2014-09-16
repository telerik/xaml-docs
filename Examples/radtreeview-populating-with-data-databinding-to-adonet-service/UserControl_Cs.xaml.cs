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

#region radtreeview-populating-with-data-databinding-to-adonet-service_1
public class NorthwindDataSource
{
}
#endregion

#region radtreeview-populating-with-data-databinding-to-adonet-service_3
private NorthwindEntities northwindEntity;
public NorthwindDataSource()
{
    this.northwindEntity = new NorthwindEntities( new Uri( "Enter your service address here" ) );
    this.Categories = new ObservableCollection<Categories>();
}
public ObservableCollection<Categories> Categories
{
    get;
    set;
}
#endregion

#region radtreeview-populating-with-data-databinding-to-adonet-service_5
northwindEntity.Categories.BeginExecute(
    ( IAsyncResult result ) => EntitiesLoaded<Categories>( result, this.Categories ),
    northwindEntity.Categories );
#endregion

#region radtreeview-populating-with-data-databinding-to-adonet-service_6
foreach ( Categories c in northwindEntity.Categories.Execute() )
{
    this.Categories.Add( c );
}
#endregion

#region radtreeview-populating-with-data-databinding-to-adonet-service_9
private static void EntitiesLoaded<T>( IAsyncResult result, Collection<T> entities )
{
    DataServiceQuery<T> query = result.AsyncState as DataServiceQuery<T>;
    foreach ( T entity in query.EndExecute( result ) )
    {
        entities.Add( entity );
    }
}
#endregion

#region radtreeview-populating-with-data-databinding-to-adonet-service_15
public static void BeginLoadingProducts( Categories category )
{
    DataServiceQuery<Products> categoryProducts = northwindEntity
        .CreateQuery<Products>( string.Format( "Categories({0})/Products", category.CategoryID ) )
        .Expand( "Suppliers" )
        .Expand( "Categories" );
    categoryProducts.BeginExecute(
        ( IAsyncResult result ) => EntitiesLoaded<Products>( result, category.Products ),
        categoryProducts );
}
#endregion

#region radtreeview-populating-with-data-databinding-to-adonet-service_16
public static void LoadProducts( Categories category )
{
    DataServiceQuery<Products> categoryProducts = northwindEntity
        .CreateQuery<Products>( string.Format( "Categories({0})/Products", category.CategoryID ) )
        .Expand( "Suppliers" )
        .Expand( "Categories" );
    category.Products = new ObservableCollection<Products>();
    foreach ( Products p in categoryProducts.Execute() )
    {
        category.Products.Add( p );
    }
}
#endregion

#region radtreeview-populating-with-data-databinding-to-adonet-service_19
private void radTreeView_LoadOnDemand( object sender, Telerik.Windows.RadRoutedEventArgs e )
{
    RadTreeViewItem item = e.OriginalSource as RadTreeViewItem;
    Categories category = item.Item as Categories;
    if ( category != null )
    {
        NorthwindDataSource.BeginLoadingProducts( category );
    }
    else
    {
        item.IsLoadOnDemandEnabled = false;
    }
}
#endregion

#region radtreeview-populating-with-data-databinding-to-adonet-service_20
private void radTreeView_LoadOnDemand( object sender, Telerik.Windows.RadRoutedEventArgs e )
{
    RadTreeViewItem item = e.OriginalSource as RadTreeViewItem;
    Categories category = item.Item as Categories;
    if ( category != null )
    {
        NorthwindDataSource.LoadProducts( category );
    }
    else
    {
        item.IsLoadOnDemandEnabled = false;
    }
}
#endregion
}
