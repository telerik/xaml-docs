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

#region gridview-export-events_1
RadGridView1.ElementExporting += new EventHandler<GridViewElementExportingEventArgs>(RadGridView1_ElementExporting);
RadGridView1.ElementExported += new EventHandler<GridViewElementExportedEventArgs>(RadGridView1_ElementExported);
#endregion

#region gridview-export-events_3
private void RadGridView1_ElementExporting( object sender, GridViewElementExportingEventArgs e )
{
   //Change the font size and the background color of the table header only
   if ( e.Element == ExportElement.HeaderRow ||
       e.Element == ExportElement.HeaderCell )
   {
       e.FontSize = e.FontSize + 4;
       e.Background = Colors.DarkGray;
   }
   //Change the font size and the background color of the group headers only
   else if ( e.Element == ExportElement.GroupHeaderCell ||
       e.Element == ExportElement.GroupHeaderRow )
   {
       e.FontSize = e.FontSize + 2;
       e.Background = Colors.LightGray;
   }
}
#endregion

#region gridview-export-events_5
private void RadGridView1_ElementExported(object sender, GridViewElementExportedEventArgs e)
{
    if (e.Element == ExportElement.Row)
    {
        Employees obj = e.Context as Employees;
        if (obj != null)
        {
            e.Writer.Write(String.Format(@"<tr><td style=""background-color:#CCC;"" colspan=""{0}"">",
                ((IEnumerable<Telerik.Windows.Controls.GridViewColumn>)RadGridView1.Columns).Count()));
            e.Writer.Write(String.Format(@"<b>Birth date:</b> {0} <br />", obj.BirthDate));
            e.Writer.Write(String.Format(@"<b>Hire date:</b> {0} <br />", obj.HireDate));
            e.Writer.Write(String.Format(@"<b>Address:</b> {0} <br />", obj.Address));
            e.Writer.Write(String.Format(@"<b>City:</b> {0} <br />", obj.City));
            e.Writer.Write(String.Format(@"<b>Notes:</b> {0} <br />", obj.Notes));
            e.Writer.Write("</td></tr>");
        }
    }
}
#endregion

#region gridview-export-events_7
ExcelMLStyle style = new ExcelMLStyle("0");            
style.Alignment.Horizontal = ExcelMLHorizontalAlignment.Automatic;
e.Styles.Add(style);
#endregion

#region gridview-export-events_9
private void clubsGrid_InitializingExcelMLStyles_1(object sender, ExcelMLStylesEventArgs e)private void clubsGrid_InitializingExcelMLStyles_1(object sender, ExcelMLStylesEventArgs e)
{
	ExcelMLStyle style = new ExcelMLStyle("0");

	// Alignment
	style.Alignment.Horizontal = ExcelMLHorizontalAlignment.Automatic;
	style.Alignment.Vertical = ExcelMLVerticalAlignment.Top;
	style.Alignment.Indent = 5;
	style.Alignment.Rotate = 0;
	style.Alignment.ShrinkToFit = true;
 	style.Alignment.VerticalText = true;
	style.Alignment.WrapText = true;

	// Font
	style.Font.Bold = true;
	style.Font.Color = "Beige";
	style.Font.FontName = "Calibri";
	style.Font.Italic = true;
	style.Font.Outline = true;
	style.Font.Shadow = true;
	style.Font.Size = 10;
	style.Font.StrikeThrough = true;
	style.Font.Underline = ExcelMLUnderline.Double;

	// Interior
	style.Interior.Color = "Green";
	style.Interior.Pattern = ExcelMLPattern.Solid;
	style.Interior.PatternColor = "#FF0000";

	// NumberFormat
 	style.NumberFormat.Format = "00.00";

    e.Styles.Add(style);
}    		
#endregion
}
