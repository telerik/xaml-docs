using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Core;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Csv;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ImportExportCsvSettings
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public class WpfCsvFormatProvider
        {
            private void UseCsvSettings()
            {
                #region radspreadprocessing-formats-and-conversion-csv-settings_0
                CsvFormatProvider provider = new CsvFormatProvider();
                provider.Settings.Delimiter = ';';
                provider.Settings.Quote = '^';
                provider.Settings.HasHeaderRow = true;
                provider.Settings.Encoding = new ASCIIEncoding(); 
                #endregion
            }
        }
    }
}
