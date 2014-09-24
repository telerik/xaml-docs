using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using Microsoft.Win32;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Txt;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ImportExportTxtFormatProviderSilverlight
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region radspreadsheet-model-import-export-txtformatprovider-silverlight_0
        public void ImportWorkbookFromTxt(string fileName)
        {
            string filePath = string.Format(@"http://localhost:54352/Files/{0}", fileName);
            WebClient webClient = new WebClient();

            webClient.OpenReadCompleted += webClient_OpenReadCompleted;
            webClient.OpenReadAsync(new Uri(filePath));
        }

        private void webClient_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            TxtFormatProvider formatProvider = new TxtFormatProvider();
            Workbook workbook = formatProvider.Import(e.Result);
        }
        #endregion

#if silverlight
        private void ImportWorkbookFromTxtUsingOpenFileDialog()
        {
        #region radspreadsheet-model-import-export-txtformatprovider-silverlight_1
            Workbook workbook;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            IWorkbookFormatProvider formatProvider = new TxtFormatProvider();
            openFileDialog.Filter = "TXT (tab delimited) (*.txt)|*.txt|All Files (*.*)|*.*";

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

        public void ExportWorkbookToTxt()
        {
            #region radspreadsheet-model-import-export-txtformatprovider-silverlight_2
            Workbook workbook = new Workbook();
            workbook.Worksheets.Add();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            TxtFormatProvider formatProvider = new TxtFormatProvider();
            saveFileDialog.Filter = "TXT (tab delimited) (*.txt)|*.txt|All Files (*.*)|*.*";

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
