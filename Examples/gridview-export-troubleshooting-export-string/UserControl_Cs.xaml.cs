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

#region gridview-export-troubleshooting-export-string_0
private void clubsGrid_ElementExporting(object sender, GridViewElementExportingEventArgs e)
{
   if(e.Element == ExportElement.Cell)
   {
      if(column.Header.ToString() == "My String Column")
      {
           e.Value = string.Format(@"=T(""{0}"")",  e.Value);
      }
   }
}

#endregion
}
