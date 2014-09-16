using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace FeaturesMergeAndUnmergeCells
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void MergeA1B2()
        {
            #region radspreadsheet-model-features-merge-and-unmerge-cells_0

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            CellIndex A1Cell = new CellIndex(0, 0);
            CellIndex B2Cell = new CellIndex(1, 1);

            worksheet.Cells[A1Cell, B2Cell].Merge();

            #endregion
        }

        public void MergeAcrossA1B2()
        {
            #region radspreadsheet-model-features-merge-and-unmerge-cells_1

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            CellIndex A1Cell = new CellIndex(0, 0);
            CellIndex B2Cell = new CellIndex(1, 1);
            worksheet.Cells[A1Cell, B2Cell].MergeAcross();

            #endregion
        }

        public void MergeB2C3()
        {
            #region radspreadsheet-model-features-merge-and-unmerge-cells_2

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            CellIndex B2Cell = new CellIndex(1, 1);
            CellIndex C3Cell = new CellIndex(2, 2);
            worksheet.Cells[B2Cell, C3Cell].Merge();

            #endregion
        }

        public void CheckA1IsMerged()
        {
            #region radspreadsheet-model-features-merge-and-unmerge-cells_3

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            CellIndex A1CellIndex = new CellIndex(0, 0);
            bool isA1merged = worksheet.Cells.GetIsMerged(A1CellIndex);

            #endregion
        }

        public void GetContainingMergedRangeForCellA1()
        {
            #region radspreadsheet-model-features-merge-and-unmerge-cells_4

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            CellIndex A1CellIndex = new CellIndex(0, 0);
            CellRange mergedCellRange;
            bool canGetContainingMergedCellRange = worksheet.Cells.TryGetContainingMergedRange(A1CellIndex, out mergedCellRange);

            #endregion
        }

        public void GetAllContainingMergedRangesInRange()
        {
            #region radspreadsheet-model-features-merge-and-unmerge-cells_5

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            CellIndex A1CellIndex = new CellIndex(0, 0);
            CellIndex N33CellIndex = new CellIndex(32, 13);
            CellRange A1N33CellRange = new CellRange(A1CellIndex, N33CellIndex);
            IEnumerable<CellRange> containingMergedCellRanges = worksheet.Cells.GetContainingMergedRanges(A1N33CellRange);

            #endregion
        }

        public void GetAllMergedCells()
        {
            #region radspreadsheet-model-features-merge-and-unmerge-cells_6

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            IEnumerable<CellRange> mergedCellRanges = worksheet.Cells.GetMergedCellRanges();

            #endregion
        }

        public void UnmergeCells()
        {
            #region radspreadsheet-model-features-merge-and-unmerge-cells_7

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            CellIndex B2CellIndex = new CellIndex(1, 1);
            CellIndex D4CellIndex = new CellIndex(3, 3);
            CellRange B2D4CellSelection = new CellRange(B2CellIndex, D4CellIndex);
            worksheet.Cells[B2D4CellSelection].Unmerge();

            #endregion
        }

        public void StartingPoint()
        {
            #region radspreadsheet-model-features-merge-and-unmerge-cells_8
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Cells[0, 0].SetValue("A1");
            worksheet.Cells[1, 0].SetValue("A2");
            worksheet.Cells[0, 1].SetValue("B1");
            worksheet.Cells[1, 1].SetValue("B2");
            #endregion
        }
    }
}
