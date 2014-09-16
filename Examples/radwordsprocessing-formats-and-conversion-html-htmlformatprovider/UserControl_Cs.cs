using System;
using System.IO;
using System.Linq;
using Telerik.Windows.Documents.Flow.FormatProviders.Docx;
using Telerik.Windows.Documents.Flow.FormatProviders.Html;
using Telerik.Windows.Documents.Flow.Model;

namespace RadWordsProcessingDocumentationSourceCode.Examples.FormatsAndConversionHtmlFormatProvider
{
    public class UserControl_Cs
    {
        private void ImportFromFile()
        {
            #region radwordsprocessing-formats-and-conversion-html-htmlformatprovider_0
            using (Stream input = File.Create(@"Sample.html"))
            {
                HtmlFormatProvider provider = new HtmlFormatProvider();
                RadFlowDocument document = provider.Import(input);
            }
            #endregion
        }

        private void ImportFromString()
        {
            #region radwordsprocessing-formats-and-conversion-html-htmlformatprovider_1
            string html = "<p>hello world!</p>";
            HtmlFormatProvider provider = new HtmlFormatProvider();
            RadFlowDocument document = provider.Import(html);
            #endregion
        }

        private void ExportToFile()
        {
            #region radwordsprocessing-formats-and-conversion-html-htmlformatprovider_2
            HtmlFormatProvider provider = new HtmlFormatProvider();
            using (Stream output = File.Create("Sample.html"))
            {
                RadFlowDocument document = CreateRadFlowDocument();
                provider.Export(document, output);
            }
            #endregion
        }

        private RadFlowDocument CreateRadFlowDocument()
        {
            throw new NotImplementedException();
        }

        private void ExportToString()
        {
            #region radwordsprocessing-formats-and-conversion-html-htmlformatprovider_3
            RadFlowDocument document = CreateRadFlowDocument();
            HtmlFormatProvider provider = new HtmlFormatProvider();
            string html = provider.Export(document);
            #endregion
        }

    }
}
