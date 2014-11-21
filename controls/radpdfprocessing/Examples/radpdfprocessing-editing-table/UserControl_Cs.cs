using System;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.ColorSpaces;
using Telerik.Windows.Documents.Fixed.Model.Data;
using Telerik.Windows.Documents.Fixed.Model.Editing;
using Telerik.Windows.Documents.Fixed.Model.Editing.Flow;
using Telerik.Windows.Documents.Fixed.Model.Editing.Tables;

namespace PdfProcessingDocumentationSourceCode.Examples.EditingTable
{
    public class UserControl_Cs
    {
        private void CreateTable()
        {
            #region radpdfprocessing-editing-table_0
            Table table = new Table();

            TableRow firstRow = table.Rows.AddTableRow();
            firstRow.Cells.AddTableCell().Blocks.AddBlock().InsertText("cell11");
            firstRow.Cells.AddTableCell().Blocks.AddBlock().InsertText("cell12");
            firstRow.Cells.AddTableCell().Blocks.AddBlock().InsertText("cell13");

            TableRow secondRow = table.Rows.AddTableRow();
            secondRow.Cells.AddTableCell().Blocks.AddBlock().InsertText("cell21");
            secondRow.Cells.AddTableCell().Blocks.AddBlock().InsertText("cell22");
            secondRow.Cells.AddTableCell().Blocks.AddBlock().InsertText("cell23");
            #endregion
        }

        private void ChangeDefaultCellProperties()
        {
            #region radpdfprocessing-editing-table_1
            Table table = new Table();
            Border redBorder = new Border(2, new RgbColor(255, 0, 0));
            table.DefaultCellProperties.Borders = new TableCellBorders(redBorder);
            table.DefaultCellProperties.Padding = new Thickness(20, 10, 20, 10);
            table.DefaultCellProperties.Background = new RgbColor(0, 255, 0);

            TableRow firstRow = table.Rows.AddTableRow();
            firstRow.Cells.AddTableCell();
            firstRow.Cells.AddTableCell();
            firstRow.Cells.AddTableCell();

            TableRow secondRow = table.Rows.AddTableRow();
            secondRow.Cells.AddTableCell();
            secondRow.Cells.AddTableCell();
            secondRow.Cells.AddTableCell();
            #endregion
        }

        private void BordersExample()
        {
            #region radpdfprocessing-editing-table_2
            Table table = new Table();
            table.DefaultCellProperties.Padding = new Thickness(10, 6, 10, 6);
            Border redBorder = new Border(10, new RgbColor(255, 0, 0));
            table.Borders = new TableBorders(redBorder);
            #endregion

            #region radpdfprocessing-editing-table_3
            TableRow tableRow = table.Rows.AddTableRow();

            TableCell firstCell = tableRow.Cells.AddTableCell();
            Border greenBorder = new Border(5, new RgbColor(0, 255, 0));
            firstCell.Borders = new TableCellBorders(greenBorder, greenBorder, greenBorder, greenBorder);
            firstCell.Blocks.AddBlock().InsertText("green bordered cell");

            TableCell secondCell = tableRow.Cells.AddTableCell();
            Border blueBorder = new Border(3, new RgbColor(0, 0, 255));
            secondCell.Borders = new TableCellBorders(blueBorder, blueBorder, blueBorder, blueBorder);
            secondCell.Blocks.AddBlock().InsertText("blue bordered cell");
            #endregion

            #region radpdfprocessing-editing-table_4
            table.BorderCollapse = BorderCollapse.Collapse;
            #endregion

            #region radpdfprocessing-editing-table_5
            table.BorderCollapse = BorderCollapse.Separate;
            #endregion
        }

        private void UsingRadFixedDocumentEditor(RadFixedDocument document)
        {
            #region radpdfprocessing-editing-table_6
            Table table = new Table();

            Border border = new Border();
            table.Borders = new TableBorders(border);
            table.DefaultCellProperties.Borders = new TableCellBorders(border, border, border, border);

            table.BorderSpacing = 5;
            table.BorderCollapse = BorderCollapse.Separate;

            TableRow row = table.Rows.AddTableRow();
            row.Cells.AddTableCell().Blocks.AddBlock().InsertText("First cell");
            row.Cells.AddTableCell().Blocks.AddBlock().InsertText("Second cell");
            #endregion

            #region radpdfprocessing-editing-table_7
            RadFixedDocumentEditor editor = new RadFixedDocumentEditor(document);
            editor.TableProperties.LayoutType = TableLayoutType.AutoFit;
            editor.InsertTable(table);
            #endregion

            #region radpdfprocessing-editing-table_8
            editor.TableProperties.LayoutType = TableLayoutType.FixedWidth;
            editor.InsertTable(table);
            #endregion
        }

        private void UsingFixedContentEditor()
        {
            #region radpdfprocessing-editing-table_9
            Table table = GenerateSampleTable();

            RadFixedDocument document = new RadFixedDocument();
            RadFixedPage page = document.Pages.AddPage();
            FixedContentEditor editor = new FixedContentEditor(page, new SimplePosition());

            editor.Position.Translate(10, 100);
            editor.Position.Rotate(-45);
            editor.DrawTable(table);
            #endregion
        }

        private Table GenerateSampleTable()
        {
            throw new NotImplementedException();
        }
    }
}
