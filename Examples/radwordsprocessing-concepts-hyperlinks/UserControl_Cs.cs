using System;
using System.Linq;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ConceptsHyperlinks
{
    public class UserControl_Cs
    {
        private void InsertHyperlink(RadFlowDocumentEditor editor)
        {
            #region radwordsprocessing-concepts-hyperlinks_0
            editor.InsertHyperlink("telerik", "http://www.telerik.com", false, "Telerik site");
            #endregion
        }

        private void InsertHyperlinkToBookmark()
        {
            #region radwordsprocessing-concepts-hyperlinks_1
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(new RadFlowDocument());

            // Insert bookmark.
            editor.InsertBookmark("DocumentStart");
            editor.InsertLine("Hello word!");

            // Insert hyperlink pointing to the bookmark.
            editor.InsertHyperlink("Go to start", "DocumentStart", true, "Document start");
            #endregion
        }

    }
}
