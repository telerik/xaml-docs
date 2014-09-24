using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Txt;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ImportExportTxtFormatProviderWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ImportTxt()
        {
            #region radspreadsheet-model-import-export-txtformatprovider-wpf_0
            string fileName = "SampleFile.txt";
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException(String.Format("File {0} was not found!", fileName));
            }

            Workbook workbook;
            IWorkbookFormatProvider formatProvider = new TxtFormatProvider();

            using (FileStream input = new FileStream(fileName, FileMode.Open))
            {
                workbook = formatProvider.Import(input);
            }
            #endregion
        }

        private void ExportTxt()
        {
            #region radspreadsheet-model-import-export-txtformatprovider-wpf_1
            Workbook workbook = new Workbook();
            workbook.Worksheets.Add();

            string fileName = "SampleFile.txt";
            IWorkbookFormatProvider formatProvider = new TxtFormatProvider();

            using (FileStream output = new FileStream(fileName, FileMode.Create))
            {
                formatProvider.Export(workbook, output);
            }
            #endregion
        }
    }
}
