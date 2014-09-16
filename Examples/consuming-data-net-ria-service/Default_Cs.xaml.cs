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

#region consuming-data-net-ria-service_0
SampleRiaContext riaContext = new SampleRiaContext();
#endregion

#region consuming-data-net-ria-service_2
LoadOperation<Categories> loadOperation = riaContext.Load<Categories>( riaContext.GetCategoriesQuery() );
loadOperation.Completed += new EventHandler( loadOperation_Completed );
#endregion

#region consuming-data-net-ria-service_4
private void loadOperation_Completed( object sender, EventArgs e )
{
    //Consume the result
    List<Categories> result = riaContext.Categories.ToList();
}
#endregion
}
