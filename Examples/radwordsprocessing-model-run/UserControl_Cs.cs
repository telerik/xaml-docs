using System;
using System.Linq;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ModelRun
{
    public class UserControl_Cs
    {
        private void CreateRun(RadFlowDocument document, Paragraph paragraph)
        {
            #region radwordsprocessing-model-run_0
            Run run = new Run(document);
            paragraph.Inlines.Add(run);

            #endregion
        }

        private void AddRunToParagraph(RadFlowDocument document, Paragraph paragraph)
        {
            #region radwordsprocessing-model-run_1
            Run run = new Run(document);
            paragraph.Inlines.Insert(0, run);
            #endregion

            #region radwordsprocessing-model-run_2
            // Adds an empty run.
            Run run1 = paragraph.Inlines.AddRun();

            // Adds a run and set the text to the text property.
            Run run2 = paragraph.Inlines.AddRun("The text.");
            #endregion
        }


        private void CreateRunhWithRadFlowDocumentEditor()
        {
            #region radwordsprocessing-model-run_3
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(new RadFlowDocument());

            // Adds new run to the document
            Run run1 = editor.InsertText("First run ");

            // Adds new run and starts new paragraph
            Run run2 = editor.InsertLine("Second run");
            #endregion
        }
    }
}
