using System;
using System.Linq;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ModelComment
{
    public class UserControl_Cs
    {
        private void CreateComment(RadFlowDocument document, Paragraph paragraph)
        {
            #region radwordsprocessing-model-comment_0
            Comment comment = document.Comments.AddComment();
            paragraph.Inlines.Add(comment.CommentRangeStart);
            paragraph.Inlines.AddRun("text");
            paragraph.Inlines.Add(comment.CommentRangeEnd);
            #endregion
        }

        private void InsertComment(RadFlowDocumentEditor editor, Comment comment)
        {
            #region radwordsprocessing-model-comment_1
            editor.InsertComment(comment);
            #endregion

        }

        private void InsertComment2()
        {
            #region radwordsprocessing-model-comment_2
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(new RadFlowDocument());

            Run run = editor.InsertText("text");
            editor.InsertComment("My sample comment.", run, run);
            #endregion
        }

        private void AddBlockToComment(Comment comment)
        {
            #region radwordsprocessing-model-comment_3
            Paragraph paragraph = comment.Blocks.AddParagraph();
            Table table = comment.Blocks.AddTable();
            #endregion
        }
    }
}
