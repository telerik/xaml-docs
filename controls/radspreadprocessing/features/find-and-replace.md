---
title: Find and Replace
page_title: Find and Replace
description: Find and Replace
slug: radspreadprocessing-features-find-and-replace
tags: find,and,replace
published: True
position: 5
---

# Find and Replace



The document model offers a convenient way to find and replace text and numbers in a workbook, worksheet or a specified range of cells. This article provides information about the options of the find and replace features and demonstrates how they can be used.
      

* [Find and FindAll](#find-and-findall)

* [Replace and ReplaceAll](#replace-and-replaceall)

## Find and FindAll

Both Workbook and Worksheet classes expose methods that search their contents for a specific value. The two classes offer a __Find()__ method that returns the first occurrence of the sought string and a __FindAll()__ method that displays all occurrences of the specified value. Both methods require a single parameter of type __FindOptions__ that determines how the search is performed. The following list outlines the properties of the __FindOptions__ class:
        

* __FindWhat__: Specifies the sought string.
            

* __FindWithin__: Determines if the search is conducted for the whole Workbook or for a particular Worksheet. If you call the __Find()__ method of the Workbook class and the __FindWithin__ option is set to Workbook, the search is done for the entire workbook and if the option is Worksheet – the search is performed only for the active worksheet. Note that if you call the __Find()__ method of the Worksheet class, the __FindWithin__ property is ignored and the search is done for the worksheet instance that invokes the search.
            

* __FindBy__: Indicates whether the search is performed by rows or by columns.
            

* __FindIn__: Shows if the search includes formulas or only result values.
            

* __MatchCase__: Determines if the search should match the casing of the sought string.
            

* __MatchEntireCellContents__: Indicates whether the sought string should match the entire cell content.
            

* __StartCell__: Marks the cell from which the search begins.
            

* __SearchRanges__: If the property is set to __null__, the search is performed in the entire workbook or worksheet, depending on the __FindWithin__ property. If ranges are defined, the search is performed only for these ranges of the active sheet. Note that this property is taken into account only in the __Find()__ and __Replace()__ methods and disregarded in the __FindAll()__ and __ReplaceAll()__ methods.
            

__Example 1__ creates a new workbook with two empty worksheets and assigns sample values to the sheets. The __FindOptions__ created below specifies that the search will be conducted for the whole workbook and will start from cell A1 of the first worksheet. The sample snippet illustrates how to use __Find()__ and __FindAll()__ methods.
        

#### __[C#] Example 1: Perform find an find all__

{{region radspreadprocessing-features-find-and-replace_0}}
    Workbook workbook = new Workbook();
    Worksheet worksheet1 = workbook.Worksheets.Add();
    Worksheet worksheet2 = workbook.Worksheets.Add();

    worksheet1.Cells[1, 1].SetValue("SUMMARY");
    worksheet1.Cells[1, 2].SetValue("=SUM(5, 6)");

    worksheet2.Cells[2, 2].SetValue("=SUM(4, 4)");
    worksheet2.Cells[2, 3].SetValue("SUM");

    FindOptions options = new FindOptions()
    {
        StartCell = new WorksheetCellIndex(worksheet1, 0, 0),
        FindBy = FindBy.Rows,
        FindIn = FindInContentType.Formulas,
        FindWhat = "SUM",
        FindWithin = FindWithin.Workbook,
    };

    FindResult findResult = workbook.Find(options);
    IEnumerable<FindResult> findResults = workbook.FindAll(options);
{{endregion}}



## Replace and ReplaceAll

As a supplement to the __Find()__ and __FindAll()__ methods, the Workbook and Worksheet classes offer two more methods that allow you to alter the found strings: __Replace()__ and __ReplaceAll()__. The former method replaces the string of the first occurrence while the latter alters all encountered occurrences. The two methods take one argument of type __ReplaceOptions__ that specifies how the search is performed and also the string that should replace the occurrences. The class derives from __FindOptions__ and defines one more property:
        

* __ReplaceWith__: Specifies the string that will replace any found value.
            

__Example 2__ creates a workbook from scratch with two empty worksheet and adds some sample values. The __ReplaceOptions__ instance specifies that the replace is performed on the whole workbook and includes formula values. The operation starts from cell A1 of the first worksheet and the search is done by columns.
        

#### __[C#] Example 2: Perform replace and replace all__

{{region radspreadprocessing-features-find-and-replace_1}}
    Workbook workbook = new Workbook();
    Worksheet worksheet1 = workbook.Worksheets.Add();
    Worksheet worksheet2 = workbook.Worksheets.Add();

    worksheet1.Cells[1, 1].SetValue("SUMMARY");
    worksheet1.Cells[1, 2].SetValue("=SUM(5, 6)");

    worksheet2.Cells[2, 2].SetValue("=SUM(4, 4)");
    worksheet2.Cells[2, 3].SetValue("SUM");

    ReplaceOptions options = new ReplaceOptions()
    {
        StartCell = new WorksheetCellIndex(worksheet1, 0, 0),
        FindBy = FindBy.Rows,
        FindIn = FindInContentType.Formulas,
        FindWhat = "SUM",
        ReplaceWith = "Test",
        FindWithin = FindWithin.Workbook,
    };

    var findResult = workbook.Find(options);

    options.StartCell = findResult.FoundCell;

    if (workbook.Replace(options))
    {
        RadWindow.Alert("Replace was successful!");
    }

    workbook.ReplaceAll(options);
{{endregion}}



# See Also

 * [Activate a Worksheet]({%slug radspreadprocessing-working-with-worksheets-activate-worksheet%})
