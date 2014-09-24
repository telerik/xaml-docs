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

#region gridview-loading-data-from-ria-services_1
public class NorthwindDataSource
{
}
#endregion

#region gridview-loading-data-from-ria-services_3
public class NorthwindDataSource
{
    SampleRiaContext riaContext;
    public NorthwindDataSource()
    {
        riaContext = new SampleRiaContext();
        this.Customers = new ObservableCollection<Customers>();
    }
    public ObservableCollection<Customers> Customers
    {
        get;
        set;
    }
}
#endregion

#region gridview-loading-data-from-ria-services_5
LoadOperation<Customers> loadOperation = riaContext.Load<Customers>( riaContext.GetCustomersQuery() );
loadOperation.Completed += new EventHandler( loadOperation_Completed );
#endregion

#region gridview-loading-data-from-ria-services_7
private void loadOperation_Completed( object sender, EventArgs e )
{
    //Consume the result
    foreach ( Customers c in riaContext.Customers )
    {
        this.Customers.Add( c );
    }
}
#endregion
}
