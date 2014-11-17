using System;
using System.Linq;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;
using Telerik.Windows.Documents.Flow.Model.Shapes;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ModelParagraph
{
    public class UserControl_Cs
    {
        private void CreateParagraph(RadFlowDocument document, Section section)
        {
            #region radwordsprocessing-model-paragraph_0
            Paragraph paragraph = new Paragraph(document);
            section.Blocks.Add(paragraph);
            #endregion
        }

        private void InsertParagraph(RadFlowDocument document, Section section)
        {
            #region radwordsprocessing-model-paragraph_1
            Paragraph paragraph = new Paragraph(document);
            section.Blocks.Insert(0, paragraph);
            #endregion
        }

        private void CreateParagraphWithMethod(Section section)
        {
            #region radwordsprocessing-model-paragraph_2
            Paragraph paragraph = section.Blocks.AddParagraph();
            #endregion
        }

        private void CreateParagraphWithRadFlowDocumentEditor()
        {
            #region radwordsprocessing-model-paragraph_3
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(new RadFlowDocument());
            Paragraph paragraph = editor.InsertParagraph();
            #endregion
        }

        private void AddInlinesToParagraph(Paragraph paragraph)
        {
            #region radwordsprocessing-model-paragraph_4
            Run run = paragraph.Inlines.AddRun();
            #endregion

            #region radwordsprocessing-model-paragraph_5
            ImageInline imageInline = paragraph.Inlines.AddImageInline();
            #endregion

            #region radwordsprocessing-model-paragraph_6
            FloatingImage floatingImage = paragraph.Inlines.AddFloatingImage();
            #endregion
        }


    }
}
