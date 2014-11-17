using System;
using System.IO;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;
using Telerik.Windows.Documents.Flow.Model.Shapes;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ModelFloatingImage
{
    public class UserControl_Cs
    {
        private void CreateInlineImage(RadFlowDocument document, Paragraph paragraph)
        {
            #region radwordsprocessing-model-floatingimage_0
            FloatingImage floatingImage = new FloatingImage(document);
            paragraph.Inlines.Add(floatingImage);
            #endregion
        }

        private void AddInlineImageAtIndex(RadFlowDocument document, Paragraph paragraph)
        {
            #region radwordsprocessing-model-floatingimage_1
            FloatingImage floatingImage = new FloatingImage(document);
            paragraph.Inlines.Insert(0, floatingImage);
            #endregion
        }

        private void CreateInlineImageAndAddToParagraph(Paragraph paragraph)
        {
            #region radwordsprocessing-model-floatingimage_2
            FloatingImage floatingImage = paragraph.Inlines.AddFloatingImage();
            #endregion
        }

        private void InsertImageWithRadFlowDocument(RadFlowDocument document)
        {
            #region radwordsprocessing-model-floatingimage_3
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(document);

            using (Stream stream = this.GetResourceStream("Telerik_logo.png"))
            {
                editor.InsertFloatingImage(stream, "png", new Size(118, 28));
            }
            #endregion
        }

        private Stream GetResourceStream(string p)
        {
            throw new NotImplementedException();
        }
    }
}
