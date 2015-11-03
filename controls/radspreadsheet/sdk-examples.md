---
title: Developer Focused Examples
page_title: Developer Focused Examples
description: Developer Focused Examples
slug: radspreadsheet-sdk-examples
tags: sdk,examples
published: True
position: 3
---

# Developer Focused Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadSpreadsheet__.

## List of all RadSpreadsheet SDK examples:

{% if site.site_name == 'WPF' %}

* __[Custom ContextMenu](https://github.com/telerik/xaml-sdk/tree/master/Spreadsheet/CustomContextMenu)__ - 
This example demonstrates how to customize the context menu of the worksheet editor and add a custom command that highlights the selected cells. You can find more details on the scenario in the following blog post: http://blogs.telerik.com/xamlteam/posts/14-04-14/radspreadsheet-tips-and-tricks-customize-the-context-menu-like-a-pro.
* __[Custom functions](https://github.com/telerik/xaml-sdk/tree/master/Spreadsheet/CustomFunctions)__ - This examples shows how to create and register custom functions in RadSpreadsheet.
The example shows several functions inheriting from different members from RadSpreadsheet functions inheritance tree.
 - Arguments and E functions are inheriting from FunctionBase abstract class.
 - RepeatString function is inheriting from FunctionWithArguments abstract class.
 - Add and GeoMean functions are inheriting from NumbersInFunction abstract class and are using their own ArgumentConversionRules.
 - Nand function is inheriting from BooleansInFunction abstract class.
 - Upper function is inheriting from StringsInFunction abstract class and is overriding the definition of the default RadSpreadsheet "UPPER" function.
 
You should additionally notice that all this function classes are registered through the FunctionManager class, so that they can be used in RadSpreadsheet.
* __[Custom row and column headings](https://github.com/telerik/xaml-sdk/tree/master/Spreadsheet/CustomRowAndColumnHeadings)__ - This examples shows how to change the row and column headers or hide them in RadSpreadsheet.
The example shows two different custom header name rendering converters:
 - NumberedColumnsHeaderNameRenderingConverter which makes all column headers to be numbers (1, 2, 3,...) instead of letters (A, B, C,...)
 - DynamicHeaderNameRenderincConverter which makes row and column headers that intersect with the table data on scroling to contain the data
   from the first row and first column of the table.
* __[First look](https://github.com/telerik/xaml-sdk/tree/master/Spreadsheet/FirstLook)__ - This example shows how a RadSpreadsheet component can be integrated with RadRibbonView in order to achieve Microsoft Excel-like look.
* __[Localization](https://github.com/telerik/xaml-sdk/tree/master/Spreadsheet/Localization)__ - This example shows how the RadSpreadsheet can be localized.
* __[RadToolBar UI](https://github.com/telerik/xaml-sdk/tree/master/Spreadsheet/RadToolBarUI)__ - 
This example shows how to bind RadSpreadsheet to RadToolBar. The ToolBar contains buttons that allow the user to open, save and create files and to cut, copy and paste the contents of the worksheet.  You can find more details on the scenario in the following blog post: http://blogs.telerik.com/xamlteam/posts/14-03-21/radspreadsheet-tips-and-tricks-radtoolbar-in-radspreadsheet-no-problemo.
* __[Thread safe format provider](https://github.com/telerik/xaml-sdk/tree/master/Spreadsheet/ThreadSafeFormatProvider)__ - This WPF example shows how RadSpreadsheet provides an easy solution for making import and export of files asynchronous and thread safe.
The example UserControl provides four buttons:
 - "Open file synchronously" button opens big file synchronously. When pressing this button you may see how the UI thread is unresponsive during the time-consuming import.
 - "Open file asynchronously" button opens the same big file asynchronously. When pressing this button you may notice that the UI thread is responsive as it successfully shows the loading RadBusyIndicator during the import.
 - "Save file synchronously" button saves current Workbook to file synchronously. When pressing this button you may see how the UI thread is unresponsive during the export (this is easier to be noticed when saving big files with time-consuming export).
 - "Save file asynchronously" button saves current Workbook to file asynchronously. When pressing this button you may notice that the UI thread is responsive as you may interact freely with the UserControl during the export.
* __[Worksheet editor ContextMenu](https://github.com/telerik/xaml-sdk/tree/master/Spreadsheet/WorksheetEditorContextMenu)__ - 
This examples sets up a simple menu with several commands: cut, copy, paste, clear contents. Also the menu has two items allow the user to insert and delete cells respectively. 
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[Custom ContextMenu](https://github.com/telerik/xaml-sdk/tree/master/Spreadsheet/CustomContextMenu)__ - 
This example demonstrates how to customize the context menu of the worksheet editor and add a custom command that highlights the selected cells. You can find more details on the scenario in the following blog post: http://blogs.telerik.com/xamlteam/posts/14-04-14/radspreadsheet-tips-and-tricks-customize-the-context-menu-like-a-pro.
* __[Custom functions](https://github.com/telerik/xaml-sdk/tree/master/Spreadsheet/CustomFunctions)__ - This examples shows how to create and register custom functions in RadSpreadsheet.
The example shows several functions inheriting from different members from RadSpreadsheet functions inheritance tree.
 - Arguments and E functions are inheriting from FunctionBase abstract class.
 - RepeatString function is inheriting from FunctionWithArguments abstract class.
 - Add and GeoMean functions are inheriting from NumbersInFunction abstract class and are using their own ArgumentConversionRules.
 - Nand function is inheriting from BooleansInFunction abstract class.
 - Upper function is inheriting from StringsInFunction abstract class and is overriding the definition of the default RadSpreadsheet "UPPER" function.
 
You should additionally notice that all this function classes are registered through the FunctionManager class, so that they can be used in RadSpreadsheet.
* __[Custom row and column headings](https://github.com/telerik/xaml-sdk/tree/master/Spreadsheet/CustomRowAndColumnHeadings)__ - This examples shows how to change the row and column headers or hide them in RadSpreadsheet.
The example shows two different custom header name rendering converters:
 - NumberedColumnsHeaderNameRenderingConverter which makes all column headers to be numbers (1, 2, 3,...) instead of letters (A, B, C,...)
 - DynamicHeaderNameRenderincConverter which makes row and column headers that intersect with the table data on scroling to contain the data
   from the first row and first column of the table.
* __[First look](https://github.com/telerik/xaml-sdk/tree/master/Spreadsheet/FirstLook)__ - This example shows how a RadSpreadsheet component can be integrated with RadRibbonView in order to achieve Microsoft Excel-like look.
* __[Localization](https://github.com/telerik/xaml-sdk/tree/master/Spreadsheet/Localization)__ - This example shows how the RadSpreadsheet can be localized.
* __[RadToolBar UI](https://github.com/telerik/xaml-sdk/tree/master/Spreadsheet/RadToolBarUI)__ - 
This example shows how to bind RadSpreadsheet to RadToolBar. The ToolBar contains buttons that allow the user to open, save and create files and to cut, copy and paste the contents of the worksheet.  You can find more details on the scenario in the following blog post: http://blogs.telerik.com/xamlteam/posts/14-03-21/radspreadsheet-tips-and-tricks-radtoolbar-in-radspreadsheet-no-problemo.
* __[Worksheet editor ContextMenu](https://github.com/telerik/xaml-sdk/tree/master/Spreadsheet/WorksheetEditorContextMenu)__ - 
This examples sets up a simple menu with several commands: cut, copy, paste, clear contents. Also the menu has two items allow the user to insert and delete cells respectively. 
{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).