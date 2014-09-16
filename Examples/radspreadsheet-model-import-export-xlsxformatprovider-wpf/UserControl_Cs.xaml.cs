using System;
using System.IO;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ImportExportXlsxFormatProviderWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ImportXlsx()
        {
            #region radspreadsheet-model-import-export-xlsxformatprovider-wpf_0
            string fileName = "SampleFile.xlsx";
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException(String.Format("File {0} was not found!", fileName));
            }

            Workbook workbook;
            IWorkbookFormatProvider formatProvider = new XlsxFormatProvider();

            using (FileStream input = new FileStream(fileName, FileMode.Open))
            {
                workbook = formatProvider.Import(input);
            }
            #endregion
        }

        private void ExportXlsx()
        {
            #region radspreadsheet-model-import-export-xlsxformatprovider-wpf_1
            Workbook workbook = new Workbook();
            workbook.Worksheets.Add();
            string fileName = "SampleFile.xlsx";

            IWorkbookFormatProvider formatProvider = new XlsxFormatProvider();

            using (FileStream output = new FileStream(fileName, FileMode.Create))
            {
                formatProvider.Export(workbook, output);
            }
            #endregion
        }
    }
}
