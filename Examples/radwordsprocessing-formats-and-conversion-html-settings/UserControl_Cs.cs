using System;
using System.Linq;
using Telerik.Windows.Documents.Flow.FormatProviders.Docx;
using Telerik.Windows.Documents.Flow.FormatProviders.Html;
using Telerik.Windows.Documents.Flow.FormatProviders.Rtf;
using Telerik.Windows.Documents.Flow.FormatProviders.Rtf.Export;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Theming;

namespace RadWordsProcessingDocumentationSourceCode.Examples.FormatsAndConversionHtmlSettings
{
    public class UserControl_Cs
    {

        private void ApplyImportSettings()
        {
            #region radwordsprocessing-formats-and-conversion-html-settings_0
            HtmlFormatProvider provider = new HtmlFormatProvider();
            HtmlImportSettings importSettings = new HtmlImportSettings();

            importSettings.GenericFonts.Serif = new ThemableFontFamily("Baskerville");

            byte[] data = this.GetImageData();
            provider.ImportSettings.LoadFromUri += (s, e) =>
            {
                if (e.Uri == "test.jpg")
                {
                    e.SetData(data);
                }
            };

            provider.ImportSettings = importSettings;

            #endregion
        }

        private byte[] GetImageData()
        {
            throw new NotImplementedException();
        }

        private void ApplyExportSettings()
        {
            #region radwordsprocessing-formats-and-conversion-html-settings_1
            HtmlFormatProvider provider = new HtmlFormatProvider();
            HtmlExportSettings exportSettings = new HtmlExportSettings();

            byte[] data = null;
            exportSettings.DocumentExportLevel = DocumentExportLevel.Fragment;
            exportSettings.IndentDocument = true;
            exportSettings.ImageExporting += (s, e) =>
            {
                e.Source = "test.jpg";
                data = e.Image.ImageSource.Data;
                e.Handled = true;
            };

            provider.ExportSettings = exportSettings;
            #endregion
        }
    }
}
