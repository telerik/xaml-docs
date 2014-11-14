---
title: Changes
page_title: Changes
description: Changes
slug: radspreadsheet-changes
tags: changes
published: True
position: 0
---

# Changes



This topic summarizes the new functionality introduced in the control with helpful links to places in the documentation that describe in greater detail the new functionality and how it can be used.
      

## What's New in 2014 Q3

__What's New__

* Introduced Fill Handle - the ability to fill data through dragging the bottom right corner of the selection. [Read more.]({%slug radspreadsheet-ui-working-with-selection%})

* Introduced an option to set custom text in the column/row headings. [Read more.]({%slug radspreadsheet-howto-customize-row-column-headers%})

* Introduced an option to hide column/row headings (margins). [Read more.]({%slug radspreadsheet-howto-hide-row-column-headers-and-gridlines%})

* Introduced an IsVisible property for the defined names to provide an option to hide them from end user.
            

* Improved import and export performance.
            

* Improved FillSeries performance.
            

* Introduced new API for the shapes and images classes which allows the user to choose faster performance at the expense of layout calculations.
            

* Introduced SpreadsheetCultureInfo class allowing to access RadSpreadsheet culture dependent list, decimal and array list separators.
            

* Introduced option to unregister function from FunctionManager.
            

* Introduced command bindings for Ctrl/Shift and Ctrl/Insert for “Copy” and “Paste”.
            

* Introduced CalculateCellLayoutBox method for getting the cell content size and the cell layout box from the model.
            

__What's Fixed__

* Pasting a single cell into the whole sheet (Ctrl + A) raises an OutOfMemory exception.
            

* The Name property of the SpreadsheetNameCollectionScope class was obsoleted as it should not be part of the SpreadProcessing model. In RadSpreadsheet the same functionality is provided by the ScopeName property in the SpreadsheetNameView class.
            

* Setting empty string as font family in a cell and exporting produces a corrupted document.
            

* Entering value in FormulaBar by pressing accept button does not preserve selected cell.
            

* Copy & paste named ranges with isolated scope in different worksheet refers to the source worksheet.
            

* Importing document containing predefined Normal style causes exception.
            

* Some documents cannot be imported due to the used theme.
            

* The icon of filtered column doesn't update as filtered icon in touch mode.
            

* Filtering popup button is positioned wrong when row size is changed.
            

* When filter is applied texts in hidden filter rows should not be rendered at all.
            

* Insert button triggers the paste command.
            

* Delete key binding doesn't work when sheet is protected but the current cell is unlocked.
            

* Insert rows and columns context menu items are visible when the sheet is protected.
            

* Multiple selection of images with Ctrl and left mouse button resizes images to very small ones.
            

* Cannot import xlsx format files containing images with uppercase extensions.
            

* Theme dependent fills are not updated when the theme is changed.
            

* The currency number format is not exported correctly in cultures that contain “.” or “,” in the currency symbol, e.g. Bulgarian and Serbian.
            

* The UI doesn’t update when a value on another sheet affects the active one.
            

* When the worksheet name is changed from code this does not affect existing CellReferenceRangeExpressions.
            

* Missing dimension element part in documents exported with XlsxFormatProvider causes exception when trying to open documents with OleDbConnection.
            

* Not all installed fonts are listed in the fonts combobox.
            

## What's New in 2014 Q2

* Filtering functionality.
            

* Sorting functionality.
            

* Export to PDF. You can find more information  [here](c6276abc-6c8b-4703-aeba-783e4b4506f5).
            

## What's New in 2014 Q1 - 2014.1.0226

* Images support. You can find more information [here]({%slug radspreadsheet-model-features-shapes-and-images%}).
            

* Printing and UI for printing. You can find more information [here]({%slug radspreadsheet-ui-printing%}).
            

* Freeze panes. You can find more information [here]({%slug radspreadsheet-ui-freeze-panes%}).
            

* Workbook and worksheet protection.You can find more information in these articles:
              [Workbook Protection]({%slug radspreadsheet-model-features-protection-workbook%}), [Worksheet Protection]({%slug radspreadsheet-model-features-protection-worksheet%}).
            
