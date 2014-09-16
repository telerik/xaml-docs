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

#region gridview-export_0
public MainPage()
{
 InitializeComponent();
 btnExport.Click += new RoutedEventHandler(btnExport_Click); 
}
void btnExport_Click(object sender, RoutedEventArgs e)
{
 string extension = "xls";
 SaveFileDialog dialog = new SaveFileDialog()
 {
  DefaultExt = extension,
  Filter = String.Format("{1} files (*.{0})|*.{0}|All files (*.*)|*.*", extension, "Excel"),
  FilterIndex = 1
 };
 if (dialog.ShowDialog() == true)
 {
  using (Stream stream = dialog.OpenFile())
  {
   gridViewExport.Export(stream,
    new GridViewExportOptions()
    {
     Format = ExportFormat.Html,
     ShowColumnHeaders = true,
     ShowColumnFooters = true,
     ShowGroupFooters = false,
    });
  }
 }
}
#endregion

#region gridview-export_2
using Telerik.Windows.Controls;
...
string htmlExport = this.ExportGrid.ToHtml( true );
#endregion
}
