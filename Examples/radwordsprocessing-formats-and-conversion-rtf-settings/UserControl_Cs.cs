using System;
using System.Linq;
using Telerik.Windows.Documents.Flow.FormatProviders.Docx;
using Telerik.Windows.Documents.Flow.FormatProviders.Rtf;
using Telerik.Windows.Documents.Flow.FormatProviders.Rtf.Export;

namespace RadWordsProcessingDocumentationSourceCode.Examples.FormatsAndConversionRtfSettings
{
    public class UserControl_Cs
    {
        private void AppkyExportSettings()
        {
            #region radwordsprocessing-formats-and-conversion-rtf-settings_0
            RtfFormatProvider provider = new RtfFormatProvider();
            RtfExportSettings exportSettings = new RtfExportSettings();
            exportSettings.ExportImagesInCompatibilityMode = true;
            provider.ExportSettings = exportSettings;
            #endregion
        }
    }
}
