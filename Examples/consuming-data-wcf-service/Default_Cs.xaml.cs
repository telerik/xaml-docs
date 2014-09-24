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

#region consuming-data-wcf-service_0
WcfService.SampleWcfServiceClient serviceClient = new WcfService.SampleWcfServiceClient();
#endregion

#region consuming-data-wcf-service_2
serviceClient.LoadCategoriesCompleted += new EventHandler<LoadCategoriesCompletedEventArgs>( serviceClient_LoadCategoriesCompleted );
serviceClient.LoadCategoriesAsync();
#endregion

#region consuming-data-wcf-service_4
foreach( Categories c in serviceClient.LoadCategories() )
{
    this.Categories.Add( c );
}
#endregion

#region consuming-data-wcf-service_6
private void serviceClient_LoadCategoriesCompleted( object sender, LoadCategoriesCompletedEventArgs e )
{
    if ( e.Error == null && e.Result != null )
    {
        //Consume the result
        foreach ( Categories c in e.Result )
        {
            this.Categories.Add( c );
        }
    }
}
#endregion
}
