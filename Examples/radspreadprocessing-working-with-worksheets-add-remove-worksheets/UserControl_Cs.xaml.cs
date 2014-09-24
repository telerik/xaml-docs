using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace WorksheetAddRemoveWorksheets
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void AddWorksheet()
        {
            #region radspreadprocessing-working-with-worksheets-add-remove-worksheets_0
            Workbook workbook = new Workbook();
            Worksheet newWorksheet = workbook.Worksheets.Add();
            #endregion
        }

        public void RemoveWorksheet()
        {
            #region radspreadprocessing-working-with-worksheets-add-remove-worksheets_1
            Workbook workbook = new Workbook();
            workbook.Worksheets.Add(); // Sheet1
            Worksheet secondWorksheet = workbook.Worksheets.Add(); // Sheet2
            workbook.Worksheets.Add(); // Sheet3
            workbook.Worksheets.Add(); // Sheet4

            workbook.Worksheets.RemoveAt(3); // Removed Sheet4
            workbook.Worksheets.Remove("Sheet1"); // Removed Sheet1
            workbook.Worksheets.Remove(secondWorksheet); // Removed Sheet2
            // the only worksheet left is Sheet3
            #endregion
        }
    }
}