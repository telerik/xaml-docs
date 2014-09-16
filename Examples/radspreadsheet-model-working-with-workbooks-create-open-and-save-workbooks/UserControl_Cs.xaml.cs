using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using Microsoft.Win32;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Csv;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ModelWorkbookCreateOpenSaveWorkbook
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void CreateNewWorkbook()
        {
            #region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_0
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            #endregion
        }

        public void ImportWorkbookFromXlsx()
        {
            #region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_1
            const string FilePath = @"http://localhost:54352/Resourses/SampleFile.xlsx";
            WebClient webClient = new WebClient();

            webClient.OpenReadCompleted += (sender, eventArgs) =>
            {
                XlsxFormatProvider formatProvider = new XlsxFormatProvider();
                Workbook workbook = formatProvider.Import(eventArgs.Result);
            };

            webClient.OpenReadAsync(new Uri(FilePath));
            #endregion
        }

        public void ExportWorkbookToCsvSL()
        {
            #region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_2
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

        public void ExportWorkbookToCsvWPF()
        {
            #region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_3
            Workbook workbook = new Workbook();
            workbook.Worksheets.Add();

            string fileName = "SampleFile.csv";
            IWorkbookFormatProvider formatProvider = new CsvFormatProvider();

            using (FileStream output = new FileStream(fileName, FileMode.Create))
            {
                formatProvider.Export(workbook, output);
            }
            #endregion
        }
    }
}