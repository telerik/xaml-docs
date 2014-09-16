using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows;
using Telerik.Windows.Controls;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace FeaturesFindAndReplace
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static void FindDemo()
        {
            #region radspreadsheet-features-find-and-replace_0
            Workbook workbook = new Workbook();
            Worksheet worksheet1 = workbook.Worksheets.Add();
            Worksheet worksheet2 = workbook.Worksheets.Add();

            worksheet1.Cells[1, 1].SetValue("SUMMARY");
            worksheet1.Cells[1, 2].SetValue("=SUM(5, 6)");

            worksheet2.Cells[2, 2].SetValue("=SUM(4, 4)");
            worksheet2.Cells[2, 3].SetValue("SUM");

            FindOptions options = new FindOptions()
            {
                StartCell = new WorksheetCellIndex(worksheet1, 0, 0),
                FindBy = FindBy.Rows,
                FindIn = FindInContentType.Formulas,
                FindWhat = "SUM",
                FindWithin = FindWithin.Workbook,
            };

            FindResult findResult = workbook.Find(options);
            IEnumerable<FindResult> findResults = workbook.FindAll(options);
            #endregion
        }

        public void ReplaceDemo()
        {
            #region radspreadsheet-features-find-and-replace_1
            Workbook workbook = new Workbook();
            Worksheet worksheet1 = workbook.Worksheets.Add();
            Worksheet worksheet2 = workbook.Worksheets.Add();

            worksheet1.Cells[1, 1].SetValue("SUMMARY");
            worksheet1.Cells[1, 2].SetValue("=SUM(5, 6)");

            worksheet2.Cells[2, 2].SetValue("=SUM(4, 4)");
            worksheet2.Cells[2, 3].SetValue("SUM");

            ReplaceOptions options = new ReplaceOptions()
            {
                StartCell = new WorksheetCellIndex(worksheet1, 0, 0),
                FindBy = FindBy.Rows,
                FindIn = FindInContentType.Formulas,
                FindWhat = "SUM",
                ReplaceWith = "Test",
                FindWithin = FindWithin.Workbook,
            };

            var findResult = workbook.Find(options);

            options.StartCell = findResult.FoundCell;

            if (workbook.Replace(options))
            {
                RadWindow.Alert("Replace was successful!");
            }

            workbook.ReplaceAll(options);
            #endregion
        }
    }
}