using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Core;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Csv;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Txt;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ImportExportTxtSettings
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
                #region radspreadprocessing-formats-and-conversion-txt-settings_0
                TxtFormatProvider provider = new TxtFormatProvider();
                provider.Settings.Delimiter = ';';
                provider.Settings.Quote = '^';
                provider.Settings.HasHeaderRow = true;
                #endregion
            }
        }
    }
}
