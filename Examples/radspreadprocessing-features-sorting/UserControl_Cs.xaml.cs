using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Documents.Spreadsheet.DataSeries;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Model.Filtering;
using Telerik.Windows.Documents.Spreadsheet.Model.Sorting;

namespace FeaturesSorting
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void CreateValuesSortCondition()
        {
            #region radspreadprocessing-features-sorting_0
            ValuesSortCondition condition = new ValuesSortCondition(0, SortOrder.Ascending);
            #endregion
        }

        public void CreateCustomValuesSortCondition()
        {
            #region radspreadprocessing-features-sorting_1
            CustomValuesSortCondition condition = new CustomValuesSortCondition(0, new string[] { "regular", "1 day", "2 days", "express" }, SortOrder.Ascending);
            #endregion
        }

        public void CreateForeColorSortCondition()
        {
            #region radspreadprocessing-features-sorting_2
            ForeColorSortCondition condition = new ForeColorSortCondition(0, new ThemableColor(Colors.Red), SortOrder.Ascending);
            #endregion
        }

        public void CreateFillColorSortCondition()
        {
            #region radspreadprocessing-features-sorting_3
            FillColorSortCondition condition = new FillColorSortCondition(0, PatternFill.CreateSolidFill(Color.FromRgb(181, 18, 27)), SortOrder.Ascending);
            #endregion
        }

        public void SetSorting(Workbook workbook)
        {
            #region radspreadprocessing-features-sorting_4
            Worksheet worksheet = workbook.ActiveWorksheet;

            CustomValuesSortCondition condition1 = new CustomValuesSortCondition(5, new string[] { "regular", "1 day", "2 days", "express" }, SortOrder.Ascending);
            FillColorSortCondition condition2 = new FillColorSortCondition(7, PatternFill.CreateSolidFill(Color.FromRgb(181, 18, 27)), SortOrder.Ascending);
            FillColorSortCondition condition3 = new FillColorSortCondition(7, PatternFill.CreateSolidFill(Color.FromRgb(94, 151, 50)), SortOrder.Ascending);
            #endregion

            #region radspreadprocessing-features-sorting_5
            worksheet.SortState.Set(new CellRange(3, 0, 17, 7), condition1, condition2, condition3);
            #endregion

            #region radspreadprocessing-features-sorting_6
            worksheet.Cells[3, 0, 17, 7].Sort(condition1, condition2, condition3);
            #endregion
        }

        public void ClearSorting(Worksheet worksheet)
        {
            #region radspreadprocessing-features-sorting_7
            worksheet.SortState.Clear();
            #endregion
        }
    }
}
