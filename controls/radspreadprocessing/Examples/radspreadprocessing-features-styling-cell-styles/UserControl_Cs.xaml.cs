using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.PropertySystem;
using Telerik.Windows.Documents.Spreadsheet.Theming;
using Telerik.Windows.Documents.Spreadsheet.Utilities;

namespace FeaturesStylingCellStyles
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void IncludeNumberGroup()
        {
            #region radspreadprocessing-features-styling-cell-styles_0
            Workbook workbook = new Workbook();
            CellStyle tempStyle = workbook.Styles["Bad"];
            tempStyle.IncludeNumber = true;
            #endregion
        }

        public void CreateCellStyle()
        {
            #region radspreadprocessing-features-styling-cell-styles_1
            Workbook workbook = new Workbook();
            workbook.Worksheets.Add();

            CellStyle cellStyle = workbook.Styles.Add("My style", CellStyleCategory.Custom);

            cellStyle.BeginUpdate();

            CellBorder border = new CellBorder(CellBorderStyle.DashDotDot, new ThemableColor(Colors.Red));
            cellStyle.LeftBorder = border;
            cellStyle.TopBorder = border;
            cellStyle.RightBorder = border;
            cellStyle.BottomBorder = border;

            ThemableColor patternColor = new ThemableColor(ThemeColorType.Accent1);
            ThemableColor backgroundColor = new ThemableColor(ThemeColorType.Accent5, ColorShadeType.Shade2);
            IFill fill = new PatternFill(PatternType.Gray75Percent, patternColor, backgroundColor);
            cellStyle.Fill = fill;

            cellStyle.HorizontalAlignment = RadHorizontalAlignment.Left;
            cellStyle.VerticalAlignment = RadVerticalAlignment.Center;

            cellStyle.EndUpdate();

            workbook.ActiveWorksheet.Cells[0, 0].SetStyleName("My style");
            #endregion
        }

        public void ModifyCellStyle()
        {
            #region radspreadprocessing-features-styling-cell-styles_2
            Workbook workbook = new Workbook();
            workbook.Worksheets.Add();

            CellStyle style = workbook.Styles["Bad"];

            style.BeginUpdate();

            style.Fill = new PatternFill(PatternType.DiagonalCrosshatch, Colors.Red, Colors.Transparent);
            style.FontSize = UnitHelper.PointToDip(20);
            style.ForeColor = new ThemableColor(Colors.Black);

            style.EndUpdate();
            #endregion
        }

        public void RemoveCellStyle()
        {
            #region radspreadprocessing-features-styling-cell-styles_3
            Workbook workbook = new Workbook();
            workbook.Worksheets.Add();

            if (workbook.Styles.Remove("Bad"))
            {
                Debug.WriteLine("Style removed");
            }
            else
            {
                Debug.WriteLine("The style does not exist");
            }
            #endregion
        }
    }
}
