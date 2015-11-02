---
title: What is a Worksheet?
page_title: What is a Worksheet?
description: What is a Worksheet?
slug: radspreadprocessing-working-with-worksheets-what-is-worksheet
tags: what,is,a,worksheet?
published: True
position: 0
---

# What is a Worksheet?



This article will help you get familiar with the concept of a worksheet and its features.
      

## What is a Worksheet

A __Worksheet__ is a collection of cells organized in rows and columns. It is the working surface you interact with to enter data. Each worksheet contains 1048576 rows and 16384 columns and serves as a giant table that allows you to organize information. Typically, a workbook contains several worksheets with related content and only one of the worksheets is active at a time.
        

## What is in it?

The main characteristics of worksheets can be summarized in the following list:
        

* __Cells__: Each worksheet has a significant number of cells that can be assigned values and various formatting options. The Cells property allows you to insert, manipulate and delete worksheet cells. More information about worksheet cells is available in the [What is a Cell?]({%slug radspreadprocessing-working-with-cells-what-is-cell%}) section.
            

* __Rows and Columns__: Cells in a worksheet are organized in rows and columns. The API of a worksheet allows you insert, manipulate and delete rows and columns. Additionally, you can adjust the height of specific rows and the width of columns. For more info about rows refer to the [Working with Rows and Columns]({%slug radspreadprocessing-working-with-rows-and-columns-what-is-row-column%}) section.
            

* __Names (Named Ranges)__: the __Worksheet__ class exposes a Names property of type NameCollection that allows you to create, update and manage names. More about the feature is available in the [Names]({%slug radspreadprocessing-features-named-ranges%}) article.
            

* __UsedCellRange and GetUsedCellRange()__: Since each worksheet contains over a million rows and more than sixteen thousand columns, it is unlikely to use the full capacity of a worksheet. Typically, a worksheet uses only a part of the available cells. That said, in a number of scenarios you might want to know which part of the worksheet contains your data and ignore the rest of the cells. The UsedCellRange property of the __Worksheet__ class returns a cell range that starts from cell A1 and holds all cells containing data or formatting. With the GetUsedCellRange() method you can pass and IEnumerable&lt;[IPropertyDefinition](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Documents_Spreadsheet_PropertySystem_IPropertyDefinition_1.htm)&gt; object to get the used cell range, holding only the cells with specific property definitions. __Example 1__ demonstrates how to get the used cell range of cells with value.

	#### __[C#] Example 1: Get the Used Cell Range of Cells With Value__
	
	{{region radspreadprocessing-working-with-worksheets-what-is-worksheet_0}}
		CellRange result = worksheet.GetUsedCellRange(new IPropertyDefinition[] { CellPropertyDefinitions.ValueProperty });
	{{endregion}}

            

* __Collection of Hyperlinks__: Each worksheet can contain numerous hyperlinks to web pages, particular cells in the workbook or email addresses. More information on the topic is available in the [Hyperlink]({%slug radspreadprocessing-features-hyperlink%}) article.
            

* __Find and Replace__: You can easily find and replace text and numbers in the content of a worksheet. For more information about the feature see the [Find and Replace]({%slug radspreadprocessing-features-find-and-replace%}) article.
            

* __Protection__: You can restrict the user from modifying the content and structure of the worksheet. When a worksheet is protected the user can edit the contents only of the cells that were explicitly marked as unlocked. Additionally, you can choose what options will be available to the user when protection is enabled. More about the feature is available in the [Worksheet Protection]({%slug radspreadprocessing-features-protection-worksheet%}) article.
            
