using System;
using System.Linq;
using Telerik.Windows.Documents.Flow.FormatProviders.Docx;

namespace RadWordsProcessingDocumentationSourceCode.Examples.FormatsAndConversionDocxSettings
{
    public class UserControl_Cs
    {
        private void AppkyExportSettings()
        {
            #region radwordsprocessing-formats-and-conversion-docx-settings_0
            DocxFormatProvider provider = new DocxFormatProvider();
            DocxExportSettings exportSettings = new DocxExportSettings();
            exportSettings.AutoUpdateFields = true;
            exportSettings.InvalidDocumentAction = InvalidDocumentAction.ThrowException;
            provider.ExportSettings = exportSettings;
            #endregion
        }
    }
}
