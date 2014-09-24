using System;
using System.Linq;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;
using Telerik.Windows.Documents.Flow.Model.Fields;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ConceptsFields
{
    public class UserControl_Cs
    {
        private void InsertDateFieldRadFlowDocumentEditor()
        {
            #region radwordsprocessing-concepts-fields_0
            RadFlowDocument document = new RadFlowDocument();
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(document);
            editor.InsertField("DATE", "10/11/2012");
            #endregion
        }

        private void InsertDateField()
        {
            #region radwordsprocessing-concepts-fields_1
            // Create a document with paragraph            
            RadFlowDocument document = new RadFlowDocument();
            Paragraph paragraph = document.Sections.AddSection().Blocks.AddParagraph();

            // Create the field info
            FieldInfo field = new FieldInfo(document);

            // Create and add all the inlines to the paragraph.
            paragraph.Inlines.Add(field.Start);
            paragraph.Inlines.AddRun("AUTHOR");
            paragraph.Inlines.Add(field.Separator);
            paragraph.Inlines.AddRun("John Doe");
            paragraph.Inlines.Add(field.End);
            #endregion
        }

        private void UpdateField()
        {
            #region radwordsprocessing-concepts-fields_2
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(new RadFlowDocument());
            FieldInfo fieldInfo = editor.InsertField("DATE \\@ dd/MM/yyyy", "result");
            Console.WriteLine(fieldInfo.GetResult()); // Output: result
            fieldInfo.UpdateField();
            Console.WriteLine(fieldInfo.GetResult()); // Output: 06/06/2014
            #endregion
        }

        private void UpdateAllFields()
        {
            #region radwordsprocessing-concepts-fields_3
            RadFlowDocument document = new RadFlowDocument();
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(document);
            FieldInfo fieldInfo = editor.InsertField("DATE \\@ dd/MM/yyyy", "result");

            Console.WriteLine(fieldInfo.GetResult()); // Output: result
            document.UpdateFields();
            Console.WriteLine(fieldInfo.GetResult()); // Output: 06/06/2014
            #endregion
        }

        private void NestedField()
        {
            #region radwordsprocessing-concepts-fields_4
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(new RadFlowDocument());

            // Create an outer field with empty code fragment
            FieldInfo outerFieldInfo = editor.InsertField(string.Empty, "if field result");

            // Move the editor after the field start character
            editor.MoveToInlineEnd(outerFieldInfo.Start);

            // Create the a code fragment with a nested TIME field
            editor.InsertText("IF ");
            editor.InsertField("TIME \\@ HH", "time field result");
            editor.InsertText(" < 12 \"Good morning!\" \"Good afternoon!\"");

            outerFieldInfo.UpdateField();
            Console.WriteLine(outerFieldInfo.GetResult()); // Output: Good afternoon!
            #endregion
        }

    }
}
