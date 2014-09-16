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

#region gridview-loading-data-from-web-services_1
SampleWebServiceSoapClient serviceClient = new SampleWebServiceSoapClient();
#endregion

#region gridview-loading-data-from-web-services_3
serviceClient.LoadCustomersCompleted += new EventHandler<LoadCustomersCompletedEventArgs>( serviceClient_LoadCustomersCompleted );
serviceClient.LoadCustomersAsync();
private void serviceClient_LoadCustomersCompleted( object sender, LoadCustomersCompletedEventArgs e )
{
    var customers = e.Result;
    this.radGridView.ItemsSource = customers;
}
#endregion

#region gridview-loading-data-from-web-services_5
SampleWebServiceSoapClient serviceClient = new SampleWebServiceSoapClient();
this.radGridView.ItemsSource = serviceClient.LoadCustomers();
#endregion

#region gridview-loading-data-from-web-services_7
public class NorthwindDataSource
{
}
#endregion

#region gridview-loading-data-from-web-services_9
public class NorthwindDataSource
{
    private SampleWebServiceSoapClient serviceClient;
    public NorthwindDataSource()
    {
        serviceClient = new SampleWebServiceSoapClient();
        this.Customers = new ObservableCollection<Customers>();
    }
    public ObservableCollection<Customers> Customers
    {
        get;
        set;
    }
}
#endregion

#region gridview-loading-data-from-web-services_11
serviceClient.LoadCustomersCompleted += new EventHandler<LoadCustomersCompletedEventArgs>( serviceClient_LoadCustomersCompleted );
serviceClient.LoadCustomersAsync();
#endregion

#region gridview-loading-data-from-web-services_12
foreach ( Customers c in serviceClient.LoadCustomers() )
{
    this.Customers.Add( c );
}
#endregion

#region gridview-loading-data-from-web-services_15
private void serviceClient_LoadCustomersCompleted( object sender, LoadCustomersCompletedEventArgs e )
{
    if ( e.Error == null && e.Result != null )
    {
        foreach ( Customers c in e.Result )
        {
            this.Customers.Add( c );
        }
    }
}
#endregion
}
