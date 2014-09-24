using System;
using System.Linq;
using System.Windows.Media;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Theming;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ConceptsDocumentThemes
{
    public class UserControl_Cs
    {
        private void CreatingColorScheme()
        {
            #region radwordsprocessing-concepts-document-themes_0
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
        }

        private void CreateThemableColor()
        {
            #region radwordsprocessing-concepts-document-themes_1
            ThemableColor themableColor = new ThemableColor(ThemeColorType.Accent1);
            #endregion
        }

        private void CreateFontScheme()
        {
            #region radwordsprocessing-concepts-document-themes_2
            ThemeFontScheme fontScheme = new ThemeFontScheme(
                "Mine",
                "Times New Roman",   // Major
                "Arial");		   // Minor
            #endregion
        }

        private void CreatheThemableFontFamily()
        {
            #region radwordsprocessing-concepts-document-themes_3
            ThemableFontFamily themableFont = new ThemableFontFamily(ThemeFontType.Major);
            #endregion
        }

        private void CreatingTheme(ThemeColorScheme colorScheme, ThemeFontScheme fontScheme)
        {
            #region radwordsprocessing-concepts-document-themes_4
            DocumentTheme theme = new DocumentTheme("Mine", colorScheme, fontScheme);
            #endregion
        }

        private void CreatingThemeFromPredefinedColorandFontSchemes()
        {
            #region radwordsprocessing-concepts-document-themes_5
            DocumentTheme theme1 = new DocumentTheme("From Predefined schemes", PredefinedThemeSchemes.ColorSchemes[0], PredefinedThemeSchemes.FontSchemes[5]);
            #endregion
        }

        private void ChangingDocumentTheme(DocumentTheme theme)
        {
            #region radwordsprocessing-concepts-document-themes_6
            RadFlowDocument document = new RadFlowDocument();
            document.Theme = theme;
            #endregion
        }

        private void GettingActualValueFromThemableColor(DocumentTheme theme, ThemableColor themableColor)
        {
            #region radwordsprocessing-concepts-document-themes_7
            Color actualColor = themableColor.GetActualValue(theme);
            // the actual color is the same as Accent1 color of the colorScheme
            #endregion
        }

        private void GettingActualValueFromThemableFont(DocumentTheme theme, ThemableFontFamily themableFont)
        {
            #region radwordsprocessing-concepts-document-themes_8
            var actualFont = themableFont.GetActualValue(theme);

            // the actualFont is the same as the Major font of the fontScheme
            #endregion
        }

    }
}
