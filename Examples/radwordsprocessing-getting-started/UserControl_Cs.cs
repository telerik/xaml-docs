using System;
using System.IO;
using System.Linq;
using Telerik.Windows.Documents.Flow.FormatProviders.Docx;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;

namespace RadWordsProcessingDocumentationSourceCode.Examples.GettingStarted
{
    public class UserControl_Cs
    {
        private void CreateRadFlowDocument()
        {
            #region radwordsprocessing-getting-started_0
            RadFlowDocument document = new RadFlowDocument();
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(document);
            editor.InsertText("Hello world!");
            #endregion
        }

        private void ExportToDocx(RadFlowDocument document)
        {
            #region radwordsprocessing-getting-started_1
            using (Stream output = new FileStream("output.docx", FileMode.OpenOrCreate))
            {
                DocxFormatProvider provider = new DocxFormatProvider();
                provider.Export(document, output);
            }
            #endregion
        }


    }
}
