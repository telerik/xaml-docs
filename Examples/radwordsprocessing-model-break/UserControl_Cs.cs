using System;
using System.Linq;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ModelBreak
{
    public class UserControl_Cs
    {
        private void AddBreak(RadFlowDocument document, Paragraph paragraph)
        {
            #region radwordsprocessing-model-break_0
            Break br = new Break(document);
            paragraph.Inlines.Add(br);
            #endregion

            #region radwordsprocessing-model-break_1
            br.BreakType = BreakType.PageBreak;
            #endregion
        }

        private void InsertBreak()
        {
            #region radwordsprocessing-model-break_2
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(new RadFlowDocument());
            Break br = editor.InsertBreak(BreakType.PageBreak);
            #endregion
        }

        private void CustomizeBreak()
        {
            #region radwordsprocessing-model-break_3
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(new RadFlowDocument());

            Break br = editor.InsertBreak(BreakType.PageBreak);
            br.BreakType = BreakType.LineBreak;
            br.TextWrappingRestartLocation = TextWrappingRestartLocation.NextFullLine;
            #endregion
        }
    }
}
