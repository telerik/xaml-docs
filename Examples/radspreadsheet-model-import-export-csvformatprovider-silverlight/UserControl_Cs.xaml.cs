using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using Microsoft.Win32;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Core;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Csv;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ImportExportCsvFormatProviderSilverlight
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region radspreadsheet-model-import-export-csvformatprovider-silverlight_3

        public class CustomCsvFormatProvider : CsvFormatProvider
        {
            public override CsvSettings Settings
            {
                get
                {
                    return new CsvSettings() { Delimiter = ';' };
                }
            }
        }

        #endregion

        public class SilverlightCsvFormatProvider
        {
            #region radspreadsheet-model-import-export-csvformatprovider-silverlight_0
            public void ImportWorkbookFromCsv(string fileName)
            {
                string filePath = string.Format(@"http://localhost:54352/Files/{0}", fileName);
                WebClient webClient = new WebClient();

                webClient.OpenReadCompleted += webClient_OpenReadCompleted;
                webClient.OpenReadAsync(new Uri(filePath));
            }

            private void webClient_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
            {
                CsvFormatProvider formatProvider = new CsvFormatProvider();
                Workbook workbook = formatProvider.Import(e.Result);
            }
            #endregion

#if silverlight
            private void ImportWorkbookFromCsvUsingOpenFileDialog()
            {
            #region radspreadsheet-model-import-export-csvformatprovider-silverlight_1
                Workbook workbook;

                OpenFileDialog openFileDialog = new OpenFileDialog();
                IWorkbookFormatProvider formatProvider = new CsvFormatProvider();
                openFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == true)
                {
                    using (Stream input = openFileDialog.File.OpenRead())
                    {
                        workbook = formatProvider.Import(input);
                    }
                }
                #endregion
            }
#endif

            public void ExportWorkbookToCsv()
            {
                #region radspreadsheet-model-import-export-csvformatprovider-silverlight_2
                Workbook workbook = new Workbook();
                workbook.Worksheets.Add();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                CsvFormatProvider formatProvider = new CsvFormatProvider();
                saveFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == true)
                {
                    using (Stream output = saveFileDialog.OpenFile())
                    {
                        formatProvider.Export(workbook, output);
                    }
                }
                #endregion
            }

#if silverlight
            private void ImportWorkbookFromCsvUsingOpenFileDialogCuctomDelimiter()
            {
            #region radspreadsheet-model-import-export-csvformatprovider-silverlight_4
                Workbook workbook;

                OpenFileDialog openFileDialog = new OpenFileDialog();
                CustomCsvFormatProvider formatProvider = new CustomCsvFormatProvider();
                openFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == true)
                {
                    using (Stream input = openFileDialog.File.OpenRead())
                    {
                        workbook = formatProvider.Import(input);
                    }
                }
                #endregion
            }
#endif

            public void ExportWorkbookToCsvCustomDelimiter()
            {
                #region radspreadsheet-model-import-export-csvformatprovider-silverlight_5
                Workbook workbook = new Workbook();
                workbook.Worksheets.Add();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                CustomCsvFormatProvider formatProvider = new CustomCsvFormatProvider();
                saveFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == true)
                {
                    using (Stream output = saveFileDialog.OpenFile())
                    {
                        formatProvider.Export(workbook, output);
                    }
                }
                #endregion
            }
        }
    }
}
