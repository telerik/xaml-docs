using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace RowsAndColumnsResizing
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void ResizeRows()
        {
            #region radspreadprocessing-working-with-rows-and-columns-resizing_0
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            RowSelection rowSelection = worksheet.Rows[5, 7];
            double rowsHeight = rowSelection.GetHeight().Value.Value;
            rowSelection.SetHeight(new RowHeight(rowsHeight + 50, true));
            #endregion
        }

        public void AutoFitRowsHeight()
        {
            #region radspreadprocessing-working-with-rows-and-columns-resizing_1
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            RowSelection rowSelection = worksheet.Rows[5, 7];
            rowSelection.AutoFitHeight();
            #endregion
        }

        public void ResizeColumns()
        {
            #region radspreadprocessing-working-with-rows-and-columns-resizing_2
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            ColumnSelection columnSelection = worksheet.Columns[5, 7];
            double columnWidth = columnSelection.GetWidth().Value.Value;
            columnSelection.SetWidth(new ColumnWidth(columnWidth + 50, true));
            #endregion
        }

        public void AutoFitColumnsWidth()
        {
            #region radspreadprocessing-working-with-rows-and-columns-resizing_3
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            ColumnSelection columnSelection = worksheet.Columns[5, 7];
            columnSelection.AutoFitWidth();
            #endregion
        }

        public void ExpandToFitNumberValuesWidth()
        {
            #region radspreadprocessing-working-with-rows-and-columns-resizing_4
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            ColumnSelection columnSelection = worksheet.Columns[5, 7];
            columnSelection.ExpandToFitNumberValuesWidth();
            #endregion
        }
    }
}