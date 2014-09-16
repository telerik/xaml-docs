using System;
using System.IO;
using System.Linq;
using Telerik.Windows.Documents.Flow.FormatProviders.Docx;
using Telerik.Windows.Documents.Flow.Model;

namespace RadWordsProcessingDocumentationSourceCode.Examples.FormatsAndConversionDocxFormatProvider
{
    public class UserControl_Cs
    {
        private void ImportFromFile()
        {
            #region radwordsprocessing-formats-and-conversion-docx-docxformatprovider_0
            DocxFormatProvider provider = new DocxFormatProvider();
            using (Stream input = File.OpenRead("Sample.docx"))
            {
                RadFlowDocument document = provider.Import(input);
            }
            #endregion
        }

        private void ImportFromByteArray(byte[] input)
        {
            #region  radwordsprocessing-formats-and-conversion-docx-docxformatprovider_1
            DocxFormatProvider provider = new DocxFormatProvider();
            RadFlowDocument document = provider.Import(input);
            #endregion
        }

        private void ExportToFile()
        {
            #region  radwordsprocessing-formats-and-conversion-docx-docxformatprovider_2
            DocxFormatProvider provider = new DocxFormatProvider();
            using (Stream output = File.OpenWrite("Sample.docx"))
            {
                RadFlowDocument document = CreateRadFlowDocument();
                provider.Export(document, output);
            }
            #endregion
        }

        private void ExportToArray()
        {
            #region  radwordsprocessing-formats-and-conversion-docx-docxformatprovider_3
            DocxFormatProvider provider = new DocxFormatProvider();

            RadFlowDocument document = CreateRadFlowDocument();
            byte[] output = provider.Export(document);
            #endregion
        }

        private RadFlowDocument CreateRadFlowDocument()
        {
            return new RadFlowDocument();
        }
    }
}
