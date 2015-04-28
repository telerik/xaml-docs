---
title: Hidden Rows and Columns
page_title: Hidden Rows and Columns
description: Hidden Rows and Columns
slug: radspreadprocessing-working-with-rows-and-columns-hiding
tags: hiding,hidden,rows,and,columns
published: True
position: 3
---

# Hidden Rows and Columns


The API of the workbook model allows you to set the hidden state of each row or column. This article briefly describes how this can be achieved. It contains the following sections:


* [Get, Set and Clear the Hidden State](#get-set-and-clear-the-hidden-state)

* [Relationship with the Height and Width Properties](#relationship-with-the-height-and-width-properties)

* [Relationship with the AutoFit Method](#relationship-with-the-autoFit-method)


## Get, Set and Clear the Hidden State

In order to set the hidden state of the rows or columns, you need to create a __RowSelection__ or a __ColumnSelection__ instance from the rows or columns you would like to manipulate. This instance exposes the methods __GetHidden()__, __SetHidden()__ and __ClearHidden()__ which can be used to change the hidden state of the selection.

The __GetHidden()__ method returns a __RangePropertyValue__ instance which summarizes the information about the hidden state of all selected rows or columns. The object exposes two properties:

* __IsIndeterminate__: Indicates whether the hidden state is consistent among all rows or columns in the selection. If all rows or columns have one and the same hidden state, IsIndeterminate is set to false. However, if the hidden state varies, the IsIndeterminate property is set to true and the Value property of the RangePropertyValue class returns the default value of the hidden state, which is false.  

* __Value__: Holds the actual hidden state. If the __IsIndeterminate__ property is set to false, __Value__ contains the hidden state shared by the entire region. If the __IsIndeterminate__ property is set to true, this indicates that the state is not the same for all rows or columns in the selection and the __Value__ property is set to its default value.

The __SetHidden()__ method is used to change the hidden state of the rows and columns. It takes an argument of type bool which specifies the new state. The __ClearHidden()__ method is used to reset the hidden state of the selected rows or columns to the default.

__Example 1__ shows how to retrieve and change the hidden state of several rows using the RowSelection class. The code checks if all the rows in the selection are visible and only then hides them. If the selection contains any hidden rows, the hidden state is cleared which will make all rows visible.

#### __[C#] Example 1: Change row hidden state__

{{region radspreadprocessing-working-with-rows-and-columns-hiding_0}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();

    RowSelection rowSelection = worksheet.Rows[5, 7];
    RangePropertyValue<bool> rowsHiddenState = rowSelection.GetHidden();
    if (!rowsHiddenState.IsIndeterminate && !rowsHiddenState.Value)
    {
        rowSelection.SetHidden(true);
    }
    else
    {
        rowSelection.ClearHidden();
    }
{{endregion}}


## Relationship with the Height and Width Properties

When the hidden state property of a RowSelection or a ColumnSelection is set, this does not affect [its height or width properties]({%slug radspreadprocessing-working-with-rows-and-columns-resizing%}). The opposite is also true. If the height or width of a row or column is set to zero, this will not change its hidden state in the model.

__Example 2__ shows how you can set the width of a group of columns and it would not affect the hidden state.

#### __[C#] Example 2: Change column width__

{{region radspreadprocessing-working-with-rows-and-columns-hiding_1}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();

    ColumnSelection columnSelection = worksheet.Columns[5, 7];
    columnSelection.SetWidth(new ColumnWidth(0, true));

    bool hiddenState = columnSelection.GetHidden().Value;
{{endregion}}

## Relationship with the AutoFit Method

Like setting the height or width through the SetHeight() and SetWidth() methods, using the [Auto Fit methods]({%slug radspreadprocessing-working-with-rows-and-columns-resizing%}) will not affect the hidden state of the rows or columns. It will, however, affect the underlying height and width.

__Example 3__ demonstrates this by hiding a row, autofitting it and then checking its hidden state.

#### __[C#] Example 3: Auto fit on hidden rows__

{{region radspreadprocessing-working-with-rows-and-columns-hiding_2}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();

    RowSelection rowSelection = worksheet.Rows[3];
    rowSelection.SetHidden(true);

    rowSelection.AutoFitHeight();

    bool hiddenState = rowSelection.GetHidden().Value;
{{endregion}}


