using System;
using System.Linq;
using Telerik.Windows.Documents.Flow.Model;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ModelTableCell
{
    public class UserControl_Cs
    {
        private void CreateTableCell(RadFlowDocument document, TableRow row)
        {
            #region radwordsprocessing-model-tablecell_0
            TableCell cell = new TableCell(document);
            row.Cells.Add(cell);
            #endregion
        }

        private void AddTableCell(Table table)
        {
            #region radwordsprocessing-model-tablecell_1
            TableRow row = table.Rows.AddTableRow();
            TableCell cell = row.Cells.AddTableCell();
            #endregion
        }

        private void CreateCellWithParagraph(TableCell cell)
        {
            #region radwordsprocessing-model-tablecell_2
            Paragraph paragraph = cell.Blocks.AddParagraph();
            #endregion
        }

    }
}
