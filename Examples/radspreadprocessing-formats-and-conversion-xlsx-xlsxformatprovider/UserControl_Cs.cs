using System;
using System.IO;
using System.Linq;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace SpreadProcessingDocumentationSourceCode.Examples.FormatsAndConversionXslxFormatProvider
{
    public class UserControl_Cs
    {
        private void ImportSpreadsheet()
        {
            #region radspreadprocessing-formats-and-conversion-xlsx-xlsxformatprovider_0
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

        private void ExportSpreadsheet()
        {
            #region radspreadprocessing-formats-and-conversion-xlsx-xlsxformatprovider_1
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
