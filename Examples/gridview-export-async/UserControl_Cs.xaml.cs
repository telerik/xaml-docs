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

#region gridview-export-async_0
string extension = "xls";
SaveFileDialog dialog = new SaveFileDialog()
{
    DefaultExt = extension,
    Filter = String.Format("{1} files (*.{0})|*.{0}|All files (*.*)|*.*", extension, "Excel"),
    FilterIndex = 1
};
if (dialog.ShowDialog() == true)
{
    Stream stream = dialog.OpenFile();
    clubsGrid.ExportAsync(stream,
    new GridViewExportOptions()
    {
        Format = ExportFormat.ExcelML,
        ShowColumnHeaders = true,
        ShowColumnFooters = true,
        ShowGroupFooters = false,
    }, true);
}            

#endregion

#region gridview-export-async_2
(e.VisualParameters as GridViewExcelMLVisualExportParameters).StyleId = "0";
#endregion

#region gridview-export-async_4
ExcelMLStyle style = new ExcelMLStyle("0");            
style.Alignment.Horizontal = ExcelMLHorizontalAlignment.Automatic;
e.Styles.Add(style);

#endregion

#region gridview-export-async_6
private void clubsGrid_ElementExporting_1(object sender, GridViewElementExportingEventArgs e)
{
    if (e.VisualParameters is GridViewHtmlVisualExportParameters)
    {
        var param = e.VisualParameters as GridViewHtmlVisualExportParameters;
	    param.Background = Colors.Red;
	    param.FontFamily = new FontFamily("Verdana");
	    param.FontSize = 30;
	    param.FontWeight = FontWeights.Bold;
	    param.Foreground = Colors.Green;
	    param.Height = 50;
	    param.TextAlignment = TextAlignment.Center;
	    param.VerticalAlignment = VerticalAlignment.Bottom;
	    param.Width = 500;
    }
}

#endregion   		
}
