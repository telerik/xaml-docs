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

#region consuming-data-ado-net-data-service_0
NorthwindEntities northwindEntity = new NorthwindEntities( new Uri( "http://localhost:54248/Services/SampleAdoNetDataService.svc/" ) );
#endregion

#region consuming-data-ado-net-data-service_2
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
private static void EntitiesLoaded<T>( IAsyncResult result, Collection<T> entities )
{
    DataServiceQuery<T> query = result.AsyncState as DataServiceQuery<T>;
    foreach ( T entity in query.EndExecute( result ) )
    {
        entities.Add( entity );
    }
}
#endregion

#region consuming-data-ado-net-data-service_4
foreach( Categories c in northwindEntity.Categories.Execute() )
{
    this.Categories.Add( c );
}
#endregion
}
