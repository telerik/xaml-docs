using System;
using System.Linq;
using System.Windows.Media;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;
using Telerik.Windows.Documents.Flow.Model.Styles;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ModelTable
{
    public class UserControl_Cs
    {
        private void CreateTable(RadFlowDocument document, Section section)
        {
            #region radwordsprocessing-model-table_0
            Table emptyTable = new Table(document); // Table object with 0 rows and 0 columns.
            section.Blocks.Add(emptyTable);

            Table table = new Table(document, 10, 5); // Table object with 10 rows and 5 columns.
            section.Blocks.Add(emptyTable);

            #endregion
        }

        private void InsertTable(RadFlowDocument document, Section section)
        {
            #region radwordsprocessing-model-table_1
            Table table = new Table(document, 10, 5);
            section.Blocks.Insert(0, table);
            #endregion
        }

        private void CreateTablehMethod(Section section)
        {
            #region radwordsprocessing-model-table_2
            Table table = section.Blocks.AddTable();
            #endregion
        }

        private void CreateTableWithRadFlowDocumentEditor()
        {
            #region radwordsprocessing-model-table_3
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(new RadFlowDocument());
            Table table = editor.InsertTable(5, 3);
            #endregion
        }

        private void CreateTableWithContent()
        {
            #region radwordsprocessing-model-table_4
            RadFlowDocument document = new RadFlowDocument();

            Table table = document.Sections.AddSection().Blocks.AddTable();
            document.StyleRepository.AddBuiltInStyle(BuiltInStyleNames.TableGridStyleName);
            table.StyleId = BuiltInStyleNames.TableGridStyleName;

            ThemableColor cellBackground = new ThemableColor(Colors.Beige);

            for (int i = 0; i < 5; i++)
            {
                TableRow row = table.Rows.AddTableRow();

                for (int j = 0; j < 10; j++)
                {
                    TableCell cell = row.Cells.AddTableCell();
                    cell.Blocks.AddParagraph().Inlines.AddRun(string.Format("Cell {0}, {1}", i, j));
                    cell.Shading.BackgroundColor = cellBackground;
                    cell.PreferredWidth = new TableWidthUnit(50);
                }
            }
            #endregion
        }

    }
}
