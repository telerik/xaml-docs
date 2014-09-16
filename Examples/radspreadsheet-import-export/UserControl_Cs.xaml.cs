using System;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using Microsoft.Win32;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Csv;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Txt;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class Default_Cs : UserControl
    {
        public Default_Cs()
        {
#region radspreadsheet-import-export_0
string input = @"cell1,cell2";
this.radSpreadsheet.Workbook = new CsvFormatProvider().Import(input);
#endregion
    }

#region radspreadsheet-import-export_1
private void OpenFile_Click(object sender, EventArgs e)
{
    OpenFileDialog ofd = new OpenFileDialog();
    CsvFormatProvider formatProvider = new CsvFormatProvider();
    ofd.Filter = "Comma separated values (*.csv)|*.csv|All Files (*.*)|*.*";

    if (ofd.ShowDialog() == true)
    {
        using(Stream input = ofd.File.OpenRead())
        {
            this.radSpreadsheet.Workbook = formatProvider.Import(input);
        }
    }
}
#endregion

#region radspreadsheet-import-export_2
private void OpenFile_Click(object sender, EventArgs e)
{
    OpenFileDialog ofd = new OpenFileDialog();
    CsvFormatProvider formatProvider = new CsvFormatProvider();
    ofd.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*";

    if (ofd.ShowDialog() == true)
    {
        using(Stream input = ofd.OpenRead())
        {
            this.radSpreadsheet.Workbook = formatProvider.Import(input);
        }  
    }
}
#endregion

#region radspreadsheet-import-export_3
private void OpenFile_Click(object sender, EventArgs e)
{
    OpenFileDialog ofd = new OpenFileDialog();
    TxtFormatProvider formatProvider = new TxtFormatProvider();
    ofd.Filter = "Text (tab delimited) (*.txt)|*.txt|All Files (*.*)|*.*";

    if (ofd.ShowDialog() == true)
    {
        using(Stream input = ofd.File.OpenRead())
        {
            this.radSpreadsheet.Workbook = formatProvider.Import(input);
        }
    }
}
#endregion

#region radspreadsheet-import-export_4
private void OpenFile_Click(object sender, EventArgs e)
{
    OpenFileDialog ofd = new OpenFileDialog();
    TxtFormatProvider formatProvider = new TxtFormatProvider();
    ofd.Filter = "Text (tab delimited) (*.txt)|*.txt|All Files (*.*)|*.*";

    if (ofd.ShowDialog() == true)
    {
        using(Stream input = ofd.OpenRead())
        {
            this.radSpreadsheet.Workbook = formatProvider.Import(input);
        }
    }
}
#endregion

#region radspreadsheet-import-export_5
private void SaveFile_Click(object sender, EventArgs e)
{
    SaveFileDialog sfd = new SaveFileDialog();
    CsvFormatProvider formatProvider = new CsvFormatProvider();
    sfd.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*";
        
    if (sfd.ShowDialog() == true)
    {
        using (Stream output = sfd.OpenFile())
        {
            formatProvider.Export(this.radSpreadsheet.Workbook, output);             
        }
    }
}
#endregion

#region radspreadsheet-import-export_6
private void OpenFile_Click(object sender, EventArgs e)
{
    OpenFileDialog ofd = new OpenFileDialog();
    XlsxFormatProvider formatProvider = new XlsxFormatProvider();
    ofd.Filter = "Excel Workbook (*xlsx)|*.xlsx|All Files (*.*)|*.*";

    if (ofd.ShowDialog() == true)
    {
        using (Stream input = ofd.File.OpenRead())
        {
            this.radSpreadsheet.Workbook = formatProvider.Import(input);
        }
    }
}
#endregion

#region radspreadsheet-import-export_7
private void OpenFile_Click(object sender, EventArgs e)
{
    OpenFileDialog ofd = new OpenFileDialog();
    XlsxFormatProvider formatProvider = new XlsxFormatProvider();
    ofd.Filter = "Excel Workbook (*xlsx)|*.xlsx|All Files (*.*)|*.*";

    if (ofd.ShowDialog() == true)
    {
        using (Stream input = ofd.OpenRead())
        {
            this.radSpreadsheet.Workbook = formatProvider.Import(input);
        }
    }
}
#endregion

#region radspreadsheet-import-export_8
private void SaveFile_Click(object sender, EventArgs e)
{
    SaveFileDialog sfd = new SaveFileDialog();
    XlsxFormatProvider formatProvider = new XlsxFormatProvider();
    sfd.Filter = "Excel Workbook (*xlsx)|*.xlsx|All Files (*.*)|*.*";

    if (sfd.ShowDialog() == true)
    {
        using (Stream output = sfd.OpenFile())
        {
            formatProvider.Export(this.radSpreadsheet.Workbook, output);
        }
    }
}
#endregion

#region radspreadsheet-import-export_9
    WorkbookFormatProvidersManager.RegisterFormatProvider(new XlsxFormatProvider());
#endregion
}
}