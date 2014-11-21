using System;
using System.IO;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.Common;
using Telerik.Windows.Documents.Fixed.Model.Data;
using Telerik.Windows.Documents.Fixed.Model.Editing;
using Telerik.Windows.Documents.Fixed.Model.Editing.Tables;

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
            Block block = new Block();
            block.InsertText("First sentence.");
            block.InsertText("Second sentence.");
            editor.DrawBlock(block);
            #endregion
        }

        private void InsertImage(FixedContentEditor editor)
        {
            #region radpdfprocessing-editing-fixedcontenteditor_4
            using (Stream stream = this.GetResourceStream("Telerik_logo.jpg"))
            {
                editor.DrawImage(stream, new Size(118, 28));
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
            Block block = new Block();
            block.InsertText(visibleText);
            Size visisibleTextSize = block.Measure();

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
                editor.DrawImage(stream, new Size(118, 28));
            }
            #endregion
        }

        private Stream GetResourceStream(string p)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        private void InsertTable()
        {
            #region radpdfprocessing-editing-fixedcontenteditor_8
            Table table = new Table();
            Border border = new Border();
            table.DefaultCellProperties.Borders = new TableCellBorders(border, border, border, border);
            table.DefaultCellProperties.Padding = new Thickness(10);
            TableRow firstRow = table.Rows.AddTableRow();
            firstRow.Cells.AddTableCell().Blocks.AddBlock().InsertText("First cell");
            firstRow.Cells.AddTableCell().Blocks.AddBlock().InsertText("Second cell");
            firstRow.Cells.AddTableCell().Blocks.AddBlock().InsertText("Third cell");
            TableRow secondRow = table.Rows.AddTableRow();
            secondRow.Cells.AddTableCell().Blocks.AddBlock().InsertText("Forth cell");
            secondRow.Cells.AddTableCell().Blocks.AddBlock().InsertText("Fifth cell");
            secondRow.Cells.AddTableCell().Blocks.AddBlock().InsertText("Sixth cell");

            RadFixedDocument document = new RadFixedDocument();
            RadFixedPage page = document.Pages.AddPage();
            FixedContentEditor editor = new FixedContentEditor(page);
            editor.Position.Translate(10, 10);
            editor.DrawTable(table, new Size(180, double.PositiveInfinity));
            #endregion
        }
    }
}
