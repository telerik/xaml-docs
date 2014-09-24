using System;
using System.Linq;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;
using Telerik.Windows.Documents.Flow.Model.Shapes;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ModelBookmark
{
    public class UserControl_Cs
    {
        private void CreateBookmark(RadFlowDocument document, Paragraph paragraph)
        {
            #region radwordsprocessing-model-bookmark_0
            Bookmark bookmark = new Bookmark(document, "MyBookmark");
            paragraph.Inlines.Add(bookmark.BookmarkRangeStart);
            paragraph.Inlines.AddRun("text");
            paragraph.Inlines.Add(bookmark.BookmarkRangeEnd);
            #endregion
        }

        private void InsertDeleteBookmark()
        {
            #region radwordsprocessing-model-bookmark_1
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(new RadFlowDocument());
            Bookmark bookmark = editor.InsertBookmark("MyBookmark");
            #endregion

            #region radwordsprocessing-model-bookmark_2
            editor.DeleteBookmark("MyBookmark");
            #endregion
        }
    }
}
