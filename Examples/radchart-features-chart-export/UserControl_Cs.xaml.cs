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

#region radchart-features-chart-export_0
SaveFileDialog dialog = new SaveFileDialog();
dialog.DefaultExt = "*.xls";
dialog.Filter = "Files(*.xls)|*.xls";
if ( !( bool )dialog.ShowDialog() )
    return;
Stream fileStream = dialog.OpenFile();
radChart.ExportToExcelML( fileStream );
fileStream.Close();
#endregion

#region radchart-features-chart-export_2
SaveFileDialog dialog = new SaveFileDialog();
dialog.DefaultExt = "*.xls";
dialog.Filter = "Files(*.xls)|*.xls";
if ( !( bool )dialog.ShowDialog() )
    return;
radChart.ExportToExcelML( dialog.FileName );
fileStream.Close();
#endregion
}
