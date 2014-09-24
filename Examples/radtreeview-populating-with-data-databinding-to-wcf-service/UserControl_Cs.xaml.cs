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

#region radtreeview-populating-with-data-databinding-to-wcf-service_1
public class NorthwindDataSource
{
}
#endregion

#region radtreeview-populating-with-data-databinding-to-wcf-service_3
public class NorthwindDataSource
{
    private SampleWcfServiceClient serviceClient;
    public NorthwindDataSource()
    {
        serviceClient = new SampleWcfServiceClient();
        this.Categories = new ObservableCollection<Categories>();
    }
    public ObservableCollection<Categories> Categories
    {
        get;
        set;
    }
}
#endregion

#region radtreeview-populating-with-data-databinding-to-wcf-service_5
this.serviceClient.LoadCategoriesCompleted += new EventHandler<LoadCategoriesCompletedEventArgs>( serviceClient_LoadCategoriesCompleted );
this.serviceClient.LoadCategoriesAsync();
#endregion

#region radtreeview-populating-with-data-databinding-to-wcf-service_6
foreach ( Categories c in serviceClient.LoadCategories() )
{
    this.Categories.Add( c );
}
#endregion

#region radtreeview-populating-with-data-databinding-to-wcf-service_9
private void serviceClient_LoadCategoriesCompleted( object sender, LoadCategoriesCompletedEventArgs e )
{
    if ( e.Error == null && e.Result != null )
    {
        foreach ( Categories c in e.Result )
        {
            this.Categories.Add( c );
        }
    }
}
#endregion

#region radtreeview-populating-with-data-databinding-to-wcf-service_15
public void BeginLoadingProducts( Categories category )
{
    serviceClient.LoadProductsByCategoryIdCompleted += new EventHandler<LoadProductsByCategoryIdCompletedEventArgs>( serviceClient_LoadProductsByCategoryIdCompleted );
    serviceClient.LoadProductsByCategoryIdAsync( category.CategoryID, category );
}
private void serviceClient_LoadProductsByCategoryIdCompleted( object sender, LoadProductsByCategoryIdCompletedEventArgs e )
{
    if ( e.Error == null && e.Result != null )
    {
        Categories currentCategory = e.UserState as Categories;
        foreach ( Products p in e.Result )
        {
            currentCategory.Products.Add( p );
        }
    }
}
#endregion

#region radtreeview-populating-with-data-databinding-to-wcf-service_16
public void LoadProducts( Categories category )
{
    category.Products = new ObservableCollection<Products>();
    foreach ( Products p in serviceClient.LoadProductsByCategoryId( category.CategoryID ) )
    {
        category.Products.Add( p );
    }
}
#endregion

#region radtreeview-populating-with-data-databinding-to-wcf-service_19
private void radTreeView_LoadOnDemand( object sender, Telerik.Windows.RadRoutedEventArgs e )
{
    RadTreeViewItem item = e.OriginalSource as RadTreeViewItem;
    Categories category = item.Item as Categories;
    if ( category != null )
    {
        ( this.Resources[ "DataSource" ] as NorthwindDataSource ).BeginLoadingProducts( category );
    }
    else
    {
        item.IsLoadOnDemandEnabled = false;
    }
}
#endregion

#region radtreeview-populating-with-data-databinding-to-wcf-service_20
private void radTreeView_LoadOnDemand( object sender, Telerik.Windows.RadRoutedEventArgs e )
{
    RadTreeViewItem item = e.OriginalSource as RadTreeViewItem;
    Categories category = item.Item as Categories;
    if ( category != null )
    {
        ( this.Resources[ "DataSource" ] as NorthwindDataSource ).LoadProducts( category );
    }
    else
    {
        item.IsLoadOnDemandEnabled = false;
    }
}
#endregion
}
