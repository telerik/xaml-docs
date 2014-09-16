using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Txt;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ImportExportTxtFormatProvider
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ImportTxt()
        {
            string fileName = "SampleFile.txt";
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException(String.Format("File {0} was not found!", fileName));
            }
            
            #region radspreadprocessing-formats-and-conversion-txt-txtformatprovider_0
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
            #region radspreadprocessing-formats-and-conversion-txt-txtformatprovider_1
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
