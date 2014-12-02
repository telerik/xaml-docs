---
title: History
page_title: History
description: History
slug: radspreadprocessing-features-history
tags: history
published: True
position: 7
---

# History



The document model provides the possibility to maintain a history stack that tracks all changes to the content of the workbook. The history is implemented via the __WorkbookHistory__ class and the __Workbook__ exposes a property of this type. All changes introduced to the workbook are automatically recorded, however, the model also allows manual control over the history.
      
* [Enable / Disable History](#enable-/-disable-history)

* [Undo / Redo Actions](#undo-/-redo-actions)

* [Smart Undo](#smart-undo)

* [Clear History](#clear-history)

## Enable / Disable History

By default the __WorkbookHistory__ class does not record all changes introduced to the workbook, but there are scenarios that need the history feature. For example, if you construct an entire document from code behind, you do not need to record each action you perform. In such cases you do not need to enable the history for the workbook via the __IsEnabled__ property of the __WorkbookHistory__ class. However, if you want to be able to undo one or several of the recent changes, you would need to enable the history.
        

__Example 1__ enables the history of a workbook.
        

#### __[C#] Example 1: Enable history__

{{region radspreadprocessing-features-history_2}}
    Workbook workbook = new Workbook();
    workbook.History.IsEnabled = true;
{{endregion}}



## Undo / Redo Actions

Once the hisory is enabled you can invoke its __Undo()__ and __Redo()__ methods to perform undo and redo actions respectively. Both methods return a __Boolean__ value that indicates whether the operations were successful. The __Workbook__ class exposes the *Boolean* properties __CanUndo__ and __CanRedo__ that indicate whether the respective action is applicable.
        

__Example 2__ creates a new workbook with a single worksheet and sets the value of cell *A1* twice. Further, the snippet performs the undo and redo actions.
        

#### __[C#] Example 2: Perform undo and redo__

{{region radspreadprocessing-features-history_0}}
    Workbook workbook = new Workbook();
    workbook.History.IsEnabled = true;
    Worksheet worksheet = workbook.Worksheets.Add();

    worksheet.Cells[0, 0].SetValue("First cell value");
    worksheet.Cells[0, 0].SetValue("Second cell value");

    workbook.History.Undo();
    workbook.History.Redo();
{{endregion}}



## Smart Undo

The __Workbook__ history offers a friendly API that allows grouping multiple changes into one undo step. For example, you may want to set the value of a cell and apply formatting to the same cell, and treat these two actions as a single undo operation. This can be easily achieved through enclosing the assignments with __BeginUndoGroup()__ and __EndUndoGroup()__ methods.
        

__Example 3__ demonstrates how to create an undo group:
        

#### __[C#] Example 3: Create undo group__

{{region radspreadprocessing-features-history_1}}
    Workbook workbook = new Workbook();
    workbook.History.IsEnabled = true;
    Worksheet worksheet = workbook.Worksheets.Add();

    workbook.History.BeginUndoGroup();

    worksheet.Cells[0, 0].SetValue(15);
    worksheet.Cells[0, 0].SetFormat(new CellValueFormat("0.00"));

    workbook.History.EndUndoGroup();

    workbook.History.Undo();
    workbook.History.Redo();
{{endregion}}



## Clear History

To clear the history you just have to call the __Clear()__ method of the __WorkbookHistory__ class. Note that you cannot clear the history if you are recording an undo group. If you attempt to call the method after invoking __BeginUndoGroup()__ an exception is be thrown. The following snippet illustrates how to clear workbook's history.
        

__Example 4__ clears the history of a workbook.
        

#### __[C#] Example 4: Clear history.__

{{region radspreadprocessing-features-history_3}}
    workbook.History.Clear();
{{endregion}}


