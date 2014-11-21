using System;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace CellsInsertRemove
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void InsertCells()
        {
            #region radspreadprocessing-working-with-cells-insert-remove-cells_0

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            CellRange range = new CellRange(1, 1, 10, 10);
            CellSelection selection = worksheet.Cells[range];

            if (selection.CanInsertOrRemove(range, ShiftType.Right))
            {
                selection.Insert(InsertShiftType.Right);
            }

            #endregion
        }

        public void RemoveCells()
        {
            #region radspreadprocessing-working-with-cells-insert-remove-cells_1

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            CellRange range = new CellRange(1, 1, 10, 10);
            CellSelection selection = worksheet.Cells[range];

            if (selection.CanInsertOrRemove(range, ShiftType.Up))
            {
                selection.Remove(RemoveShiftType.Up);
            }

            #endregion
        }
    }
}
