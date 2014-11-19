using System;
using System.Linq;
using System.Windows.Media;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.ColorSpaces;
using Telerik.Windows.Documents.Fixed.Model.Editing;
using Telerik.Windows.Documents.Fixed.Model.Editing.Tables;

namespace PdfProcessingDocumentationSourceCode.Examples.EditingTableCell
{
    public class UserControl_Cs
    {
        private void CreateTable(RadFixedDocument radFixedDocument, FontFamily fontFamily)
        {
            #region radpdfprocessing-editing-tablecell_0
            Table table = new Table();
            TableRow firstRow = table.Rows.AddTableRow();
            TableCell firstCell = firstRow.Cells.AddTableCell();
            #endregion

            #region radpdfprocessing-editing-tablecell_1
            Block block = firstCell.Blocks.AddBlock();
            block.InsertText("Text in the cell.");
            #endregion

            #region radpdfprocessing-editing-tablecell_2
            firstCell.RowSpan = 2;
            firstCell.ColumnSpan = 2;
            firstCell.Borders = new TableCellBorders(new Border(1, new RgbColor(150, 0, 0)));
            firstCell.Background = new RgbColor(255, 100, 100);
            #endregion
        }
    }
}
