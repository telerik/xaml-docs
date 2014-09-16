using System;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.DataSeries;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace FeaturesFillDataAutomaticallyRepeatValues
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static void RepeatValuesRight()
        {
            #region radspreadprocessing-features-fill-data-automatically-repeat-values_0
            Workbook workbook = new Workbook();
            workbook.Worksheets.Add();
            Worksheet activeWorksheet = workbook.ActiveWorksheet;

            activeWorksheet.Cells[0, 0].SetValue(5);
            activeWorksheet.Cells[1, 0].SetValue(8);
            activeWorksheet.Cells[2, 0].SetValue(13);
            activeWorksheet.Cells[3, 0].SetValue(21);

            CellRange range = new CellRange(0, 0, 3, 3);
            activeWorksheet.Cells[range].FillData(FillDirection.Right);
            #endregion
        }

        public static void RepeatValuesDown()
        {
            #region radspreadprocessing-features-fill-data-automatically-repeat-values_1
            Workbook workbook = new Workbook();
            workbook.Worksheets.Add();
            Worksheet activeWorksheet = workbook.ActiveWorksheet;

            activeWorksheet.Cells[1, 1].SetValue(34);
            activeWorksheet.Cells[1, 2].SetValue(55);
            activeWorksheet.Cells[1, 3].SetValue(89);

            CellRange range = new CellRange(1, 1, 3, 3);
            activeWorksheet.Cells[range].FillData(FillDirection.Down);
            #endregion
        }
    }
}