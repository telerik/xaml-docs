using System;
using System.IO;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.Common;
using Telerik.Windows.Documents.Fixed.Model.Data;
using Telerik.Windows.Documents.Fixed.Model.Editing;

namespace PdfProcessingDocumentationSourceCode.Examples.EditingFixedContentEditor
{
    public class UserControl_Cs
    {
        private void CreateFixedContentEditor(IContentRootElement contentRootElement)
        {
            #region radpdfprocessing-editing-fixedcontenteditor_0
            FixedContentEditor editor = new FixedContentEditor(contentRootElement);
            #endregion
        }

        private void CreateFixedContentEditorWithPosition(IContentRootElement contentRootElement, IPosition initialPosition)
        {
            #region radpdfprocessing-editing-fixedcontenteditor_1
            FixedContentEditor editor = new FixedContentEditor(contentRootElement, initialPosition);
            #endregion
        }

        private void InsertTextFragment(FixedContentEditor editor)
        {
            #region radpdfprocessing-editing-fixedcontenteditor_2
            editor.DrawText("First text fragment.");
            #endregion

            #region radpdfprocessing-editing-fixedcontenteditor_3
            using (editor.BeginText())
            {
                editor.DrawText("First sentence.");
                editor.DrawText("Second sentence.");
            }
            #endregion
        }

        private void InsertImage(FixedContentEditor editor)
        {
            #region radpdfprocessing-editing-fixedcontenteditor_4
            using (Stream stream = this.GetResourceStream("Telerik_logo.jpg"))
            {
                editor.DrawImage(stream, ImageFormat.Jpeg, new Size(118, 28));
            }
            #endregion
        }

        private void InsertGemotery(FixedContentEditor editor)
        {
            #region radpdfprocessing-editing-fixedcontenteditor_5
            editor.DrawEllipse(new Point(250, 70), 136, 48);
            #endregion
        }

        private void InsertClipping(FixedContentEditor editor)
        {
            #region radpdfprocessing-editing-fixedcontenteditor_6
            string visibleText = "The last word in this text is";
            string text = string.Format("{0} clipped.", visibleText); //The last word in this text is clipped.
            Size visisibleTextSize = editor.MeasureText(visibleText);

            using (editor.PushClipping(new Rect(new Point(0, 0), visisibleTextSize)))
            {
                editor.DrawText(text);
            }
            #endregion

        }

        private void Positioning(FixedContentEditor editor)
        {
            #region radpdfprocessing-editing-fixedcontenteditor_7
            editor.Position.Scale(1.5, 0.5);
            editor.Position.Rotate(10);
            editor.DrawText("Image:");
            editor.Position.Translate(0, 20);
            using (Stream stream = this.GetResourceStream("Telerik_logo.jpg"))
            {
                editor.DrawImage(stream, ImageFormat.Jpeg, new Size(118, 28));
            }
            #endregion
        }

        private Stream GetResourceStream(string p)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
