---
title: Changes
page_title: Changes
description: Changes
slug: radspreadprocessing-changes
tags: changes
published: True
position: 0
---

# Changes



This topic will summarize the new functionality introduced in the library with helpful links to places in the documentation that describe in greater detail the new functionality and how it can be used.

## What's New in 2014 Q3

__What's New__

Improved import and export performance.
        

Improve FillSeries performance.
        

Performance optimizations for shapes and images.
        

Include option to unregister function from FunctionManager.
        

Exposed API for getting the cell content size and the cell layout box from the model.
        

__What's Fixed__

Setting empty string as font family in a cell and exporting the workbook makes corrupted document.
        

Copy and paste named ranges with isolated scope in different worksheet refers to the source worksheet.
        

Importing document containing predefined Normal style causes exception.
        

Some documents cannot be imported due to the used theme.
        

Cannot import xlsx files containing images with uppercase extensions.
        

Theme dependent fills are not updated when the theme is changed.
        

The currency number format is not exported correctly in cultures that contain “.” or “,” in the currency symbol, e.g. Bulgarian and Serbian.
        

When the worksheet name is changed from code this does not affect existing CellReferenceRangeExpressions.
        

The currency number format is not exported correctly in cultures that contain “.” or “,” in the currency symbol, e.g. Bulgarian and Serbian.
        

The currency number format is not exported correctly in cultures that contain “.” or “,” in the currency symbol, e.g. Bulgarian and Serbian.
        

The currency number format is not exported correctly in cultures that contain “.” or “,” in the currency symbol, e.g. Bulgarian and Serbian.
        

## What's New in 2014 Q2

* [Filtering]({%slug radspreadprocessing-features-filtering%})

* [Sorting]({%slug radspreadprocessing-features-sorting%})

* [Export to PDF]({%slug radspreadprocessing-formats-and-conversion-pdf-pdf%})

* Error cell value
            

* Automatic update for all defined names and cell references when the workbook name is changed
            

* Automatic translation of cell references when cells/rows/columns are inserted or deleted
            
