using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Documents.Fixed.Model.Editing;

namespace PdfProcessingDocumentationSourceCode.Examples.EditingBlock
{
    public class UserControl_Cs
    {
        private void InsertText()
        {
            #region radpdfprocessing-editing-block_0
            Block block = new Block();
            block.InsertText("Text");
            #endregion

            #region radpdfprocessing-editing-block_1
            block.InsertText(new FontFamily("Arial"), "Text");
            #endregion

            #region radpdfprocessing-editing-block_2
            //block.InsertText(fontFamily, fontStyle, fontWeight, "Text");
            #endregion
        }

        private void InsertLineBreak(Block block)
        {
            #region radpdfprocessing-editing-block_3
            block.InsertLineBreak();
            #endregion
        }

        private void DrawBlock(Block block, FixedContentEditor fixedContentEditor)
        {
            #region radpdfprocessing-editing-block_4
            Rect boundingRect = new Rect(new Point(0, 0), new Size(200, 300));
            block.Draw(fixedContentEditor, boundingRect);
            #endregion
        }

        private void MeasureBlock()
        {
            #region radpdfprocessing-editing-block_5
            Block block = new Block();
            block.InsertText("Hello RadPdfProcessing!");
            Size size = block.Measure();
            #endregion
        }

        private void MeasureBlockSpecificSize()
        {
            #region radpdfprocessing-editing-block_6
            Block helloBlock = new Block();
            helloBlock.InsertText("Hello");
            Size helloSize = helloBlock.Measure();

            Block block = new Block();
            block.InsertText("Hello RadPdfProcessing!");
            Size size = block.Measure(helloSize);
            Block secondBlock = block.Split();
            #endregion
        }
    }
}
