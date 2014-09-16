using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Core;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Csv;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ImportExportCsvFormatProvider
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public class WpfCsvFormatProvider
        {
            private void ImportCsv()
            {
                #region radspreadprocessing-formats-and-conversion-csv-csvformatprovider_0
                string fileName = "FileName.csv";
                if (!File.Exists(fileName))
                {
                    throw new FileNotFoundException(String.Format("File {0} was not found!", fileName));
                }

                Workbook workbook;
                IWorkbookFormatProvider formatProvider = new CsvFormatProvider();

                using (FileStream input = new FileStream(fileName, FileMode.Open))
                {
                    workbook = formatProvider.Import(input);
                }
                #endregion
            }

            private void ExportCsv()
            {
                #region radspreadprocessing-formats-and-conversion-csv-csvformatprovider_1
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
}
