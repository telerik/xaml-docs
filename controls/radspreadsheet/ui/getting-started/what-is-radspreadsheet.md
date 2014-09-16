---
title: What is RadSpreadsheet?
page_title: What is RadSpreadsheet?
description: What is RadSpreadsheet?
slug: radspreadsheet-ui-getting-started-what-is-radspreadsheet
tags: what,is,radspreadsheet?
published: True
position: 0
---

# What is RadSpreadsheet?



__RadSpreadsheet__ is a control that adds spreadsheet functionality to your application. It allows you to store, organize and manipulate
        data easy and flawlessly. The control uses a fast and efficient data model that is completely decoupled from UI. The primary document used by the model is
        called a workbook. Each workbook has collection of worksheets and each worksheet contains cells organized as a table. Cells are the basic unit for storing
        data in the spreadsheet.
      

The __RadSpreadsheet__ control presents the data of its document model using great UI and also exposes powerful API that allows you to
        build custom UI.
      

## What is in it?

The main characteristics of RadSpreadsheet can be summarized in the following list:
        

* __ActiveWorksheet__ – the property of type Worksheet provides access to the active worksheet. You can find more about the
              worksheet in the [What is Worksheet article]({%slug radspreadsheet-model-working-with-worksheets-what-is-worksheet%}).
            

* __ActiveWorksheetEditor__ – the property is of type RadWorksheetEditor and provides a reference to the currently used worksheet
              editor.
            

* __CommandDescriptors__ – the property is of type CommandDescriptors and provides access to the command descriptors of the current
              active editor.
            

* __ColorPalette__ – the property is of type SpreadsheetColorPalette and refers to the current color palette.
            

* __FontsProvider__ – the property of type FontsProvider provides a reference to the font provider.
            

* __Theme__ – the property is of type DocumentTheme and gives access to the current document theme. For more information about
              the document theme refer to the Document Themes article.
            

* __Workbook__ – the property refers to the current workbook presented by the control. More information about workbook you can
              find in [What is a Workbook article]({%slug radspreadsheet-model-working-with-workbooks-what-is-workbook%}).
            

* __SetHorizontalOffset()__ – the method is used for setting the horizontal offset.
            

* __SetVerticalOffset()__ – the method is used for setting the vertical offset.
            

* __ActiveSheetChanged__ – the event occurs when the active sheet is changed.
            

* __ActiveSheetEditorChanged__ – the event occurs when the active sheet editor is changed.
            

* __WorkbookChanged__ – the event occurs when the workbook is changed.
            {% if site.site_name == 'WPF' %}

For a list of all properties, methods and events you can refer to the
            [API Reference article](http://www.telerik.com/help/wpf/allmembers_t_telerik_windows_controls_radspreadsheet.html).
          {% endif %}{% if site.site_name == 'Silverlight' %}

For a list of all properties, methods and events you can refer to the
            [API Reference article](http://www.telerik.com/help/silverlight/allmembers_t_telerik_windows_controls_radspreadsheet.html).
          {% endif %}
