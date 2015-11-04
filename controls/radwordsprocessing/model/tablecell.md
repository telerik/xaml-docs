---
title: TableCell
page_title: TableCell
description: TableCell
slug: radwordsprocessing-model-tablecell
tags: tablecell
published: True
position: 7
---

# TableCell



__TableCell__ element is a __BlockContainer__ element and defines a cell of content within a [Table]({%slug radwordsprocessing-model-table%}). It contains __Block__ elements such as [Paragraph]({%slug radwordsprocessing-model-paragraph%}) and [Table]({%slug radwordsprocessing-model-table%}).
      

* [Inserting a TableCell](#inserting-a-tablecell)

* [Modifying a TableCell](#modifying-a-tablecell)

* [Operating with a TableCell](#operating-with-a-tablecell)

## Inserting a TableCell

You can use the code snippet from __Example 1__ to create a __TableCell__ and add it in a [TableRow]({%slug radwordsprocessing-model-tablerow%}).
        

#### __[C#] Example 1: Create a TableCell Object and add it to a TableRow__

{{region radwordsprocessing-model-tablecell_0}}
    TableCell cell = new TableCell(document);
    row.Cells.Add(cell);
{{endregion}}



To create a __TableCell__ and add it in the document tree in the same time, you can use the __AddTableCell()__ method.
        

#### __[C#] Example 2: Create a TableCell and add it to a TableRow in the Same Time__

{{region radwordsprocessing-model-tablecell_1}}
    TableRow row = table.Rows.AddTableRow();
    TableCell cell = row.Cells.AddTableCell();
{{endregion}}



## Modifying a TableCell

The __TableCell__ element exposes several properties that allow you to customize its layout. A part of these properties are Style properties and some of the values represent a themable object.
        

>tipStyle properties are properties that can be inherited from a style. For more information about styles see [this article]({%slug radwordsprocessing-concepts-style-properties%}).
          

>tipThemable objects are objects that can be inherited from a theme. For more information about themes check [this article]({%slug radwordsprocessing-concepts-document-themes%}).
          


* __Properties__: Retrieves all __TableCellProperties__. For more information read [this article]({%slug radwordsprocessing-concepts-style-properties%}).
            

* __Row__: Represents the parent __TableRow__ of the cell.
            
* __Table__: Represents the parent __Table__ of the cell.

* __Borders__: Specifies the borders of the cell. *This is a Style property.*

* __Shading__: Represents the shading applied to the cell. It is a composite object and is read-only. You can obtain the following properties from it:
            

* __BackgroundColor__: Specifies the background color for the shading. *This is a Style property. The value is themable object.*

* __PatternColor__: Specifies the pattern color for the shading. *This is a Style property. The value is themable object.*

* __Pattern__: Specifies the pattern which is used to lay the pattern color over the background color for the shading. *This is a Style property.*

* __Padding__: Specifies the padding of the cell. *This is a Style property.*

* __ColumnSpan__: Indicates the total number of columns that the __TableCell__ spans within a __TableRow__. This property cannot be derived from a style.
            

* __RowSpan__: Specifies the total number of rows that the __TableCell__ spans within a __Table__. This property cannot be derived from a style.
            

* __IgnoreCellMarkerInRowHeightCalculation__: Specifies whether cell marker is ignored when row height is calculated. This property cannot be derived from a style.
            

* __CanWrapContent__: Specifies whether the content can be wrapped during the table layout. This property cannot be derived from a style.
            

* __PreferredWidth__: Specifies the preferred width of the cell. This property cannot be derived from a style.
            

* __VerticalAlignment__: Specifies the vertical alignment of the cell's content. This property cannot be derived from a style.

* __TextDirection__: Specifies the direction of the text in the cell. It could have one of the values of the [TextDirection enumeration](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Documents_Flow_Model_Styles_TextDirection.htm). This property cannot be derived from a style.
            

* __GridColumnIndex__: Represents the column index of the cell in the table grid.
            

* __GridRowIndex__: Represents the row index of the cell in the table grid.
            

## Operating with a TableCell

### Add a Paragraph to a TableCell

__Example 3__ demonstrates how to add a __Paragraph__ to a __TableCell__.
            

#### __[C#] Example 3: Add a Paragraph to a TableCell__


{{region radwordsprocessing-model-tablecell_2}}
    Paragraph paragraph = cell.Blocks.AddParagraph();
{{endregion}}



Through the __BlockCollection__ property of the __TableCell__ element you can add a __Table__ or any other [BlockBase](http://www.telerik.com/help/wpf/t_telerik_windows_documents_flow_model_blockbase.html) element.
            

# See Also

 * [TableCell API Reference](http://www.telerik.com/help/wpf/t_telerik_windows_documents_flow_model_tablecell.html)

 * [Document model]({%slug radwordsprocessing-model%})

 * [Table]({%slug radwordsprocessing-model-table%})

 * [TableRow]({%slug radwordsprocessing-model-tablerow%})
