---
title: TableCell
page_title: TableCell
description: TableCell
slug: radpdfprocessing-editing-tablecell
tags: tablecell
published: True
position: 1
---

# TableCell



__TableCell__ class represents a single cell in a [Table]({%slug radpdfprocessing-editing-table%}). Cells are added to a [TableRow]({%slug radpdfprocessing-editing-tablerow%}) instance in the rows collection of a table. The main purpose of the cell is to contain, organize and layout tabular data.
      

* [Inserting a TableCell](#inserting-a-tablecell)

* [Adding Cell Content](#adding-cell-content)

* [Modifying a TableCell](#modifying-a-tablecell)

## Inserting a TableCell

In order to add a cell to а __Тable__ you should add it in the __TableCellCollection__ of a __TableRow__.
        

The code snippet in __Example 1__ shows how to create a table with a single row and add a cell in the first row.
        

#### __[C#] Example 1: Create TableCell__

{{region radpdfprocessing-editing-tablecell_0}}
    Table table = new Table();
    TableRow firstRow = table.Rows.AddTableRow();
    TableCell firstCell = firstRow.Cells.AddTableCell();
{{endregion}}



## Adding Cell Content

Using __TableCell__'s __Blocks__ property you can easily add one or several __IBlockElement__ instances to the cell.
        

__Example 2__ shows how to create a cell with a single [Block]({%slug radpdfprocessing-editing-block%}) in it.
        

#### __[C#] Example 1: Add Content to TableCell__

{{region radpdfprocessing-editing-tablecell_1}}
    Block block = firstCell.Blocks.AddBlock();
    block.InsertText("Text in the cell.");
{{endregion}}



## Modifying a TableCell

You can easily change the cell's presentation by using the following properties:
        

* __RowSpan__: Defines the number or rows that the TableCell instance should occupy.
            

* __ColumnSpan__: Defines the number of columns that the TableCell instance should occupy.
            

* __Padding__: Specifies the distances between the cells borders inner contour and the cell content. If the value is null, the cell will use the padding from the table's DefaultCellProperties.
            

* __Borders__: Specifies the borders of the cells. If the value is null the cell uses the value from table's DefaultCellProperties.
            

* __Background__: Specifies the background of the cell. If null the cell uses the background from table's DefaultCellProperties.
            
* __PreferredWidth__: Specifies the preferred width of the cell. The final width of the cell may be bigger of the set value in case when other cell from the same column requires bigger PreferredWidth.

__Example 3__ demonstrates how to set locally the cell properties to a specific cell. This helps achieve different appearance for this cell by changing its borders and background. Additionally the cell will span onto two rows and two columns.
        

#### __[C#] Example 1: Change TableCell Appearance__

{{region radpdfprocessing-editing-tablecell_2}}
    firstCell.RowSpan = 2;
    firstCell.ColumnSpan = 2;
    firstCell.Borders = new TableCellBorders(new Border(1, new RgbColor(150, 0, 0)));
    firstCell.Background = new RgbColor(255, 100, 100);
{{endregion}}



The result from __Example 3__ may be observed on __Figure 1__.
        

Figure 1: TableCell Appearance
![Rad Pdf Processing Editing Table Cell 01](images/RadPdfProcessing_Editing_TableCell_01.png)

# See Also

 * [Table]({%slug radpdfprocessing-editing-table%})

 * [TableRow]({%slug radpdfprocessing-editing-tablerow%})

 * [Block]({%slug radpdfprocessing-editing-block%})
