using System;
using System.IO;
using Telerik.Windows.Documents.Fixed.FormatProviders.Pdf;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.Editing;

namespace PdfProcessingDocumentationSourceCode.Examples.FormatsAndConversionPdfPdfFormatProvider
{
    public class UserControl_Cs
    {
        private void Import()
        {
            #region radpdfprocessing-formats-and-conversion-pdf-pdfformatprovider_0
            PdfFormatProvider provider = new PdfFormatProvider();
            using (Stream input = File.OpenRead("Sample.pdf"))
            {
                RadFixedDocument document = provider.Import(input);
            }
            #endregion
        }

        private void Export()
        {
            #region radpdfprocessing-formats-and-conversion-pdf-pdfformatprovider_1
            PdfFormatProvider provider = new PdfFormatProvider();
            using (Stream output = File.OpenWrite("sample.pdf"))
            {
                RadFixedDocument document = CreateRadFixedDocument();
                provider.Export(document, output);
            }
            #endregion
        }

        private RadFixedDocument CreateRadFixedDocument()
        {
            throw new NotImplementedException();
        }
    }
}
