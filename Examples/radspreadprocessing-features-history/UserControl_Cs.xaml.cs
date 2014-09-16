using System;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace FeaturesHistory
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static void UndoRedo()
        {
            #region radspreadprocessing-features-history_0
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            worksheet.Cells[0, 0].SetValue("First cell value");
            worksheet.Cells[0, 0].SetValue("Second cell value");

            workbook.History.Undo();
            workbook.History.Redo();
            #endregion
        }

        public static void IterateCellsAndWorksheetsInWorkbookUndoGroup()
        {
            #region radspreadprocessing-features-history_1
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            workbook.History.BeginUndoGroup();

            worksheet.Cells[0, 0].SetValue(15);
            worksheet.Cells[0, 0].SetFormat(new CellValueFormat("0.00"));

            workbook.History.EndUndoGroup();

            workbook.History.Undo();
            workbook.History.Redo();
            #endregion
        }

        public static void DisableHistory()
        {
            #region radspreadprocessing-features-history_2
            Workbook workbook = new Workbook();
            workbook.History.IsEnabled = false;
            #endregion
        }

        public static void ClearHistory()
        {
            #region radspreadprocessing-features-history_3
            Workbook workbook = new Workbook();
            workbook.History.Clear();
            #endregion
        }
    }
}
