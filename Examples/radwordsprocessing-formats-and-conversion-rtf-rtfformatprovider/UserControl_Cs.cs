using System;
using System.IO;
using System.Linq;
using Telerik.Windows.Documents.Flow.FormatProviders.Docx;
using Telerik.Windows.Documents.Flow.FormatProviders.Rtf;
using Telerik.Windows.Documents.Flow.Model;

namespace RadWordsProcessingDocumentationSourceCode.Examples.FormatsAndConversionRtfFormatProvider
{
    public class UserControl_Cs
    {
        private void ImportFromFile()
        {
            #region radwordsprocessing-formats-and-conversion-rtf-rtfformatprovider_0
            RtfFormatProvider provider = new RtfFormatProvider();
            using (Stream input = File.OpenRead("Sample.rtf"))
            {
                RadFlowDocument document = provider.Import(input);
            }
            #endregion
        }

        private void ImportFromString(string input)
        {
            #region radwordsprocessing-formats-and-conversion-rtf-rtfformatprovider_1
            RtfFormatProvider provider = new RtfFormatProvider();
            RadFlowDocument document = provider.Import(input);
            #endregion
        }

        private void ExportToFile()
        {
            #region radwordsprocessing-formats-and-conversion-rtf-rtfformatprovider_2
            RtfFormatProvider provider = new RtfFormatProvider();
            using (Stream output = File.Create("sample.rtf"))
            {
                RadFlowDocument document = CreateRadFlowDocument();
                provider.Export(document, output);
            }
            #endregion
        }

        private void ExportToArray()
        {
            #region radwordsprocessing-formats-and-conversion-rtf-rtfformatprovider_3
            RtfFormatProvider provider = new RtfFormatProvider();
            RadFlowDocument document = CreateRadFlowDocument();
            string output = provider.Export(document);
            #endregion
        }

        private RadFlowDocument CreateRadFlowDocument()
        {
            return new RadFlowDocument();
        }
    }
}
