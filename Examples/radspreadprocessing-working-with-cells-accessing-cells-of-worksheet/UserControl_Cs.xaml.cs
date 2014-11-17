using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace CellsAccessingCells
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void GetActiveWorksheet()
        {
            #region Get Active Worksheet

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            #endregion
        }

        public void CreateSelection1()
        {
            #region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_0
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            CellIndex cellIndex = new CellIndex(0, 5);
            CellSelection selection1 = worksheet.Cells[cellIndex];
            #endregion
        }

        public void CreateSelection2()
        {
            #region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_1
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            CellRange cellRange = new CellRange(0, 0, 5, 5);
            CellSelection selection2 = worksheet.Cells[cellRange];
            #endregion
        }

        public void CreateSelection3()
        {
            #region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_2
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            List<CellRange> ranges = new List<CellRange>();
            ranges.Add(new CellRange(0, 0, 5, 5));
            ranges.Add(new CellRange(0, 10, 5, 15));
            CellSelection selection3 = worksheet.Cells[ranges];
            #endregion
        }

        public void CreateSelection4()
        {
            #region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_3
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            CellIndex fromIndex = new CellIndex(0, 0);
            CellIndex toIndex = new CellIndex(5, 5);
            CellSelection selection4 = worksheet.Cells[fromIndex, toIndex];
            #endregion
        }

        public void CreateSelection5()
        {
            #region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_4
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            CellSelection selection5 = worksheet.Cells[0, 5];
            #endregion
        }

        public void CreateSelection6()
        {
            #region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_5
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            CellSelection selection6 = worksheet.Cells[0, 0, 5, 5];
            #endregion
        }
    }
}
