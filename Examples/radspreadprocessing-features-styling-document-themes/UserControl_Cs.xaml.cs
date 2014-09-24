using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Theming;

namespace FeaturesStylingDocumentThemes
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void Demo()
        {
            #region radspreadprocessing-features-styling-document-themes_0
            ThemeColorScheme colorScheme = new ThemeColorScheme(
                "Mine",
                Colors.Black,     // background 1
                Colors.Blue,      // text 1
                Colors.Brown,     // background 2
                Colors.Cyan,      // text 2
                Colors.DarkGray,  // accent 1
                Colors.Gray,      // accent 2
                Colors.Green,     // accent 3
                Colors.LightGray, // accent 4
                Colors.Magenta,   // accent 5
                Colors.Orange,    // accent 6
                Colors.Purple,    // hyperlink
                Colors.Red);      // followedHyperlink
            #endregion

            #region radspreadprocessing-features-styling-document-themes_1
            ThemableColor themableColor = new ThemableColor(ThemeColorType.Accent1);
            #endregion

            #region radspreadprocessing-features-styling-document-themes_2
            ThemeFontScheme fontScheme = new ThemeFontScheme(
                "Mine",
                "Times New Roman",  // latinMajor
                "Arial");           // latinMinor
            #endregion

            #region radspreadprocessing-features-styling-document-themes_3
            ThemableFontFamily themableFont = new ThemableFontFamily(ThemeFontType.Major);
            #endregion

            #region radspreadprocessing-features-styling-document-themes_4
            DocumentTheme theme = new DocumentTheme("Mine", colorScheme, fontScheme);
            #endregion

            #region radspreadprocessing-features-styling-document-themes_6
            Workbook workbook = new Workbook();
            workbook.Worksheets.Add();
            workbook.Theme = theme;
            #endregion

            #region radspreadprocessing-features-styling-document-themes_7
            Color actualColor = themableColor.GetActualValue(theme);
            // the actual color is the same as Accent1 color of the colorScheme
            #endregion

            #region radspreadprocessing-features-styling-document-themes_8
            var actualFont = themableFont.GetActualValue(theme);
            // the actualFont is the same as the Major font of the fontScheme
            #endregion

        }

        private void CreateThemeFromPredefinedSchemes()
        {
            #region radspreadprocessing-features-styling-document-themes_5
            DocumentTheme theme = new DocumentTheme("From predefined schemes", PredefinedThemeSchemes.ColorSchemes[0], PredefinedThemeSchemes.FontSchemes[5]);
            #endregion
        }
    }
}
