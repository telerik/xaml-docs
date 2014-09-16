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

#region radcombobox-populating-with-data-binding-to-wcf_1
ComboBoxWcfServiceClient serviceClient = new ComboBoxWcfServiceClient();
#endregion

#region radcombobox-populating-with-data-binding-to-wcf_3
private void BeginRequest()
{
    serviceClient.GetProductsCompleted += new EventHandler<GetProductsCompletedEventArgs>( serviceClient_GetProductsCompleted );
    serviceClient.GetProductsAsync();
}
private void serviceClient_GetProductsCompleted( object sender, GetProductsCompletedEventArgs e )
{
    radComboBox.ItemsSource = e.Result;
}
#endregion

#region radcombobox-populating-with-data-binding-to-wcf_5
private void BeginRequest()
{
    this.radComboBox.ItemsSource = serviceClient.GetProducts();
}
#endregion

#region radcombobox-populating-with-data-binding-to-wcf_9
public class NorthwindDataSource
{
}
#endregion

#region radcombobox-populating-with-data-binding-to-wcf_11
public class NorthwindDataSource
{
    private ComboBoxWcfServiceClient serviceClient;
    public NorthwindDataSource()
    {
        this.Products = new ObservableCollection<Products>();
        this.serviceClient = new ComboBoxWcfServiceClient();
    }
    public ObservableCollection<Products> Products
    {
        get;
        protected set;
    }
}
#endregion

#region radcombobox-populating-with-data-binding-to-wcf_13
this.serviceClient.GetProductsCompleted += new EventHandler<GetProductsCompletedEventArgs>( serviceClient_GetProductsCompleted );
this.serviceClient.GetProductsAsync();
#endregion

#region radcombobox-populating-with-data-binding-to-wcf_15
private void serviceClient_GetProductsCompleted( object sender, GetProductsCompletedEventArgs e )
{
    foreach ( Products p in e.Result )
    {
        this.Products.Add( p );
    }
}
#endregion

#region radcombobox-populating-with-data-binding-to-wcf_17
foreach ( Products p in serviceClient.GetProducts() )
{
    this.Products.Add( p );
}
#endregion
}
