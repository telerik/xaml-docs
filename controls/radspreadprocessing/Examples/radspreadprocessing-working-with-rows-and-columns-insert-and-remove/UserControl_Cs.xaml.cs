using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace RowsAndColumnsInsertRemove
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void InsertRows()
        {
            #region radspreadprocessing-working-with-rows-and-columns-insert-and-remove_0
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            int index = 2;
            int itemCount = 3;

            if (worksheet.Rows.CanInsert(index, itemCount))
            {
                RowSelection selection = worksheet.Rows[index, index + itemCount];
                selection.Insert();
            }
            #endregion
        }

        public void RemoveRows()
        {
            #region radspreadprocessing-working-with-rows-and-columns-insert-and-remove_1
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            int index = 2;
            int itemCount = 3;

            RowSelection selection = worksheet.Rows[index, index + itemCount];
            selection.Remove();
            #endregion
        }

        public void InsertColumns()
        {
            #region radspreadprocessing-working-with-rows-and-columns-insert-and-remove_2
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            int index = 2;
            int itemCount = 3;

            if (worksheet.Columns.CanInsert(index, itemCount))
            {
                ColumnSelection selection = worksheet.Columns[index, index + itemCount];
                selection.Insert();
            }
            #endregion
        }

        public void RemoveColumns()
        {
            #region radspreadprocessing-working-with-rows-and-columns-insert-and-remove_3
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            int index = 2;
            int itemCount = 3;

            ColumnSelection selection = worksheet.Columns[index, index + itemCount];
            selection.Remove();
            #endregion
        }
    }
}