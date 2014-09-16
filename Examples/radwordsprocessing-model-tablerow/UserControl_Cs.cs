using System;
using System.Linq;
using System.Windows.Media;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;
using Telerik.Windows.Documents.Flow.Model.Styles;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ModelTableRow
{
    public class UserControl_Cs
    {
        private void CreateTableRow(RadFlowDocument document, Table table)
        {
            #region radwordsprocessing-model-tablerow_0
            TableRow row = new TableRow(document);
            table.Rows.Add(row);
            #endregion
        }

        private void CreateTablehMethod(Table table)
        {
            #region radwordsprocessing-model-tablerow_1
            TableRow row = table.Rows.AddTableRow();
            #endregion
        }

        private void CreateRowWithCells(Table table)
        {
            #region radwordsprocessing-model-tablerow_2
            TableRow row = table.Rows.AddTableRow();

            for (int i = 0; i < row.Table.GridColumnsCount; i++)
            {
                TableCell cell = row.Cells.AddTableCell();
                cell.Blocks.AddParagraph().Inlines.AddRun(string.Format("Cell 0, {0}", i));
                cell.PreferredWidth = new TableWidthUnit(50);
            }
            #endregion
        }

    }
}
