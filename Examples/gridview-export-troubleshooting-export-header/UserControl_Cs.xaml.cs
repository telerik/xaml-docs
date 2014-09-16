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

#region gridview-export-troubleshooting-export-header_1
void clubsGrid_ElementExporting(object sender, GridViewElementExportingEventArgs e)
{
    if (e.Value != null && e.Value.GetType() == typeof(TextBlock))
         e.Value = (e.Value as TextBlock).Text;
}
#endregion
}
