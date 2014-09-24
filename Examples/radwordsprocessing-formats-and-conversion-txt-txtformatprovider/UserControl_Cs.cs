using System;
using System.IO;
using System.Linq;
using Telerik.Windows.Documents.Flow.FormatProviders.Txt;
using Telerik.Windows.Documents.Flow.Model;

namespace RadWordsProcessingDocumentationSourceCode.Examples.FormatsAndConversionTxtFormatProvider
{
    public class UserControl_Cs
    {
        private void ImportFromFile()
        {
            #region radwordsprocessing-formats-and-conversion-txt-txtformatprovider_0
            TxtFormatProvider provider = new TxtFormatProvider();
            using (Stream input = File.OpenRead("Sample.txt"))
            {
                RadFlowDocument document = provider.Import(input);
            }
            #endregion
        }

        private void ImportFromString(string input)
        {
            #region radwordsprocessing-formats-and-conversion-txt-txtformatprovider_1
            TxtFormatProvider provider = new TxtFormatProvider();
            RadFlowDocument document = provider.Import(input);
            #endregion
        }

        private void ExportToFile()
        {
            #region radwordsprocessing-formats-and-conversion-txt-txtformatprovider_2
            TxtFormatProvider provider = new TxtFormatProvider();
            using (Stream output = File.OpenWrite("sample.txt"))
            {
                RadFlowDocument document = CreateRadFlowDocument();
                provider.Export(document, output);
            }
            #endregion
        }

        private void ExportToArray()
        {
            #region radwordsprocessing-formats-and-conversion-txt-txtformatprovider_3
            TxtFormatProvider provider = new TxtFormatProvider();
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
