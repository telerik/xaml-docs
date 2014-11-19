using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace CellsGetSetClearCellProperties
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void Demo()
        {
            #region radspreadprocessing-working-with-cells-get-set-clear-properties_0
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            CellSelection selection = worksheet.Cells[0, 0, 5, 5];
            #endregion
        }

        public void GetSetClearIsBold()
        {
            #region radspreadprocessing-working-with-cells-get-set-clear-properties_1
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            CellSelection selection = worksheet.Cells[0, 0, 5, 5];

            selection.SetIsBold(true);
            bool isBold = selection.GetIsBold().Value;
            selection.ClearIsBold();
            #endregion
        }

        public void GetSetCellValue()
        {
            #region radspreadprocessing-working-with-cells-get-set-clear-properties_7
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            CellSelection selection = worksheet.Cells[1, 1];

            ICellValue cellValue = selection.GetValue().Value;
            #endregion

            #region radspreadprocessing-working-with-cells-get-set-clear-properties_2
            // set DateTime value
            selection.SetValue(DateTime.Now);

            // set double value
            selection.SetValue(51.345);

            // set ICellValue
            ICellValue value = worksheet.Cells[5, 5].GetValue().Value;
            selection.SetValue(value);

            // set string value
            selection.SetValue("Total");

            // set formula value
            selection.SetValue("=C1+C10");
            #endregion
        }

        public void GetSetCellBorders()
        {
            #region radspreadprocessing-working-with-cells-get-set-clear-properties_3
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            ThemableColor purple = new ThemableColor(Color.FromRgb(155, 89, 182));
            ThemableColor darkBlue = new ThemableColor(Color.FromRgb(44, 62, 80));

            CellBorders purpleBorders = new CellBorders(new CellBorder(CellBorderStyle.Dotted, purple));
            worksheet.Cells[1, 1, 2, 2].SetBorders(purpleBorders);

            CellBorders darkBlueBorders = new CellBorders(
                new CellBorder(CellBorderStyle.Medium, darkBlue),   // Left border
                new CellBorder(CellBorderStyle.Medium, darkBlue),   // Top border
                new CellBorder(CellBorderStyle.Medium, darkBlue),   // Right border
                new CellBorder(CellBorderStyle.Medium, darkBlue),   // Bottom border
                new CellBorder(CellBorderStyle.Thin, purple),       // Inside horizontal border
                new CellBorder(CellBorderStyle.Thin, purple),       // Inside vertical border
                new CellBorder(CellBorderStyle.None, darkBlue),     // Diagonal up border
                new CellBorder(CellBorderStyle.None, darkBlue));    // Diagonal down border

            worksheet.Cells[1, 4, 2, 5].SetBorders(darkBlueBorders);
            #endregion
        }

        public void SetPatternFill()
        {
            #region radspreadprocessing-working-with-cells-get-set-clear-properties_4
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            PatternFill diagonalStripePatternFill = new PatternFill(PatternType.DiagonalStripe, Color.FromRgb(231, 76, 60), Color.FromRgb(241, 196, 15));
            worksheet.Cells[0, 0, 0, 5].SetFill(diagonalStripePatternFill);

            PatternFill solidPatternFill = new PatternFill(PatternType.Solid, Color.FromRgb(46, 204, 113), Colors.Transparent);
            worksheet.Cells[1, 0, 5, 5].SetFill(solidPatternFill);
            #endregion
        }

        public void SetGradientFill()
        {
            #region radspreadprocessing-working-with-cells-get-set-clear-properties_5
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Rows[0].SetHeight(new RowHeight(50, true));

            GradientFill greenGradientFill = new GradientFill(GradientType.Horizontal, Color.FromRgb(46, 204, 113), Color.FromRgb(0, 134, 56));
            worksheet.Cells[0, 0, 0, 5].SetFill(greenGradientFill);
            #endregion
        }

        public void IncreaseDecreaseIndent()
        {
            #region radspreadprocessing-working-with-cells-get-set-clear-properties_6
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            CellSelection selection = worksheet.Cells[0, 0, 5, 5];

            selection.IncreaseIndent();
            selection.DecreaseIndent();
            #endregion
        }

        public void IsIndeterminateExample()
        {
            #region IsIndeterminateDemo

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            worksheet.Cells[0, 0].SetStyleName("Good");
            worksheet.Cells[0, 1].SetStyleName("Bad");

            RangePropertyValue<string> cell00Value = worksheet.Cells[0, 0].GetStyleName();
            //cell at [0, 0] cell00Value.IsIndeterminate is False, cell00Value.Value is Good

            RangePropertyValue<string> cell01Value = worksheet.Cells[0, 1].GetStyleName();
            //cell at [0, 0] cell01Value.IsIndeterminate is False, cell01Value.Value is Bad

            RangePropertyValue<string> twoCellsValue = worksheet.Cells[0, 0, 0, 1].GetStyleName();
            //cells at [0, 0, 0, 1] twoCellsValue.IsIndeterminate is True, twoCellsValue.Value is Normal

            #endregion
        }
    }
}
