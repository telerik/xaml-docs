using System;
using System.IO;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.Pdf;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ExportPdfFormatProvider
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public class WpfPdfFormatProvider
        {
            private void ExportPdf()
            {
                #region radspreadprocessing-formats-and-conversion-pdf-pdfformatprovider_0
                PdfFormatProvider pdfFormatProvider = new PdfFormatProvider();
                using (Stream output = GetFileStream())
                {
                    Workbook workbook = CreateSampleWorkbook();
                    pdfFormatProvider.Export(workbook, output);
                }
                #endregion
            }

            private Stream GetFileStream()
            {
                throw new NotImplementedException();
            }

            private Workbook CreateSampleWorkbook()
            {
                throw new NotImplementedException();
            }
        }
    }
}
