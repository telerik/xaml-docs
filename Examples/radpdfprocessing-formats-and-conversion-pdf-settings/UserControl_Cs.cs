using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Documents.Fixed.FormatProviders.Pdf;
using Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Export;
using Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Import;
using Telerik.Windows.Documents.Fixed.Model;

namespace PdfProcessingDocumentationSourceCode.Examples.FormatsAndConversionPdfSettings
{
    public class UserControl_Cs
    {
        private void ImportSettings()
        {
            #region radpdfprocessing-formats-and-conversion-pdf-settings_0
            PdfFormatProvider provider = new PdfFormatProvider();
            PdfImportSettings settings = new PdfImportSettings();
            settings.UserPasswordNeeded += (s, a) =>
            {
                a.Password = "D0cum3ntP4ssw0rd";
            };

            provider.ImportSettings = settings;
            #endregion
        }

        private void Export()
        {
            #region radpdfprocessing-formats-and-conversion-pdf-settings_1
            PdfFormatProvider provider = new PdfFormatProvider();
            PdfExportSettings settings = new PdfExportSettings();
            settings.IsEncrypted = true;
            settings.UserPassword = "D0cum3ntP4ssw0rd";
            settings.ImageQuality = ImageQuality.High;

            provider.ExportSettings = settings;
            #endregion
        }
    }
}
