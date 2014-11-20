using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace WorksheetIterateThroughWorksheets
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void UseIndexers()
        {
            #region radspreadprocessing-working-with-worksheets-iterate-through-worksheets_0
            Workbook workbook = new Workbook();

            WorksheetCollection worksheets = workbook.Worksheets;
            worksheets.Add();
            worksheets.Add();

            Worksheet firstWorksheet = worksheets[0];
            Worksheet secondWorksheet = worksheets["Sheet2"];
            #endregion
        }

        public void IterateWorksheets()
        {
            #region radspreadprocessing-working-with-worksheets-iterate-through-worksheets_1
            Workbook workbook = new Workbook();

            workbook.Worksheets.Add();
            workbook.Worksheets.Add();
            workbook.Worksheets.Add();

            ThemableColor foregroundColor = new ThemableColor(Colors.Red);
            Color backgroundColor = Colors.Green;
            IFill backgroundFill = new PatternFill(PatternType.Solid, backgroundColor, backgroundColor);

            foreach (Worksheet worksheet in workbook.Worksheets)
            {
                CellSelection cell = worksheet.Cells[0, 0];
                cell.SetValue("The name of this worksheet is: " + worksheet.Name);
                cell.SetForeColor(foregroundColor);
                cell.SetFill(backgroundFill);
            }
            #endregion
        }
    }
}