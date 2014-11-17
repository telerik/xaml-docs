using System;
using System.IO;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;
using Telerik.Windows.Documents.Flow.Model.Shapes;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ModelInlineImage
{
    public class UserControl_Cs
    {
        private void CreateInlineImage(RadFlowDocument document, Paragraph paragraph)
        {
            #region radwordsprocessing-model-imageinline_0
            ImageInline imageInline = new ImageInline(document);
            paragraph.Inlines.Add(imageInline);
            #endregion
        }

        private void AddInlineImageAtIndex(RadFlowDocument document, Paragraph paragraph)
        {
            #region radwordsprocessing-model-imageinline_1
            ImageInline imageInline = new ImageInline(document);
            paragraph.Inlines.Insert(0, imageInline);
            #endregion
        }

        private void CreateInlineImageAndAddToParagraph(Paragraph paragraph)
        {
            #region radwordsprocessing-model-imageinline_2
            ImageInline imageInline = paragraph.Inlines.AddImageInline();
            #endregion
        }

        private void InsertImageWithRadFlowDocument(RadFlowDocument document)
        {
            #region radwordsprocessing-model-imageinline_3
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(document);

            using (Stream stream = this.GetResourceStream("Telerik_logo.png"))
            {
                editor.InsertImageInline(stream, "png", new Size(118, 28));
            }
            #endregion
        }

        private Stream GetResourceStream(string p)
        {
            throw new NotImplementedException();
        }
    }
}
