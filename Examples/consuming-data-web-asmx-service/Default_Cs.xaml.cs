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

#region consuming-data-web-asmx-service_0
WebService.SampleWebServiceSoapClient serviceClient = new WebService.SampleWebServiceSoapClient();
#endregion

#region consuming-data-web-asmx-service_2
serviceClient.LoadCategoriesCompleted += new EventHandler<CSharp.WebService.LoadCategoriesCompletedEventArgs>( serviceClient_LoadCategoriesCompleted );
serviceClient.LoadCategoriesAsync();
#endregion

#region consuming-data-web-asmx-service_4
foreach( Categories c in serviceClient.LoadCategories() )
{
    this.Categories.Add( c );
}
#endregion

#region consuming-data-web-asmx-service_6
private void serviceClient_LoadCategoriesCompleted( object sender, LoadCategoriesCompletedEventArgs e )
{
    if ( e.Error == null && e.Result != null )
    {
        // Consume the result
        foreach ( Categories c in e.Result )
        {
            this.Categories.Add( c );
        }
    }
}
#endregion
}
