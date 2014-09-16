using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Spreadsheet;
using Telerik.Windows.Documents.Model;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Model.Printing;

namespace Printing
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        RadSpreadsheet radSpreadsheet = new RadSpreadsheet();
        private void PrintMethod()
        {         
        #region radspreadsheet-ui-print-method-example_0
            PrintWhatSettings printWhatSettings = new PrintWhatSettings(PrintWhat.ActiveSheet, false);

            // Prints showing the print dialog.
            this.radSpreadsheet.Print(printWhatSettings);

            // Prints silently to the default printer without showing the print dialog.
            this.radSpreadsheet.Print(printWhatSettings, new PrintDialog());

        #endregion
        }

        private void WorksheetPageSetUp()
        {
            #region radspreadsheet-ui-print-method-example_1

            WorksheetPageSetup pageSetup = this.radSpreadsheet.ActiveWorksheet.WorksheetPageSetup;

            pageSetup.PaperType = PaperTypes.A4;
            pageSetup.PageOrientation = PageOrientation.Landscape;
            pageSetup.ScaleFactor = new Size(0.9, 0.9);
            pageSetup.CenterHorizontally = true;

            #endregion
        }

        private void PrintAreaExample()
        {
            #region radspreadsheet-ui-print-area-example_02
            PrintArea printArea = this.radSpreadsheet.ActiveWorksheet.WorksheetPageSetup.PrintArea;

            printArea.SetPrintArea(new CellRange[]
            {
                new CellRange(0, 0, 4, 8),
                new CellRange(1, 1, 25, 3)
            });

            #endregion
        }

        private void PageBreaksExample()
        {
            #region radspreadsheet-ui-page-breaks-example_03
            PageBreaks pageBreaks = this.radSpreadsheet.ActiveWorksheet.WorksheetPageSetup.PageBreaks;

            pageBreaks.TryInsertHorizontalPageBreak(5, 0);
            pageBreaks.TryInsertHorizontalPageBreak(8, 0);
            pageBreaks.TryInsertHorizontalPageBreak(11, 0);
            pageBreaks.TryInsertHorizontalPageBreak(14, 0);
            pageBreaks.TryInsertHorizontalPageBreak(17, 0);
            pageBreaks.TryInsertHorizontalPageBreak(20, 0);
            pageBreaks.TryInsertHorizontalPageBreak(23, 0);

            #endregion
        }
    }
}
