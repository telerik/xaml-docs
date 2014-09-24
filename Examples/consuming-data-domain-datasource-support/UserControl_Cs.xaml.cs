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

#region consuming-data-domain-datasource-support_4
private void DomainDataSource_LoadedData( object sender, LoadedDataEventArgs e )
{
    foreach ( Categories c in e.AllEntities )
    {
        // Process the data
    }
}
#endregion
}
