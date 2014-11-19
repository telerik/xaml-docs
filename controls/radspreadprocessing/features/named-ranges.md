---
title: Names (Named Ranges)
page_title: Names (Named Ranges)
description: Names (Named Ranges)
slug: radspreadprocessing-features-named-ranges
tags: names,(named,ranges)
published: True
position: 9
---

# Names (Named Ranges)



This article introduces the concept of Names (Named Ranges) in the document model and demonstrates how to add, use and remove names. It contains the following sections:
      

* [What is a Name?](#what-is-a-name)

* [Types of Names](#types-of-names)

* [Add and Use Defined Names](#add-and-use-a-defined-name)

* [Remove Defined Names](#remove-defined-names)

## What Is a Name

Names in the context of the document model serve as variables. Each name can be assigned any value that can be stored in a cell: a number or text constant, a formula, or a cell reference. Also, names add meaning to the value they contain. For example, a name object called *CorporateTax* with value 0.16 is more informative than a cell containing the 16 percent constant. In the same way, using a name called *Income* provides relevant information about its contents compared to the range G11:K27.
        

All names conform to the __ISpreadsheetName__ interface. The interface exposes the following properties:
        

* __Name__: String property that determines the name of the spreadsheet name.
            

* __Scope__: Property of type SpreadsheetNameCollectionScope that indicates the scope of the name. More information about name's scope is available in the Name Scope subsection.
            

* __Comment__: String property that contains the comment of the name.
            

* __RefersTo__: String property that contains the raw string value of the name. When creating a new name the RefersTo string will be parsed and stored as the value of the name.
            

* __Value__: String property that determines how the result value of the name appears.
            

### Names Syntax Rules

There are several syntax rules for name object's __Name__ property:
            

* Each name should be unique in its scope. Names are case insensitive, so two name objects with names 'range1' and 'RANGE1' cannot reside within the same scope.
                

* The first letter of a name can be a letter, an underscore character (_), or a backslash (\).
                

* The names cannot be cell references such as  A1, D$2.
                

* Spaces are not valid characters.
                

### Name Scope

Both Workbook and Worksheet classes expose a Names property of type NameCollection that allows you to add and remove names. Adding a name to any of these collections positions the new added name in a given scope – this can be either the workbook or any of the worksheets.
            

The scope of a name refers to the location within which the name is recognized without qualification. For example, if you create the name *Tax* with scope Sheet1, you can use it within the sheet without a qualifier. If you would like to use it in the other worksheets, however, you need to add qualification: *Sheet1!Tax*. If the scope of the Tax name is the workbook, however, you will be able to access it without qualification throughout the workbook.
            

Note that qualifier for a workbook name is required only if the current worksheet contains a name object with the same name property. For example, if both the workbook and sheet2 contain a name called Tax, and you access the name without a qualifier in sheet2, by default the local name object will be referred. To access the workbook's Tax from sheet2, use the name with a qualifier: *Book1!Tax*.
            

## Types of Names

Тhe document model  has support only for Defined Names.
        

__Defined name__: A name that can contain any value that can be stored in a cell: a number or text constant, a formula, or a cell reference. You can create your own defined names. Note that you can edit the name, value and comment of the already created defined name, however, you cannot change its scope.
        

## Add and Use a Defined Name

__Example 1__ demonstrates how to add and use defined names. The code creates a workbook with one worksheet containing four values. Further, the example adds one global name called CorporateTax containing a constant value of 16 percent and a local GrossProfit name referring to the four values stored in Sheet1. Also, the cell A5 is assigned a value that uses a both GrossProfit and CorporateTax names.
        

#### __[C#] Example 1: Add and use names__

{{region radspreadprocessing-features-named-ranges_0}}
    Workbook workbook = new Workbook();
    Worksheet sheet1 = workbook.Worksheets.Add();

    sheet1.Cells[0, 0].SetValue(23738);
    sheet1.Cells[1, 0].SetValue(19012);
    sheet1.Cells[2, 0].SetValue(22544);
    sheet1.Cells[3, 0].SetValue(27690);

    workbook.Names.Add("CorporateTax", "=0.16", new CellIndex(0, 0), "Corporate Tax for Canada");
    sheet1.Names.Add("GrossProfit", "=Sheet1!$A$1:$A$4", new CellIndex(0, 0), "Gross Profit");
    sheet1.Cells[4, 0].SetValue("=SUM(GrossProfit) * CorporateTax");

    workbook.Names.Remove("CorporateTax");
    sheet1.Names.Remove("GrossProfit");
{{endregion}}



## Remove Defined Names

The NameCollection class exposes a __Remove()__ method that takes a string parameter specifying the name of the name which can be used to delete names. Note that after you delete the names, all names that contain them in their values will return the __#NAME? error__.
        

__Example 2__ shows how to remove one of the names added in __Example 1__.
        

#### __[C#] Example 2: Remove name__

{{region radspreadprocessing-features-named-ranges_1}}
    workbook.Names.Remove("CorporateTax");
    sheet1.Names.Remove("GrossProfit");
{{endregion}}


