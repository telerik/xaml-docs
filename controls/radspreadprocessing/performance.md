---
title: Performance Tips and Tricks
page_title: Performance Tips and Tricks
description: Performance Tips and Tricks
slug: radspreadprocessing-performance
tags: performance,tips,and,tricks
published: True
position: 10
---

# Performance Tips and Tricks



__RadSpreadProcessing__ allows you to prepare and modify tabular data. Even though the library was built with performance in mind, working with large amounts of data slows it down. This article will help you get the most from the component in terms of performance.
      

* [Reduce Layout Updates Frequency](#reduce-layout-updates-frequency)

* [Reduce the Number of Undo Steps](#reduce-the-number-of-undo-steps)

* [Disabling History](#disabling-history)

* [Apply Values or Formatting on Large Range at Once](#apply-values-or-formatting-on-large-range-at-once)

* [Avoid Using the Additional Calculations Options Provided by the Shapes and Images](#avoid-using-the-additional-calculations-options-provided-by-the-shapes-and-images)

* [Avoid Cell Value Type Parsing](#avoid-cell-value-type-parsing) 

## Reduce Layout Updates Frequency

Calculating the layout is an operation computing the width of each column and the height of each row, the size of the text contained in the cells and many other elements which are used for positioning the UI. The layout update is triggered each time a property is changed and thus is a fairly heavy operation.
        

Internally there are many mechanisms used to lower the number of calculations, but sometimes they are not enough. For example, if you want to generate a document and then show it, you do not need to trigger any layout updates other than the one after you finish creating the document. The code snippet in __Example 1__ shows how the layout updates can be suspended and then resumed after document generation is completed.
        

#### __[C#] Example 1: Suspend Layout Updates__

{{region radspreadprocessing-performance_0}}
    Workbook workbook = new Workbook();
    workbook.SuspendLayoutUpdate();
    // The code which generates the document
    workbook.ResumeLayoutUpdate();
{{endregion}}



Note that if an exception is thrown between the two method calls, the resuming of the layout update will not be performed and the UI will stop updating. The way to ensure the layout update will be resumed whatever happens is to use __UpdateScope__. The code snippet in __Example 2__ demonstrates how to use it.
        

#### __[C#] Example 2: Suspend Layout Updates in UndoScope__

{{region radspreadprocessing-performance_1}}
    Workbook workbook = new Workbook();
    using (new UpdateScope(workbook.SuspendLayoutUpdate, workbook.ResumeLayoutUpdate))
    {
        // The code which generates the document
    }
{{endregion}}



## Reduce the Number of Undo Steps

Preserving information about the steps in the undo stack is usually not a time consuming operation, but even the lightest operation performed thousands of times may slow down your application. If you do not need to preserve each step in the document generation process as a separate undo step, you can simply combine a series of actions into one undo step. For example, if you want to set background color to the even rows in your table you have to set the fill for each row separately. This way each background setting will be preserved as a separate undo step. To combine them in a single undo step you can use the code in __Example 3__.
        

#### __[C#] Example 3: Combine Steps In Undo Group__

{{region radspreadprocessing-performance_2}}
    Workbook workbook = new Workbook();
    workbook.History.BeginUndoGroup();
    // The code which generates the document
    workbook.History.EndUndoGroup();
{{endregion}}



Note that if an exception is thrown between the two method calls, the ending of the undo group will not be performed, all the following actions will not be added to the history either and the UI will stop updating. The way to ensure that whatever happens the undo group will be closed is to use __UpdateScope__. The code snippet in __Example 4__ demonstrates how to use it.
        

#### __[C#] Example 4: Combine Steps In Undo Group Using UndoScope__

{{region radspreadprocessing-performance_3}}
    Workbook workbook = new Workbook();
    using (new UpdateScope(workbook.History.BeginUndoGroup, workbook.History.EndUndoGroup))
    {
        // The code which generates the document
    }
{{endregion}}



## Disabling History

As you already know from the [Reduce the Number of Undo Steps section](#reduce-the-number-of-undo-steps), preserving the history steps can lower the performance of __RadSpreadProcessing__. If you do not want to preserve History while generating your document, you can simply turn the feature off. It can be easily switched on and off through the __IsEnabled__ Boolean property of the history like shown in __Example 5__.
        

#### __[C#] Example 5: Disable History__

{{region radspreadprocessing-performance_4}}
    workbook.History.IsEnabled = false;
    // The code which generates the document
    workbook.History.IsEnabled = true;
{{endregion}}



If an exception is thrown before enabling the history, it will not be enabled and the subsequent history steps will not be preserved. To ensure that the history will be enabled  you can use the __UpdateScope__ class. __Example 6__ shows how it can be achieved:
        

#### __[C#] Example 6: Disable and Enable History Using UndoScope__

{{region radspreadprocessing-performance_5}}
    using (new UpdateScope(
        () => { workbook.History.IsEnabled = false; },
        () => { workbook.History.IsEnabled = true; }))
    {
        // The code which generates the document
    }
{{endregion}}



## Apply Values or Formatting on Large Range at Once

Setting the same values to thousands of cells one by one takes more time than setting the same values to an entire cell range. A __CellRange__ can be created using the row and column indices of the start and end cells.
        

__public CellRange(int fromRowIndex, int fromColumnIndex, int toRowIndex, int toColumnIndex)__

## Avoid Using the Additional Calculations Options Provided by the Shapes and Images

When setting the properties of an image you have created, you have to keep in mind that some of the members may cause recalculation of other properties in order to make the images more convenient to use in a UI context. You can read more about what calculation are performed in the [Shapes and Images]({%slug radspreadprocessing-features-shapes-and-images%}) article. If you are generating a document from scratch the recalculation of other properties will most likely be an unnecessary burden for your application. In this case it is advisable to use the properties of the shape classes:
        

* Width

* Height

* RotationAngle

You should avoid using the methods for setting the same properties with the __adjustCellIndex__ parameter set to true:
        

* SetWidth()

* SetHeight()

* SetRotationAngle()

## Avoid Cell Value Type Parsing

When setting values to cells, the cell value type is determined by an internal parsing mechanism. If you are sure what cell value type should be produced by the passed value, set it specifically. This will bypass the parsing and increase the performance of the application. 

The easiest way to achieve this is by using the __SetValue()__ overload with the respective CLR type (DateTime, Double, etc.) or in the case of formula value type and text value type - the __SetValueAsFormula()__ and __SetValueAsText()__ methods respectively.  

More information regarding cell value types is available in the [Cell Value Types]({%slug radspreadprocessing-working-with-cells-cell-value-types%}) article.


# See Also

 * [History]({%slug radspreadprocessing-features-history%})

 * [Get, Set and Clear Cell Properties]({%slug radspreadprocessing-working-with-cells-get-set-clear-properties%})

 * [Shapes and Images]({%slug radspreadprocessing-features-shapes-and-images%})
 
 *  [Cell Value Types]({%slug radspreadprocessing-working-with-cells-cell-value-types%})
