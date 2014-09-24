using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using Microsoft.Win32;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ImportExportXlsxFormatProviderSilverlight
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region radspreadsheet-model-import-export-xlsxformatprovider-silverlight_0
        public void ImportWorkbookFromXlsx(string fileName)
        {
            string filePath = string.Format(@"http://localhost:54352/Files/{0}", fileName);
            WebClient webClient = new WebClient();

            webClient.OpenReadCompleted += webClient_OpenReadCompleted;
            webClient.OpenReadAsync(new Uri(filePath));
        }

        private void webClient_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            XlsxFormatProvider formatProvider = new XlsxFormatProvider();

            Workbook workbook = formatProvider.Import(e.Result);
        }
        #endregion

#if silverlight
        private void ImportWorkbookFromXlsxUsingOpenFileDialog()
        {
            #region radspreadsheet-model-import-export-xlsxformatprovider-silverlight_1
            Workbook workbook;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            XlsxFormatProvider formatProvider = new XlsxFormatProvider();
            openFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|All Files (*.*)|*.*";

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

        public void ExportWorkbookToXlsx()
        {
            #region radspreadsheet-model-import-export-xlsxformatprovider-silverlight_2
            Workbook workbook = new Workbook();
            workbook.Worksheets.Add();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            IWorkbookFormatProvider formatProvider = new XlsxFormatProvider();
            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|All Files (*.*)|*.*";

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
