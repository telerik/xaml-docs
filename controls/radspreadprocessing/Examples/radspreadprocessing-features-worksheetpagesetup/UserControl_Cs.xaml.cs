using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Documents.Model;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Model.Printing;
using Telerik.Windows.Documents.Spreadsheet.Theming;

namespace FeaturesWorksheetPageSetup
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void SetupWorksheetPage(Workbook workbook)
        {
            #region radspreadprocessing-features-worksheetpagesetup_0
            WorksheetPageSetup pageSetup = workbook.ActiveWorksheet.WorksheetPageSetup;

            pageSetup.PaperType = PaperTypes.A4;
            pageSetup.PageOrientation = PageOrientation.Landscape;
            pageSetup.ScaleFactor = new Size(0.9, 0.9);
            pageSetup.CenterHorizontally = true;
            #endregion
        }

        private void SetPrintArea(Workbook workbook)
        {
            #region radspreadprocessing-features-worksheetpagesetup_1
            PrintArea printArea = workbook.ActiveWorksheet.WorksheetPageSetup.PrintArea;

            printArea.SetPrintArea(new CellRange[]
            {
                new CellRange(0, 0, 4, 8),
                new CellRange(1, 1, 25, 3)
            });
            #endregion
        }

        private void InsertPageBreaks(Workbook workbook)
        {
            #region radspreadprocessing-features-worksheetpagesetup_2
            PageBreaks pageBreaks = workbook.ActiveWorksheet.WorksheetPageSetup.PageBreaks;

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
