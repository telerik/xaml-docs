using System;
using System.Linq;
using System.Windows.Media;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.ColorSpaces;
using Telerik.Windows.Documents.Fixed.Model.Editing;
using Telerik.Windows.Documents.Fixed.Model.Editing.Tables;

namespace PdfProcessingDocumentationSourceCode.Examples.EditingTableRow
{
    public class UserControl_Cs
    {
        private void CreateTable(RadFixedDocument radFixedDocument, FontFamily fontFamily)
        {
            #region radpdfprocessing-editing-tablerow_0
            Table table = new Table();
            TableRow tableRow = table.Rows.AddTableRow();
            #endregion

            #region radpdfprocessing-editing-tablerow_1
            TableCell firstCell = tableRow.Cells.AddTableCell();
            TableCell secondCell = tableRow.Cells.AddTableCell();
            int cellsInRowCount = tableRow.Cells.Count;
            #endregion
        }
    }
}
