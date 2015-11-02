---
title: TableRow
page_title: TableRow
description: TableRow
slug: radwordsprocessing-model-tablerow
tags: tablerow
published: True
position: 6
---

# TableRow



__TableRow__ is a flow document element that defines a row within a [Table]({%slug radwordsprocessing-model-table%}). It contains a collection of [TableCell]({%slug radwordsprocessing-model-tablecell%}) elements.
      

* [Inserting a TableRow](#inserting-a-tablerow)

* [Modifying a TableRow](#modifying-a-tablerow)

* [Operating with a TableRow](#operating-with-a-tablerow)

## Inserting a TableRow

You can use the code snippet from __Example 1__ to create a __TableRow__ and add it in a __Table__.
        

#### __[C#] Example 1: Create a TableRow and add it to a Table__

{{region radwordsprocessing-model-tablerow_0}}
    TableRow row = new TableRow(document);
    table.Rows.Add(row);
{{endregion}}



In order to create a __TableRow__ and add it in the document tree in the same time, you can use the __AddTableRow()__ method of the [Rows](http://www.telerik.com/help/wpf/p_telerik_windows_documents_flow_model_table_rows.html) collection property of the table.
        

#### __[C#] Example 2: Create a TableRow and add it to a Table in the Same Time__

{{region radwordsprocessing-model-tablerow_1}}
    TableRow row = table.Rows.AddTableRow();
{{endregion}}



## Modifying a TableRow

The __TableRow__ element exposes several properties that allow you to customize its layout. Some of the properties are Style properties.
        

>tipStyle properties are properties that can be inherited from a style. For more information about styles see [this article]({%slug radwordsprocessing-concepts-style-properties%}).


* __Properties__: Gets all table row properties as TableRowProperties object. More info on how to use table row properties can be found in [Style Properties]({%slug radwordsprocessing-concepts-style-properties%}) article.
            

* __Cells__: Retrieves a collection of __Cell__ elements in the current TableRow.
            

* __Table__: Retrieves the parent Table element of the row.
            

* __GridRowIndex__: Represents the index of the row in the table grid.
            

* __TableCellSpacing__: Specifies the spacing between adjacent cells and the edges of the table. The value is in device independent pixels (1/96 inch). The default value is *0*. *This is a Style property.*

* __RepeatOnEveryPage__: Indicates whether this row should be repeated on every new page. The default value is *false*. *This property cannot be derived from a style.*
            

* __CanSplit__: Specifies whether the content of the row can be split across multiple pages. The default value is *true*. *This property cannot be derived from a style.*
            

* __Height__: Specifies the row height. *This property cannot be derived from a style.*
            

          

## Operating with a TableRow

### Add TableCell elements to a TableRow

__Example 3__ shows how to add a number of __TableCell__ elements in a TableRow.
            

#### __[C#] Example 3: Add TableCell objects to a TableRow__

{{region radwordsprocessing-model-tablerow_2}}
    TableRow row = table.Rows.AddTableRow();

    for (int i = 0; i < row.Table.GridColumnsCount; i++)
    {
        TableCell cell = row.Cells.AddTableCell();
        cell.Blocks.AddParagraph().Inlines.AddRun(string.Format("Cell 0, {0}", i));
        cell.PreferredWidth = new TableWidthUnit(50);
    }
{{endregion}}



# See Also

 * [TableRow API Reference](http://www.telerik.com/help/wpf/t_telerik_windows_documents_flow_model_tablerow.html)

 * [Table]({%slug radwordsprocessing-model-table%})

 * [TableCell]({%slug radwordsprocessing-model-tablecell%})

 * [Style Properties]({%slug radwordsprocessing-concepts-style-properties%})
