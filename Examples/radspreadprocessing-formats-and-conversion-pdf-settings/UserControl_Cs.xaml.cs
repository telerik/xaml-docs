using System;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.Pdf;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.Pdf.Export;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ImportExportPdfSettings
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public class WpfPdfFormatProvider
        {
            private void UsePdfSettingsExportWorkbook()
            {
                #region radspreadprocessing-formats-and-conversion-pdf-settings_0
                PdfFormatProvider provider = new PdfFormatProvider();
                provider.ExportSettings = new PdfExportSettings(ExportWhat.EntireWorkbook, false);
                #endregion
            }

            private void UsePdfSettingsExportSelection()
            {
                #region radspreadprocessing-formats-and-conversion-pdf-settings_1
                CellRange[] rangesToExport = new CellRange[]
                {
                    new CellRange(2, 3, 10, 15),
                    new CellRange(4, 5, 8, 20)
                };

                PdfFormatProvider provider = new PdfFormatProvider();
                provider.ExportSettings = new PdfExportSettings(rangesToExport);
                #endregion
            }
        }
    }
}
